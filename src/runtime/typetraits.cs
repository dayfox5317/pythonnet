using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Python.Runtime.Binder
{
    static class TypeTraitsInitializer
    {
        public static bool InitFlag = true;


        static TypeTraitsInitializer()
        {
            TypeTraits<int>.Is = Runtime.PyInt_Check;
            TypeTraits<uint>.Is = TypeTraits<int>.Is;

            TypeTraits<long>.Is = Runtime.PyLong_Check;
            TypeTraits<ulong>.Is = Runtime.PyLong_Check;

            TypeTraits<string>.Is = Runtime.IsStringType;
            TypeTraits<bool>.Is = Runtime.PyBool_Check;
            TypeTraits<float>.Is = Runtime.PyFloat_Check;
            // TODO: inplicit
            TypeTraits<double>.Is = Runtime.PyFloat_Check;
            TypeTraits<decimal>.Is = Runtime.PyFloat_Check;
            TypeTraits<object[]>.Is = Runtime.PySequence_Check;
            TypeTraits<object>.Is = (op) => op != IntPtr.Zero;
            TypeTraits<PyObject>.Is = ManagedType.IsManagedType;
        }
    }

    static class TypeTraits<T>
    {
        static Type _type = typeof(T);
        private static Func<IntPtr, bool> _isType = (op) => TypeCheck.DefaultChecker(_type, op);
        //static internal Func<IntPtr, bool> Is = DefaultChecker;

        static readonly bool _ = TypeTraitsInitializer.InitFlag;

        internal static Func<IntPtr, bool> Is
        {
            get
            {
                return _isType;
            }

            set
            {
                TypeCheck.RegisterChecker(_type, value);
                _isType = value;
            }
        }

        static TypeTraits()
        {

        }

        static bool IsInt(IntPtr op)
        {
            IntPtr pyType = Runtime.PyObject_TYPE(op);
            return Runtime.PyIntType == pyType;
        }

        //static bool DefaultChecker(IntPtr op)
        //{
        //    // TODO: handle inherit
        //    if (_type.IsArray && !Runtime.PySequence_Check(op))
        //    {
        //        return CheckArray(op);
        //    }
        //    ClassBase cls = ClassManager.GetClass(_type);
        //    IntPtr pyType = Runtime.PyObject_TYPE(op);
        //    return cls.pyHandle == pyType;
        //}

        static bool CheckArray(IntPtr op)
        {
            Type elemType = _type.GetElementType();
            IntPtr pyElemType = IntPtr.Zero;
            int size = Runtime.PySequence_Size(op);
            for (int i = 0; i < size; i++)
            {
                IntPtr item = Runtime.PySequence_GetItem(op, i);
                if (item == IntPtr.Zero)
                {
                    throw new ArgumentNullException();
                }
                IntPtr pyCurType = Runtime.PyObject_TYPE(item);
                if (i == 0)
                {
                    pyElemType = pyCurType;
                }
                else
                {
                    if (pyElemType != pyCurType)
                    {
                        return false;
                    }
                }

                if (!TypeCheck.CheckType(elemType, item))
                {
                    return false;
                }
            }
            return true;
        }
    }

    static partial class TypeCheck
    {
        static Dictionary<Type, Func<IntPtr, bool>> _checkers = new Dictionary<Type, Func<IntPtr, bool>>();

        public static void RegisterChecker(Type type, Func<IntPtr, bool> checker)
        {
            if (_checkers.ContainsKey(type))
            {
                _checkers.Remove(type);
            }
            _checkers.Add(type, checker);
        }

        public static bool CheckType(Type type, IntPtr op)
        {
            Func<IntPtr, bool> checker;
            if (_checkers.TryGetValue(type, out checker))
            {
                return checker(op);
            }
            return DefaultChecker(type, op);
        }

        public static bool DefaultChecker(Type type, IntPtr op)
        {
            // TODO: handle inherit
            if (type.IsArray && Runtime.PySequence_Check(op))
            {
                return CheckArray(type, op);
            }
            if (op == Runtime.PyNone && !type.IsValueType)
            {
                return true;
            }
            // TODO: __isinstance__
            // Common case: if the Python value is a wrapped managed object
            // instance, just return the wrapped object.
            ManagedType mt = ManagedType.GetManagedObject(op);
            if (mt != null)
            {
                if (mt is CLRObject)
                {
                    object tmp = ((CLRObject)mt).inst;
                    return type.IsInstanceOfType(tmp);
                }
                if (mt is ClassBase)
                {
                    return ((ClassBase)mt).type.GetType().IsInstanceOfType(type);
                }
                // shouldn't happen
                return false;
            }
            ClassBase cls = ClassManager.GetClass(type);
            return Runtime.PyObject_IsInstance(op, cls.pyHandle) == 1;
        }

        static bool CheckArray(Type type, IntPtr op)
        {
            Type elemType = type.GetElementType();
            IntPtr pyElemType = IntPtr.Zero;
            int size = Runtime.PySequence_Size(op);
            for (int i = 0; i < size; i++)
            {
                IntPtr item = Runtime.PySequence_GetItem(op, i);
                if (item == IntPtr.Zero)
                {
                    throw new ArgumentNullException();
                }
                if (pyElemType == IntPtr.Zero && item == Runtime.PyNone)
                {
                    continue;
                }

                if (ManagedType.IsManagedType(item))
                {

                }

                //IntPtr pyCurType = Runtime.PyObject_TYPE(item);
                //if (pyElemType == IntPtr.Zero)
                //{
                //    pyElemType = pyCurType;
                //}
                //else
                //{
                //    //Runtime.PyObject_IsInstance()
                //    if (pyElemType != pyCurType)
                //    {
                //        return false;
                //    }
                //}

                if (!TypeCheck.CheckType(elemType, item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
