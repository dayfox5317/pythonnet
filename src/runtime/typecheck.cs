 
using System;

namespace Python.Runtime.Binder
{
    static partial class TypeCheck
    {
        public static bool Check<T1>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2, T3>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2, T3, T4>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2, T3, T4, T5>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T10>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T10>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T11>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T10>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T11>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T12>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T10>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T11>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T12>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T13>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T10>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T11>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T12>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T13>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T14>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T10>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T11>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T12>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T13>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T14>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T15>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(IntPtr args, int start = 0)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T10>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T11>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T12>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T13>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T14>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T15>.Is(Runtime.PyTuple_GetItem(args, start++)) && TypeTraits<T16>.Is(Runtime.PyTuple_GetItem(args, start++));
        }

    }
}
