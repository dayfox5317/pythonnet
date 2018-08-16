using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Python.Runtime.Binder
{
    public class NativeBinderManager
    {
        private static Dictionary<Type, WrapBinder> _binders = new Dictionary<Type, WrapBinder>();

        public static void RegisterType(Type type, WrapBinder binder)
        {
            _binders.Add(type, binder);
        }

        public static void UnRegisterType(Type type)
        {
            _binders.Remove(type);
        }

        bool TryBindNative(Type type)
        {
            WrapBinder binder;
            if (!_binders.TryGetValue(type, out binder))
            {
                return false;
            }
            binder.Register(type);
            return true;
        }

        public static WrapBinder GetBinder(Type type)
        {
            WrapBinder binder;
            if (_binders.TryGetValue(type, out binder))
            {
                return binder;
            }
            return null;
        }
        
        internal static ClassInfo GetStaticBindClassInfo(Type type)
        {
            WrapBinder binder;
            if (!_binders.TryGetValue(type, out binder))
            {
                return null;
            }
            binder.Register(type);
            ClassInfo info = new ClassInfo(type);
            foreach (var item in binder.IterMethodDescrs())
            {
                info.members.Add(item.Key, item.Value);
            }
            return info;
        }
    }


    public abstract class WrapBinder
    {
        private Dictionary<string, PyCFunction> _methods = new Dictionary<string, PyCFunction>();
        private PyCFunction _ctor;
        public Type Target { get; protected set; }

        public void RegisterCtor(PyCFunction func)
        {
            _ctor = func;
        }

        public void RegisterMethod(string name, PyCFunction func)
        {
            // TODO: Exception handler
            PyCFunction wrapper = (self, args) =>
            {
                try
                {
                    return func(self, args);
                }
                catch (Exception)
                {
                    return IntPtr.Zero;
                }
            };
            _methods.Add(name, wrapper);
        }

        public bool Bindable(string name)
        {
            return _methods.ContainsKey(name);
        }

        internal FastMethodCaller CreateBindCaller(string name)
        {
            return new FastMethodCaller(name, _methods[name]);
        }

        internal PyCFunction CreateCtorBinder()
        {
            return _ctor;
        }

        internal IEnumerable<KeyValuePair<string, FastMethodCaller>> IterMethodDescrs()
        {
            foreach (var item in _methods)
            {
                string name = item.Key;
                PyCFunction func = item.Value;
                var descr = new FastMethodCaller(name, func);
                yield return new KeyValuePair<string, FastMethodCaller>(name, descr);
            }
        }

        void Register(Type type, string name, MethodInfo[] info)
        {

        }

        public abstract void Register(Type type);
    }

    public class StaticCallBinder
    {

    }


    class SampleClass
    {
        public int Func1(string a, int b)
        {
            return 10;
        }
    }

    class SampleWrapper : WrapBinder
    {
        public override void Register(Type type)
        {
            Add(SampleCall);
        }

        void Add(PyCFunction func)
        {
            string name = func.Method.Name;
           // var caller = new FastMethodCaller();
            
        }

        static string ExtractString(IntPtr op, int index)
        {
            IntPtr value = Runtime.PyTuple_GetItem(op, index);
            return Runtime.GetManagedString(value);
        }

        static int ExtractInt(IntPtr op, int index)
        {
            IntPtr value = Runtime.PyTuple_GetItem(op, index);
            return Runtime.PyInt_AsLong(op);
        }

        static IntPtr SampleCall(IntPtr self, IntPtr args)
        {
            int argc = Runtime.PyTuple_Size(args);
            if (argc == 2 && TypeCheck.Check<string, int>(args))
            {
                var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
                string arg0 = ExtractString(args, 0);
                int arg1 = ExtractInt(args, 1);
                ((SampleClass)clrObj.inst).Func1(arg0, arg1);
                Runtime.Py_IncRef(Runtime.PyNone);
                return Runtime.PyNone;
            }
            return IntPtr.Zero;
        }
    }

    class FastMethodCaller : ExtensionType
    {
        public string Name { get; private set; }

        private readonly PyCFunction _func;

        PyMethodDef def;
        IntPtr _methodDefPtr;

        public FastMethodCaller(Type type, string name, MethodInfo[] info)
        {
            Name = name;
        }

        public FastMethodCaller(string name, PyCFunction func)
        {
            Name = name;
            _func = func;
            IntPtr funcPtr = Marshal.GetFunctionPointerForDelegate(_func);
            _methodDefPtr = TypeManager.CreateMethodDef(Name, funcPtr, (int)METH.METH_VARARGS, null);
        }

        public static IntPtr tp_descr_get(IntPtr ds, IntPtr ob, IntPtr tp)
        {
            var self = (FastMethodCaller)GetManagedObject(ds);
            return Runtime.PyCFunction_NewEx(self._methodDefPtr, ob, IntPtr.Zero);
        }

        public new static void tp_dealloc(IntPtr ob)
        {
            var self = (FastMethodCaller)GetManagedObject(ob);
            TypeManager.FreeMethodDef(self._methodDefPtr);
            ExtensionType.tp_dealloc(ob);
        }
    }
}
