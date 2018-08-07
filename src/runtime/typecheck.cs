 
using System;

namespace Python.Runtime.Binder
{
    static partial class TypeCheck
    {
        public static bool Check<T1>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0));
        }

        public static bool Check<T1, T2>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1));
        }

        public static bool Check<T1, T2, T3>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, 2));
        }

        public static bool Check<T1, T2, T3, T4>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, 2)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, 3));
        }

        public static bool Check<T1, T2, T3, T4, T5>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, 2)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, 3)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, 4));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, 2)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, 3)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, 4)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, 5));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, 2)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, 3)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, 4)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, 5)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, 6));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, 2)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, 3)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, 4)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, 5)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, 6)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, 7));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, 2)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, 3)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, 4)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, 5)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, 6)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, 7)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, 8));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, 2)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, 3)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, 4)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, 5)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, 6)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, 7)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, 8)) && TypeTraits<T10>.Is(Runtime.PyTuple_GetItem(args, 9));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, 2)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, 3)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, 4)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, 5)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, 6)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, 7)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, 8)) && TypeTraits<T10>.Is(Runtime.PyTuple_GetItem(args, 9)) && TypeTraits<T11>.Is(Runtime.PyTuple_GetItem(args, 10));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, 2)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, 3)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, 4)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, 5)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, 6)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, 7)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, 8)) && TypeTraits<T10>.Is(Runtime.PyTuple_GetItem(args, 9)) && TypeTraits<T11>.Is(Runtime.PyTuple_GetItem(args, 10)) && TypeTraits<T12>.Is(Runtime.PyTuple_GetItem(args, 11));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, 2)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, 3)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, 4)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, 5)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, 6)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, 7)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, 8)) && TypeTraits<T10>.Is(Runtime.PyTuple_GetItem(args, 9)) && TypeTraits<T11>.Is(Runtime.PyTuple_GetItem(args, 10)) && TypeTraits<T12>.Is(Runtime.PyTuple_GetItem(args, 11)) && TypeTraits<T13>.Is(Runtime.PyTuple_GetItem(args, 12));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, 2)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, 3)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, 4)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, 5)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, 6)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, 7)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, 8)) && TypeTraits<T10>.Is(Runtime.PyTuple_GetItem(args, 9)) && TypeTraits<T11>.Is(Runtime.PyTuple_GetItem(args, 10)) && TypeTraits<T12>.Is(Runtime.PyTuple_GetItem(args, 11)) && TypeTraits<T13>.Is(Runtime.PyTuple_GetItem(args, 12)) && TypeTraits<T14>.Is(Runtime.PyTuple_GetItem(args, 13));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, 2)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, 3)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, 4)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, 5)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, 6)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, 7)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, 8)) && TypeTraits<T10>.Is(Runtime.PyTuple_GetItem(args, 9)) && TypeTraits<T11>.Is(Runtime.PyTuple_GetItem(args, 10)) && TypeTraits<T12>.Is(Runtime.PyTuple_GetItem(args, 11)) && TypeTraits<T13>.Is(Runtime.PyTuple_GetItem(args, 12)) && TypeTraits<T14>.Is(Runtime.PyTuple_GetItem(args, 13)) && TypeTraits<T15>.Is(Runtime.PyTuple_GetItem(args, 14));
        }

        public static bool Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(IntPtr args)
        {
            return TypeTraits<T1>.Is(Runtime.PyTuple_GetItem(args, 0)) && TypeTraits<T2>.Is(Runtime.PyTuple_GetItem(args, 1)) && TypeTraits<T3>.Is(Runtime.PyTuple_GetItem(args, 2)) && TypeTraits<T4>.Is(Runtime.PyTuple_GetItem(args, 3)) && TypeTraits<T5>.Is(Runtime.PyTuple_GetItem(args, 4)) && TypeTraits<T6>.Is(Runtime.PyTuple_GetItem(args, 5)) && TypeTraits<T7>.Is(Runtime.PyTuple_GetItem(args, 6)) && TypeTraits<T8>.Is(Runtime.PyTuple_GetItem(args, 7)) && TypeTraits<T9>.Is(Runtime.PyTuple_GetItem(args, 8)) && TypeTraits<T10>.Is(Runtime.PyTuple_GetItem(args, 9)) && TypeTraits<T11>.Is(Runtime.PyTuple_GetItem(args, 10)) && TypeTraits<T12>.Is(Runtime.PyTuple_GetItem(args, 11)) && TypeTraits<T13>.Is(Runtime.PyTuple_GetItem(args, 12)) && TypeTraits<T14>.Is(Runtime.PyTuple_GetItem(args, 13)) && TypeTraits<T15>.Is(Runtime.PyTuple_GetItem(args, 14)) && TypeTraits<T16>.Is(Runtime.PyTuple_GetItem(args, 15));
        }

    }
}
