using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Diagnostics;

namespace Python.Runtime
{
    /// <summary>
    /// Implements a Python binding type for CLR methods. These work much like
    /// standard Python method bindings, but the same type is used to bind
    /// both static and instance methods.
    /// </summary>
    internal class MethodBinding : ExtensionType
    {
        internal MethodInfo info;
        internal MethodObject m;
        internal IntPtr target;
        internal IntPtr targetType;

        public MethodBinding(MethodObject m, IntPtr target, IntPtr targetType)
        {
            Runtime.XIncref(target);
            this.target = target;

            Runtime.XIncref(targetType);
            if (targetType == IntPtr.Zero)
            {
                targetType = Runtime.PyObject_Type(target);
            }
            this.targetType = targetType;

            this.info = null;
            this.m = m;
        }

        public MethodBinding(MethodObject m, IntPtr target) : this(m, target, IntPtr.Zero)
        {
        }

        /// <summary>
        /// Implement binding of generic methods using the subscript syntax [].
        /// </summary>
        public static IntPtr mp_subscript(IntPtr tp, IntPtr idx)
        {
            var self = (MethodBinding)GetManagedObject(tp);

            Type[] types = Runtime.PythonArgsToTypeArray(idx);
            if (types == null)
            {
                return Exceptions.RaiseTypeError("type(s) expected");
            }

            MethodInfo mi = MethodBinder.MatchParameters(self.m.info, types);
            if (mi == null)
            {
                return Exceptions.RaiseTypeError("No match found for given type params");
            }

            var mb = new MethodBinding(self.m, self.target) { info = mi };
            Runtime.XIncref(mb.pyHandle);
            return mb.pyHandle;
        }


        /// <summary>
        /// MethodBinding __getattribute__ implementation.
        /// </summary>
        public static IntPtr tp_getattro(IntPtr ob, IntPtr key)
        {
            var self = (MethodBinding)GetManagedObject(ob);

            if (!Runtime.PyString_Check(key))
            {
                Exceptions.SetError(Exceptions.TypeError, "string expected");
                return IntPtr.Zero;
            }

            string name = Runtime.GetManagedString(key);
            switch (name)
            {
                case "__doc__":
                    IntPtr doc = self.m.GetDocString();
                    Runtime.XIncref(doc);
                    return doc;
                // FIXME: deprecate __overloads__ soon...
                case "__overloads__":
                case "Overloads":
                    var om = new OverloadMapper(self.m, self.target);
                    Runtime.XIncref(om.pyHandle);
                    return om.pyHandle;
                default:
                    return Runtime.PyObject_GenericGetAttr(ob, key);
            }
        }


        /// <summary>
        /// MethodBinding  __call__ implementation.
        /// </summary>
        public static IntPtr tp_call(IntPtr ob, IntPtr args, IntPtr kw)
        {
            var self = (MethodBinding)GetManagedObject(ob);

            // This works around a situation where the wrong generic method is picked,
            // for example this method in the tests: string Overloaded<T>(int arg1, int arg2, string arg3)
            if (self.info != null)
            {
                if (self.info.IsGenericMethod)
                {
                    int len = Runtime.PyTuple_Size(args); //FIXME: Never used
                    Type[] sigTp = Runtime.PythonArgsToTypeArray(args, true);
                    if (sigTp != null)
                    {
                        Type[] genericTp = self.info.GetGenericArguments();
                        MethodInfo betterMatch = MethodBinder.MatchSignatureAndParameters(self.m.info, genericTp, sigTp);
                        if (betterMatch != null)
                        {
                            self.info = betterMatch;
                        }
                    }
                }
            }

            // This supports calling a method 'unbound', passing the instance
            // as the first argument. Note that this is not supported if any
            // of the overloads are static since we can't know if the intent
            // was to call the static method or the unbound instance method.
            var disposeList = new List<IntPtr>();
            try
            {
                IntPtr target = self.target;

                if (target == IntPtr.Zero && !self.m.IsStatic())
                {
                    int len = Runtime.PyTuple_Size(args);
                    if (len < 1)
                    {
                        Exceptions.SetError(Exceptions.TypeError, "not enough arguments");
                        return IntPtr.Zero;
                    }
                    target = Runtime.PyTuple_GetItem(args, 0);
                    Runtime.XIncref(target);
                    disposeList.Add(target);

                    args = Runtime.PyTuple_GetSlice(args, 1, len);
                    disposeList.Add(args);
                }

                // if the class is a IPythonDerivedClass and target is not the same as self.targetType
                // (eg if calling the base class method) then call the original base class method instead
                // of the target method.
                IntPtr superType = IntPtr.Zero;
                if (Runtime.PyObject_TYPE(target) != self.targetType)
                {
                    var inst = GetManagedObject(target) as CLRObject;
                    if (inst?.inst is IPythonDerivedType)
                    {
                        var baseType = GetManagedObject(self.targetType) as ClassBase;
                        if (baseType != null)
                        {
                            string baseMethodName = "_" + baseType.type.Name + "__" + self.m.name;
                            IntPtr baseMethod = Runtime.PyObject_GetAttrString(target, baseMethodName);
                            if (baseMethod != IntPtr.Zero)
                            {
                                var baseSelf = GetManagedObject(baseMethod) as MethodBinding;
                                if (baseSelf != null)
                                {
                                    self = baseSelf;
                                }
                                Runtime.XDecref(baseMethod);
                            }
                            else
                            {
                                Runtime.PyErr_Clear();
                            }
                        }
                    }
                }

                return self.m.Invoke(target, args, kw, self.info);
            }
            finally
            {
                foreach (IntPtr ptr in disposeList)
                {
                    Runtime.XDecref(ptr);
                }
            }
        }


        /// <summary>
        /// MethodBinding  __hash__ implementation.
        /// </summary>
        public static IntPtr tp_hash(IntPtr ob)
        {
            var self = (MethodBinding)GetManagedObject(ob);
            long x = 0;
            long y = 0;

            if (self.target != IntPtr.Zero)
            {
                x = Runtime.PyObject_Hash(self.target).ToInt64();
                if (x == -1)
                {
                    return new IntPtr(-1);
                }
            }

            y = Runtime.PyObject_Hash(self.m.pyHandle).ToInt64();
            if (y == -1)
            {
                return new IntPtr(-1);
            }

            x ^= y;

            if (x == -1)
            {
                x = -1;
            }

            return new IntPtr(x);
        }

        /// <summary>
        /// MethodBinding  __repr__ implementation.
        /// </summary>
        public static IntPtr tp_repr(IntPtr ob)
        {
            var self = (MethodBinding)GetManagedObject(ob);
            string type = self.target == IntPtr.Zero ? "unbound" : "bound";
            string name = self.m.name;
            return Runtime.PyString_FromString($"<{type} method '{name}'>");
        }

        /// <summary>
        /// MethodBinding dealloc implementation.
        /// </summary>
        public new static void tp_dealloc(IntPtr ob)
        {
            var self = (MethodBinding)GetManagedObject(ob);
            Runtime.XDecref(self.target);
            Runtime.XDecref(self.targetType);
            FinalizeObject(self);
        }
    }

    internal class DelegateMethodBinding : ExtensionType
    {
        MethodInfo[] info;
        Type _boundType;
        IntPtr _target;

        Dictionary<Type[], DelegateBoundMethodObject> _genericCallers;
        DelegateCallableObject _caller;
        static Comparator _comaprator = new Comparator();

        class Comparator : IEqualityComparer<Type[]>
        {
            public bool Equals(Type[] x, Type[] y)
            {
                if (x.Length != y.Length)
                {
                    return false;
                }
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] != y[i])
                    {
                        return false;
                    }
                }
                return true;
            }

            public int GetHashCode(Type[] obj)
            {
                int hash = 0;
                foreach (var item in obj)
                {
                    hash ^= item.GetHashCode();
                }
                return hash;
            }
        }

        public DelegateMethodBinding(Type type, IntPtr target, MethodInfo[] infos, DelegateCallableObject caller)
        {
            _target = target;
            _boundType = type;
            info = infos;
            _caller = caller;
            _genericCallers = new Dictionary<Type[], DelegateBoundMethodObject>(_comaprator);

        }
        /// <summary>
        /// Implement binding of generic methods using the subscript syntax [].
        /// </summary>
        public static IntPtr mp_subscript(IntPtr tp, IntPtr idx)
        {
            var self = (DelegateMethodBinding)GetManagedObject(tp);
            Debug.Assert(self.info.Length > 0);

            Type[] types = Runtime.PythonArgsToTypeArray(idx);
            if (types == null)
            {
                return Exceptions.RaiseTypeError("type(s) expected");
            }

            DelegateBoundMethodObject methodObj;
            DelegateCallableObject caller;
            if (self._genericCallers.TryGetValue(types, out methodObj))
            {
                if (methodObj.IsCallable())
                {
                    Runtime.XIncref(methodObj.pyHandle);
                    return methodObj.pyHandle;
                }
                return RaiseMatchError();
            }
            caller = new DelegateCallableObject(self.info[0].Name);

            var methods = MethodBinder.MatchParamertersMethods(self.info, types);
            foreach (var mi in methods)
            {
                if (mi.IsStatic)
                {
                    caller.AddStaticMethod(mi);
                }
                else
                {
                    caller.AddMethod(self._boundType, mi);
                }
            }
            methodObj = BoundMethodPool.NewBoundMethod(self._target, caller);
            self._genericCallers.Add(types, methodObj);
            if (methodObj.IsCallable())
            {
                Runtime.XIncref(methodObj.pyHandle);
                return methodObj.pyHandle;
            }
            return RaiseMatchError();
        }

        private static IntPtr RaiseMatchError()
        {
            return Exceptions.RaiseTypeError("No match found for given type params");
        }
        

        public static IntPtr tp_call(IntPtr ob, IntPtr args, IntPtr kw)
        {
            var self = (DelegateMethodBinding)GetManagedObject(ob);
            return self._caller.PyCall(self._target, args);
        }
    }

    internal class DelegateGenericBinding : ExtensionType
    {

        public DelegateGenericBinding()
        {

        }
    }
}
