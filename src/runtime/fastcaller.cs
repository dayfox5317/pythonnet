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

        public static void RegisterBinder(WrapBinder binder)
        {
            _binders.Add(binder.Target, binder);
        }

        public static void UnRegisterType(Type type)
        {
            _binders.Remove(type);
        }
        
        public static WrapBinder GetBinder(Type type)
        {
            WrapBinder binder;
            if (_binders.TryGetValue(type, out binder))
            {
                binder.Init();
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
            binder.Init();
            ClassInfo info = new ClassInfo(type);
            foreach (var item in binder.IterMethodDescrs())
            {
                info.members.Add(item.Key, item.Value);
            }
            return info;
        }
    }

    public interface IWrapperInitializer
    {
        void Setup();
    }

    public abstract class WrapBinder
    {
        public Type Target { get; protected set; }

        private Dictionary<string, PyCFunction> _methods = new Dictionary<string, PyCFunction>();
        private Dictionary<string, Tuple<Interop.BinaryFunc, Interop.ObjObjFunc>> _fields;
        private PyCFunction _ctor;

        private bool _inited = false;

        public WrapBinder()
        {
            _fields = new Dictionary<string, Tuple<Interop.BinaryFunc, Interop.ObjObjFunc>>();
        }

        internal void Init()
        {
            if (_inited)
            {
                return;
            }
            _inited = true;
            Setup();
        }

        protected void RegisterCtor(PyCFunction func)
        {
            _ctor = func;
        }

        protected void RegisterMethod(string name, PyCFunction func)
        {
            // TODO: Exception handler
            _methods.Add(name, func);
        }

        protected void RegisterField(string name, Interop.BinaryFunc getter, Interop.ObjObjFunc setter)
        {
            _fields.Add(name, Tuple.Create(getter, setter));
        }

        public bool Bindable(string name)
        {
            return _methods.ContainsKey(name);
        }

        internal FastMethodCaller CreateBindCaller(string name)
        {
            return new FastMethodCaller(name, _methods[name]);
        }

        internal DelegateFieldObject CreateBindField(string name)
        {
            Tuple<Interop.BinaryFunc, Interop.ObjObjFunc> getset;
            if (!_fields.TryGetValue(name, out getset))
            {
                return null;
            }
            return new DelegateFieldObject(name, getset.Item1, getset.Item2);
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
        
        protected abstract void Setup();
    }
    

    class FastMethodCaller : ExtensionType
    {
        public string Name { get; private set; }

        private readonly PyCFunction _func;

        PyMethodDef def;
        IntPtr _methodDefPtr;
        
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
