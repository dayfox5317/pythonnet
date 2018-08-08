using System;

namespace Python.Runtime
{
    public static class TuplePacker
    {
        public static IntPtr Pack<T1>(T1 a1)
        {
            IntPtr res = Runtime.PyTuple_New(1);
            if (res == IntPtr.Zero) return IntPtr.Zero;
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(res, 0, item1);
            }
            catch (Exception e)
            {
                Runtime.XDecref(res);
                Exceptions.SetError(e);
                return IntPtr.Zero;
            }
            return res;
        }

        public static IntPtr Pack<T1, T2>(T1 a1, T2 a2)
        {
            IntPtr res = Runtime.PyTuple_New(2);
            if (res == IntPtr.Zero) return IntPtr.Zero;
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(res, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(res, 1, item2);
            }
            catch (Exception e)
            {
                Runtime.XDecref(res);
                Exceptions.SetError(e);
                return IntPtr.Zero;
            }
            return res;
        }

        public static IntPtr Pack<T1, T2, T3>(T1 a1, T2 a2, T3 a3)
        {
            IntPtr res = Runtime.PyTuple_New(3);
            if (res == IntPtr.Zero) return IntPtr.Zero;
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(res, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(res, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(res, 2, item3);
            }
            catch (Exception e)
            {
                Runtime.XDecref(res);
                Exceptions.SetError(e);
                return IntPtr.Zero;
            }
            return res;
        }

        public static IntPtr Pack<T1, T2, T3, T4>(T1 a1, T2 a2, T3 a3, T4 a4)
        {
            IntPtr res = Runtime.PyTuple_New(4);
            if (res == IntPtr.Zero) return IntPtr.Zero;
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(res, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(res, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(res, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(res, 3, item4);
            }
            catch (Exception e)
            {
                Runtime.XDecref(res);
                Exceptions.SetError(e);
                return IntPtr.Zero;
            }
            return res;
        }

        public static IntPtr Pack<T1, T2, T3, T4, T5>(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5)
        {
            IntPtr res = Runtime.PyTuple_New(5);
            if (res == IntPtr.Zero) return IntPtr.Zero;
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(res, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(res, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(res, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(res, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(res, 4, item5);
            }
            catch (Exception e)
            {
                Runtime.XDecref(res);
                Exceptions.SetError(e);
                return IntPtr.Zero;
            }
            return res;
        }

        public static IntPtr Pack<T1, T2, T3, T4, T5, T6>(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6)
        {
            IntPtr res = Runtime.PyTuple_New(6);
            if (res == IntPtr.Zero) return IntPtr.Zero;
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(res, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(res, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(res, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(res, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(res, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(res, 5, item6);
            }
            catch (Exception e)
            {
                Runtime.XDecref(res);
                Exceptions.SetError(e);
                return IntPtr.Zero;
            }
            return res;
        }

        public static IntPtr Pack<T1, T2, T3, T4, T5, T6, T7>(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7)
        {
            IntPtr res = Runtime.PyTuple_New(7);
            if (res == IntPtr.Zero) return IntPtr.Zero;
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(res, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(res, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(res, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(res, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(res, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(res, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(res, 6, item7);
            }
            catch (Exception e)
            {
                Runtime.XDecref(res);
                Exceptions.SetError(e);
                return IntPtr.Zero;
            }
            return res;
        }

        public static IntPtr Pack<T1, T2, T3, T4, T5, T6, T7, T8>(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8)
        {
            IntPtr res = Runtime.PyTuple_New(8);
            if (res == IntPtr.Zero) return IntPtr.Zero;
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(res, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(res, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(res, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(res, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(res, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(res, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(res, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(res, 7, item8);
            }
            catch (Exception e)
            {
                Runtime.XDecref(res);
                Exceptions.SetError(e);
                return IntPtr.Zero;
            }
            return res;
        }

        public static IntPtr Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9)
        {
            IntPtr res = Runtime.PyTuple_New(9);
            if (res == IntPtr.Zero) return IntPtr.Zero;
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(res, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(res, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(res, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(res, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(res, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(res, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(res, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(res, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(res, 8, item9);
            }
            catch (Exception e)
            {
                Runtime.XDecref(res);
                Exceptions.SetError(e);
                return IntPtr.Zero;
            }
            return res;
        }

        public static IntPtr Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9, T10 a10)
        {
            IntPtr res = Runtime.PyTuple_New(10);
            if (res == IntPtr.Zero) return IntPtr.Zero;
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(res, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(res, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(res, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(res, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(res, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(res, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(res, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(res, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(res, 8, item9);
                IntPtr item10 = PyValueConverter<T10>.Convert(a10);
                Runtime.PyTuple_SetItem(res, 9, item10);
            }
            catch (Exception e)
            {
                Runtime.XDecref(res);
                Exceptions.SetError(e);
                return IntPtr.Zero;
            }
            return res;
        }

    }
}
