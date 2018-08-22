using Python.Runtime.Binder;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;

namespace Python.Runtime
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr PyCFunction(IntPtr self, IntPtr args);

    enum METH
    {
        METH_VARARGS = 0x0001,
        METH_KEYWORDS = 0x0002,
        METH_NOARGS  = 0x0004,
        METH_O       = 0x0008,
        METH_CLASS   = 0x0010,
        METH_STATIC  = 0x0020,
        METH_COEXIST = 0x0040,
        METH_FASTCALL = 0x0080
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    struct PyMethodDef
    {
        public IntPtr ml_name;    /* The name of the built-in function/method */
        public IntPtr ml_meth;    /* The C function that implements it */
        public int ml_flags;      /* Combination of METH_xxx flags, which mostly
                                     describe the args expected by the C func */
        public IntPtr ml_doc;     /* The __doc__ attribute, or NULL */
    }

    /// <summary>
    /// Implements a Python type that represents a CLR method. Method objects
    /// support a subscript syntax [] to allow explicit overload selection.
    /// </summary>
    /// <remarks>
    /// TODO: ForbidPythonThreadsAttribute per method info
    /// </remarks>
    internal class MethodObject : ExtensionType
    {
        internal MethodInfo[] info;
        internal string name;
        internal MethodBinding unbound;
        internal MethodBinder binder;
        internal bool is_static = false;
        internal IntPtr doc;
        internal Type type;

        public MethodObject(Type type, string name, MethodInfo[] info)
        {
            _MethodObject(type, name, info);
        }

        public MethodObject(Type type, string name, MethodInfo[] info, bool allow_threads)
        {
            _MethodObject(type, name, info);
            binder.allow_threads = allow_threads;
        }

        private void _MethodObject(Type type, string name, MethodInfo[] info)
        {
            this.type = type;
            this.name = name;
            this.info = info;
            binder = new MethodBinder();
            foreach (MethodInfo item in info)
            {
                binder.AddMethod(item);
                if (item.IsStatic)
                {
                    this.is_static = true;
                }
            }
        }

        public virtual IntPtr Invoke(IntPtr inst, IntPtr args, IntPtr kw)
        {
            return Invoke(inst, args, kw, null);
        }

        public virtual IntPtr Invoke(IntPtr target, IntPtr args, IntPtr kw, MethodBase info)
        {
            return binder.Invoke(target, args, kw, info, this.info);
        }

        /// <summary>
        /// Helper to get docstrings from reflected method / param info.
        /// </summary>
        internal IntPtr GetDocString()
        {
            if (doc != IntPtr.Zero)
            {
                return doc;
            }
            var str = "";
            Type marker = typeof(DocStringAttribute);
            MethodBase[] methods = binder.GetMethods();
            foreach (MethodBase method in methods)
            {
                if (str.Length > 0)
                {
                    str += Environment.NewLine;
                }
                var attrs = (Attribute[])method.GetCustomAttributes(marker, false);
                if (attrs.Length == 0)
                {
                    str += method.ToString();
                }
                else
                {
                    var attr = (DocStringAttribute)attrs[0];
                    str += attr.DocString;
                }
            }
            doc = Runtime.PyString_FromString(str);
            return doc;
        }


        /// <summary>
        /// This is a little tricky: a class can actually have a static method
        /// and instance methods all with the same name. That makes it tough
        /// to support calling a method 'unbound' (passing the instance as the
        /// first argument), because in this case we can't know whether to call
        /// the instance method unbound or call the static method.
        /// </summary>
        /// <remarks>
        /// The rule we is that if there are both instance and static methods
        /// with the same name, then we always call the static method. So this
        /// method returns true if any of the methods that are represented by
        /// the descriptor are static methods (called by MethodBinding).
        /// </remarks>
        internal bool IsStatic()
        {
            return is_static;
        }

        /// <summary>
        /// Descriptor __getattribute__ implementation.
        /// </summary>
        public static IntPtr tp_getattro(IntPtr ob, IntPtr key)
        {
            var self = (MethodObject)GetManagedObject(ob);

            if (!Runtime.PyString_Check(key))
            {
                return Exceptions.RaiseTypeError("string expected");
            }

            string name = Runtime.GetManagedString(key);
            if (name == "__doc__")
            {
                IntPtr doc = self.GetDocString();
                Runtime.XIncref(doc);
                return doc;
            }

            return Runtime.PyObject_GenericGetAttr(ob, key);
        }

        /// <summary>
        /// Descriptor __get__ implementation. Accessing a CLR method returns
        /// a "bound" method similar to a Python bound method.
        /// </summary>
        public static IntPtr tp_descr_get(IntPtr ds, IntPtr ob, IntPtr tp)
        {
            var self = (MethodObject)GetManagedObject(ds);
            MethodBinding binding;

            // If the method is accessed through its type (rather than via
            // an instance) we return an 'unbound' MethodBinding that will
            // cached for future accesses through the type.

            if (ob == IntPtr.Zero)
            {
                if (self.unbound == null)
                {
                    self.unbound = new MethodBinding(self, IntPtr.Zero, tp);
                }
                binding = self.unbound;
                Runtime.XIncref(binding.pyHandle);
                ;
                return binding.pyHandle;
            }

            if (Runtime.PyObject_IsInstance(ob, tp) < 1)
            {
                return Exceptions.RaiseTypeError("invalid argument");
            }

            // If the object this descriptor is being called with is a subclass of the type
            // this descriptor was defined on then it will be because the base class method
            // is being called via super(Derived, self).method(...).
            // In which case create a MethodBinding bound to the base class.
            var obj = GetManagedObject(ob) as CLRObject;
            if (obj != null
                && obj.inst.GetType() != self.type
                && obj.inst is IPythonDerivedType
                && self.type.IsInstanceOfType(obj.inst))
            {
                ClassBase basecls = ClassManager.GetClass(self.type);
                binding = new MethodBinding(self, ob, basecls.pyHandle);
                return binding.pyHandle;
            }

            binding = new MethodBinding(self, ob, tp);
            return binding.pyHandle;
        }

        /// <summary>
        /// Descriptor __repr__ implementation.
        /// </summary>
        public static IntPtr tp_repr(IntPtr ob)
        {
            var self = (MethodObject)GetManagedObject(ob);
            return Runtime.PyString_FromString($"<method '{self.name}'>");
        }

        /// <summary>
        /// Descriptor dealloc implementation.
        /// </summary>
        public new static void tp_dealloc(IntPtr ob)
        {
            var self = (MethodObject)GetManagedObject(ob);
            Runtime.XDecref(self.doc);
            if (self.unbound != null)
            {
                Runtime.XDecref(self.unbound.pyHandle);
            }
            ExtensionType.FinalizeObject(self);
        }
    }

    internal static class BoundMethodPool
    {
        private const int MaxNumFree = 256;
        private static DelegateBoundMethodObject[] _cache = new DelegateBoundMethodObject[MaxNumFree];
        private static DelegateBoundMethodObject _freeObj = null;
        private static int _numFree = 0;

        public static DelegateBoundMethodObject NewBoundMethod(IntPtr target, DelegateCallableObject caller)
        {
            DelegateBoundMethodObject boundMethod;
            System.Diagnostics.Debug.Assert(_cache[0] == null);
            if (_numFree != 0)
            {
                boundMethod = _freeObj;
                boundMethod.Init(target, caller);
                _freeObj = _cache[--_numFree];
                return boundMethod;
            }
            boundMethod = new DelegateBoundMethodObject(target, caller);
            return boundMethod;
        }

        public static bool Recycle(DelegateBoundMethodObject method)
        {
            System.Diagnostics.Debug.Assert(_cache[0] == null);
            method.Release();
            if (_numFree >= MaxNumFree)
            {
                return false;
            }
            _cache[_numFree++] = _freeObj;
            _freeObj = method;
            return true;
        }

        public static void ClearFreeList()
        {
            ExtensionType.FinalizeObject(_freeObj);
            _freeObj = null;
            for (int i = 1; i < _numFree; i++)
            {
                if (_cache[i] != null)
                {
                    ExtensionType.FinalizeObject(_cache[i]);
                    _cache[i] = null;
                }
            }
        }
    }


    class DelegateCallableObject
    {
        Dictionary<int, List<Method.IMethodCaller>> _callers;
        private string _name;

        public DelegateCallableObject(string name)
        {
            _name = name;
            _callers = new Dictionary<int, List<Method.IMethodCaller>>();
        }

        public bool Empty()
        {
            return _callers.Count == 0;
        }


        public Method.IMethodCaller AddMethod(Type boundType, MethodInfo mi)
        {
            Type[] paramTypes = mi.GetParameters()
                .Select(T => T.ParameterType).ToArray();
            Type funcType = CreateDelegateType(boundType,
                mi.ReturnType, paramTypes);
            var caller = (Method.IMethodCaller)Activator.CreateInstance(funcType, mi);
#if AOT
            DynamicGenericHelper.RecordDynamicType(funcType);
#endif
            List<Method.IMethodCaller> callers;
            int paramCount = paramTypes.Length;
            if (!_callers.TryGetValue(paramCount, out callers))
            {
                callers = new List<Method.IMethodCaller>();
                _callers[paramCount] = callers;
            }
            callers.Add(caller);
            return caller;
        }

        public Method.IMethodCaller AddStaticMethod(MethodInfo mi)
        {
            Type[] paramTypes = mi.GetParameters()
                .Select(T => T.ParameterType).ToArray();
            Type funcType = CreateStaticDelegateType(mi.ReturnType, paramTypes);
            var caller = (Method.IMethodCaller)Activator.CreateInstance(funcType, mi);
#if AOT
            DynamicGenericHelper.RecordDynamicType(funcType);
#endif
            List<Method.IMethodCaller> callers;
            int paramCount = paramTypes.Length;
            if (!_callers.TryGetValue(paramCount, out callers))
            {
                callers = new List<Method.IMethodCaller>();
                _callers[paramCount] = callers;
            }
            callers.Add(caller);
            return caller;
        }

        public IntPtr PyCall(IntPtr self, IntPtr args)
        {
            int argc = Runtime.PyTuple_Size(args);
            // TODO: params array, default params
            List<Method.IMethodCaller> callerList;
            if (!_callers.TryGetValue(argc, out callerList))
            {
                return Exceptions.RaiseTypeError("No match found for given type params");
            }
            if (Exceptions.ErrorOccurred())
            {
                Runtime.PyErr_Print();
                Console.WriteLine();
            }
            bool needValidate = callerList.Count > 1;
            foreach (var caller in callerList)
            {
                int start = 0;
                if (!caller.IsStatic && self == IntPtr.Zero)
                {
                    self = Runtime.PyTuple_GetItem(args, 0);
                    if (!caller.CheckSelf(self))
                    {
                        // Should be invalid for next caller
                        break;
                    }
                    start = 1;
                }
                if (needValidate && !caller.Check(args, start))
                {
                    continue;
                }
                try
                {
                    IntPtr res = caller.Call(self, args, start);
#if DEBUG
                    if (res != IntPtr.Zero && Runtime.PyErr_Occurred() != 0)
                    {
                        DebugUtil.debug("");
                    }
#endif
                    return res;
                }
                catch (ConvertException)
                {
                    return IntPtr.Zero;
                }
                catch (Exception e)
                {
                    if (e.InnerException != null)
                    {
                        e = e.InnerException;
                    }
                    Console.WriteLine(e);
                    Exceptions.SetError(e);
                    return IntPtr.Zero;
                }
            }
            return Exceptions.RaiseTypeError("No match found for given type params");
            //return IntPtr.Zero;
        }

        internal static Type CreateDelegateType(Type type, Type returnType, Type[] paramTypes)
        {
            Type[] types;
            Type func;
            if (returnType == typeof(void))
            {
                types = new Type[paramTypes.Length + 1];
                types[0] = type;
                paramTypes.CopyTo(types, 1);
                func = Method.ActionCallerCreator.CreateDelgates[paramTypes.Length](types);
            }
            else
            {
                types = new Type[paramTypes.Length + 2];
                types[0] = type;
                paramTypes.CopyTo(types, 1);
                types[paramTypes.Length + 1] = returnType;
                func = Method.FuncCallerCreator.CreateDelgates[paramTypes.Length](types);
            }
            return func;
        }

        internal static Type CreateStaticDelegateType(Type returnType, Type[] paramTypes)
        {
            Type[] types;
            Type func;
            if (returnType == typeof(void))
            {
                func = Method.ActionStaticCallerCreator.CreateDelgates[paramTypes.Length](paramTypes);
            }
            else
            {
                types = new Type[paramTypes.Length + 1];
                paramTypes.CopyTo(types, 0);
                types[paramTypes.Length] = returnType;
                func = Method.FuncStaticCallerCreator.CreateDelgates[paramTypes.Length](types);
            }
            return func;
        }


    }


    static class MethodCreator
    {
        public static ExtensionType CreateDelegateMethod(Type type, string name, MethodInfo[] info)
        {
            // TODO : If it can support the GeneriType,
            // It seems it's unnecessary for Python to using these incompatible methods,
            // thus it can just skip the incompatible methods
            if (IsIncompatibleType(type)) return null;
            for (int i = 0; i < info.Length; i++)
            {
                if (!CanCreateStaticBinding(info[i]))
                {
                    return null;
                }
            }
            var caller = new DelegateCallableObject(name);
            bool hasGeneric = false;
            for (int i = 0; i < info.Length; i++)
            {
                var mi = info[i];
                if (mi.ReturnType.IsPointer)
                {
                    continue;
                }
                if (mi.GetParameters().Any(T=>T.ParameterType.IsPointer))
                {
                    continue;
                }
                if (mi.IsGenericMethod)
                {
                    hasGeneric = true;
                    continue;
                }
                if (mi.IsStatic)
                {
                    caller.AddStaticMethod(mi);
                }
                else
                {
                    caller.AddMethod(type, mi);
                }
            }
            ExtensionType binder;
            if (hasGeneric)
            {
                binder = new DelegateGenericMethodObject(caller, type, info);
            }
            else
            {
                binder = new DelegateMethodObject(caller);
            }
            return binder;
        }

        private static bool CanCreateStaticBinding(MethodInfo mi)
        {
            if (IsIncompatibleType(mi.ReturnType))
            {
                return false;
            }
            if (mi.GetParameters().Any(T => IsIncompatibleType(T.ParameterType)))
            {
                return false;
            }
            return true;
        }

        private static bool IsIncompatibleType(Type type)
        {
            if (type.IsPointer) return true;
            if (type.IsByRef) return true;
            // TODO: make generic compat
            if (type.ContainsGenericParameters) return true;
            return false;
        }
    }


    // TODO: static method
    internal class DelegateMethodObject : ExtensionType
    {
        private DelegateCallableObject _caller;
        public DelegateCallableObject Caller { get { return _caller; } }

        public DelegateMethodObject(DelegateCallableObject caller)
        {
            _caller = caller;
        }

        public bool IsCallable()
        {
            return !_caller.Empty();
        }

        public static IntPtr tp_descr_get(IntPtr ds, IntPtr ob, IntPtr tp)
        {
            var self = (DelegateMethodObject)GetManagedObject(ds);
            var boundMethod = BoundMethodPool.NewBoundMethod(ob, self._caller);
            return boundMethod.pyHandle;
        }

        public static IntPtr tp_call(IntPtr ob, IntPtr args, IntPtr kw)
        {
            var self = (DelegateMethodObject)GetManagedObject(ob);
            return self._caller.PyCall(ob, args);
        }
    }

    internal class DelegateBoundMethodObject : ExtensionType
    {
        public IntPtr Target { get; private set; }
        public DelegateCallableObject Caller { get; private set; }

        public DelegateBoundMethodObject(IntPtr target, DelegateCallableObject caller)
        {
            Init(target, caller);
        }

        public bool IsCallable()
        {
            return Caller != null && !Caller.Empty();
        }

        public void Init(IntPtr target, DelegateCallableObject caller)
        {
            Runtime.XIncref(target);
            Target = target;
            Caller = caller;
        }

        public void Release()
        {
            Runtime.XDecref(Target);
            Target = IntPtr.Zero;
            Caller = null;
        }

        public static IntPtr tp_call(IntPtr ob, IntPtr args, IntPtr kw)
        {
            var self = (DelegateBoundMethodObject)GetManagedObject(ob);
            return self.Caller.PyCall(self.Target, args);
        }

        public new static void tp_dealloc(IntPtr ob)
        {
            var self = (DelegateBoundMethodObject)GetManagedObject(ob);
            if (BoundMethodPool.Recycle(self))
            {
                Runtime.XIncref(self.pyHandle);
                return;
            }
            FinalizeObject(self);
        }
    }

    internal class DelegateGenericMethodObject : DelegateMethodObject
    {
        private MethodInfo[] _methods;
        private Type _boundType;

        public DelegateGenericMethodObject(DelegateCallableObject caller,
            Type type, MethodInfo[] infos) : base(caller)
        {
            _boundType = type;
            _methods = infos;
        }

        public new static IntPtr tp_descr_get(IntPtr ds, IntPtr ob, IntPtr tp)
        {
            var self = (DelegateGenericMethodObject)GetManagedObject(ds);
            var binding = new DelegateMethodBinding(self._boundType, ob,
                self._methods, self.Caller);
            return binding.pyHandle;
        }

        public new static IntPtr tp_call(IntPtr ob, IntPtr args, IntPtr kw)
        {
            var self = (DelegateGenericMethodObject)GetManagedObject(ob);
            return self.Caller.PyCall(ob, args);
        }
    }
}
