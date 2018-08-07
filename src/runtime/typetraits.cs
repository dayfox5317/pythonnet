using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Python.Runtime.Binder
{
    static class TypeTraitsInitilizer
    {
        public static bool InitFlag = true;


        static TypeTraitsInitilizer()
        {
            TypeTraits<int>.Is = Runtime.PyInt_Check;
            TypeTraits<uint>.Is = TypeTraits<int>.Is;

            TypeTraits<long>.Is = Runtime.PyLong_Check;
            TypeTraits<ulong>.Is = Runtime.PyLong_Check;

            TypeTraits<string>.Is = Runtime.IsStringType;
            TypeTraits<bool>.Is = Runtime.PyBool_Check;
            TypeTraits<float>.Is = Runtime.PyFloat_Check;
            TypeTraits<double>.Is = Runtime.PyFloat_Check;
            TypeTraits<decimal>.Is = Runtime.PyFloat_Check;
            TypeTraits<object[]>.Is = Runtime.PySequence_Check;
        }
    }

    static class TypeTraits<T>
    {
        static Type _type = typeof(T);
        static internal Func<IntPtr, bool> Is = DefaultChecker;
        static readonly bool _ = TypeTraitsInitilizer.InitFlag;

        static bool IsInt(IntPtr op)
        {
            IntPtr pyType = Runtime.PyObject_TYPE(op);
            return Runtime.PyIntType == pyType;
        }

        static bool DefaultChecker(IntPtr op)
        {
            // TODO: handle inherit
            if (_type.IsArray && !Runtime.PySequence_Check(op))
            {
                return false;
            }
            ClassBase cls = ClassManager.GetClass(_type);
            IntPtr pyType = Runtime.PyObject_TYPE(op);
            return cls.pyHandle == pyType;
        }

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
        public static bool CheckType(Type type, IntPtr op)
        {
            return true;
        }
    }
}
