 
using System;
using System.Reflection;
using Python.Runtime.Binder;

namespace Python.Runtime.DelegateMethod
{
    interface IDelegateCaller
    {
        IntPtr PyTarget { get; set; }
    }

    static class ActionDelegateCallerCreator
    {
        public static Func<Type[], Type>[] CreateDelgates = new Func<Type[], Type>[]
        {
            CreateActionCaller_0,
            CreateActionCaller_1,
            CreateActionCaller_2,
            CreateActionCaller_3,
            CreateActionCaller_4,
            CreateActionCaller_5,
            CreateActionCaller_6,
            CreateActionCaller_7,
            CreateActionCaller_8,
            CreateActionCaller_9,
            CreateActionCaller_10,
            CreateActionCaller_11,
            CreateActionCaller_12,
            CreateActionCaller_13,
            CreateActionCaller_14,
            CreateActionCaller_15,
        };

        static Type CreateActionCaller_0(Type[] types)
        {
            return typeof(ActionDelegateCaller);
        }

        static Type CreateActionCaller_1(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_2(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_3(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_4(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_5(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_6(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_7(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_8(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_9(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_10(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_11(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_12(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_13(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_14(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_15(Type[] types)
        {
            Type genericType = typeof(ActionDelegateCaller<,,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

    }

    static class FuncDelegateCallerCreator
    {
        public static Func<Type[], Type>[] CreateDelgates = new Func<Type[], Type>[]
        {
            CreateFuncCaller_0,
            CreateFuncCaller_1,
            CreateFuncCaller_2,
            CreateFuncCaller_3,
            CreateFuncCaller_4,
            CreateFuncCaller_5,
            CreateFuncCaller_6,
            CreateFuncCaller_7,
            CreateFuncCaller_8,
            CreateFuncCaller_9,
            CreateFuncCaller_10,
            CreateFuncCaller_11,
            CreateFuncCaller_12,
            CreateFuncCaller_13,
            CreateFuncCaller_14,
            CreateFuncCaller_15,
        };

        static Type CreateFuncCaller_0(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_1(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_2(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_3(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_4(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_5(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_6(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_7(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_8(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_9(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_10(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_11(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_12(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_13(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_14(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_15(Type[] types)
        {
            Type genericType = typeof(FuncDelegateCaller<,,,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

    }

    class ActionDelegateCaller : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke()
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
                IntPtr args = Runtime.PyTuple_New(0);
                IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
                Runtime.XDecref(args);
                if (res == IntPtr.Zero) throw new PythonException();
                Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(1);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(2);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2, T3> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2, T3 a3)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(3);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2, T3, T4> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2, T3 a3, T4 a4)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(4);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2, T3, T4, T5> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(5);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2, T3, T4, T5, T6> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(6);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2, T3, T4, T5, T6, T7> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(7);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(8);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(9);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9, T10 a10)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(10);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
                IntPtr item10 = PyValueConverter<T10>.Convert(a10);
                Runtime.PyTuple_SetItem(args, 9, item10);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9, T10 a10, T11 a11)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(11);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
                IntPtr item10 = PyValueConverter<T10>.Convert(a10);
                Runtime.PyTuple_SetItem(args, 9, item10);
                IntPtr item11 = PyValueConverter<T11>.Convert(a11);
                Runtime.PyTuple_SetItem(args, 10, item11);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9, T10 a10, T11 a11, T12 a12)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(12);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
                IntPtr item10 = PyValueConverter<T10>.Convert(a10);
                Runtime.PyTuple_SetItem(args, 9, item10);
                IntPtr item11 = PyValueConverter<T11>.Convert(a11);
                Runtime.PyTuple_SetItem(args, 10, item11);
                IntPtr item12 = PyValueConverter<T12>.Convert(a12);
                Runtime.PyTuple_SetItem(args, 11, item12);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9, T10 a10, T11 a11, T12 a12, T13 a13)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(13);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
                IntPtr item10 = PyValueConverter<T10>.Convert(a10);
                Runtime.PyTuple_SetItem(args, 9, item10);
                IntPtr item11 = PyValueConverter<T11>.Convert(a11);
                Runtime.PyTuple_SetItem(args, 10, item11);
                IntPtr item12 = PyValueConverter<T12>.Convert(a12);
                Runtime.PyTuple_SetItem(args, 11, item12);
                IntPtr item13 = PyValueConverter<T13>.Convert(a13);
                Runtime.PyTuple_SetItem(args, 12, item13);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9, T10 a10, T11 a11, T12 a12, T13 a13, T14 a14)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(14);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
                IntPtr item10 = PyValueConverter<T10>.Convert(a10);
                Runtime.PyTuple_SetItem(args, 9, item10);
                IntPtr item11 = PyValueConverter<T11>.Convert(a11);
                Runtime.PyTuple_SetItem(args, 10, item11);
                IntPtr item12 = PyValueConverter<T12>.Convert(a12);
                Runtime.PyTuple_SetItem(args, 11, item12);
                IntPtr item13 = PyValueConverter<T13>.Convert(a13);
                Runtime.PyTuple_SetItem(args, 12, item13);
                IntPtr item14 = PyValueConverter<T14>.Convert(a14);
                Runtime.PyTuple_SetItem(args, 13, item14);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9, T10 a10, T11 a11, T12 a12, T13 a13, T14 a14, T15 a15)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(15);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
                IntPtr item10 = PyValueConverter<T10>.Convert(a10);
                Runtime.PyTuple_SetItem(args, 9, item10);
                IntPtr item11 = PyValueConverter<T11>.Convert(a11);
                Runtime.PyTuple_SetItem(args, 10, item11);
                IntPtr item12 = PyValueConverter<T12>.Convert(a12);
                Runtime.PyTuple_SetItem(args, 11, item12);
                IntPtr item13 = PyValueConverter<T13>.Convert(a13);
                Runtime.PyTuple_SetItem(args, 12, item13);
                IntPtr item14 = PyValueConverter<T14>.Convert(a14);
                Runtime.PyTuple_SetItem(args, 13, item14);
                IntPtr item15 = PyValueConverter<T15>.Convert(a15);
                Runtime.PyTuple_SetItem(args, 14, item15);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class ActionDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public void Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9, T10 a10, T11 a11, T12 a12, T13 a13, T14 a14, T15 a15, T16 a16)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(16);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
                IntPtr item10 = PyValueConverter<T10>.Convert(a10);
                Runtime.PyTuple_SetItem(args, 9, item10);
                IntPtr item11 = PyValueConverter<T11>.Convert(a11);
                Runtime.PyTuple_SetItem(args, 10, item11);
                IntPtr item12 = PyValueConverter<T12>.Convert(a12);
                Runtime.PyTuple_SetItem(args, 11, item12);
                IntPtr item13 = PyValueConverter<T13>.Convert(a13);
                Runtime.PyTuple_SetItem(args, 12, item13);
                IntPtr item14 = PyValueConverter<T14>.Convert(a14);
                Runtime.PyTuple_SetItem(args, 13, item14);
                IntPtr item15 = PyValueConverter<T15>.Convert(a15);
                Runtime.PyTuple_SetItem(args, 14, item15);
                IntPtr item16 = PyValueConverter<T16>.Convert(a16);
                Runtime.PyTuple_SetItem(args, 15, item16);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr res = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (res == IntPtr.Zero) throw new PythonException();
            Runtime.XDecref(res);
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }


    class FuncDelegateCaller<TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke()
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(0);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(1);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, T2, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1, T2 a2)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(2);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, T2, T3, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1, T2 a2, T3 a3)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(3);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, T2, T3, T4, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1, T2 a2, T3 a3, T4 a4)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(4);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, T2, T3, T4, T5, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(5);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, T2, T3, T4, T5, T6, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(6);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, T2, T3, T4, T5, T6, T7, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(7);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(8);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(9);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9, T10 a10)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(10);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
                IntPtr item10 = PyValueConverter<T10>.Convert(a10);
                Runtime.PyTuple_SetItem(args, 9, item10);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9, T10 a10, T11 a11)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(11);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
                IntPtr item10 = PyValueConverter<T10>.Convert(a10);
                Runtime.PyTuple_SetItem(args, 9, item10);
                IntPtr item11 = PyValueConverter<T11>.Convert(a11);
                Runtime.PyTuple_SetItem(args, 10, item11);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9, T10 a10, T11 a11, T12 a12)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(12);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
                IntPtr item10 = PyValueConverter<T10>.Convert(a10);
                Runtime.PyTuple_SetItem(args, 9, item10);
                IntPtr item11 = PyValueConverter<T11>.Convert(a11);
                Runtime.PyTuple_SetItem(args, 10, item11);
                IntPtr item12 = PyValueConverter<T12>.Convert(a12);
                Runtime.PyTuple_SetItem(args, 11, item12);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9, T10 a10, T11 a11, T12 a12, T13 a13)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(13);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
                IntPtr item10 = PyValueConverter<T10>.Convert(a10);
                Runtime.PyTuple_SetItem(args, 9, item10);
                IntPtr item11 = PyValueConverter<T11>.Convert(a11);
                Runtime.PyTuple_SetItem(args, 10, item11);
                IntPtr item12 = PyValueConverter<T12>.Convert(a12);
                Runtime.PyTuple_SetItem(args, 11, item12);
                IntPtr item13 = PyValueConverter<T13>.Convert(a13);
                Runtime.PyTuple_SetItem(args, 12, item13);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9, T10 a10, T11 a11, T12 a12, T13 a13, T14 a14)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(14);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
                IntPtr item10 = PyValueConverter<T10>.Convert(a10);
                Runtime.PyTuple_SetItem(args, 9, item10);
                IntPtr item11 = PyValueConverter<T11>.Convert(a11);
                Runtime.PyTuple_SetItem(args, 10, item11);
                IntPtr item12 = PyValueConverter<T12>.Convert(a12);
                Runtime.PyTuple_SetItem(args, 11, item12);
                IntPtr item13 = PyValueConverter<T13>.Convert(a13);
                Runtime.PyTuple_SetItem(args, 12, item13);
                IntPtr item14 = PyValueConverter<T14>.Convert(a14);
                Runtime.PyTuple_SetItem(args, 13, item14);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

    class FuncDelegateCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : IDelegateCaller
    {
        public IntPtr PyTarget { get; set; }

        public TResult Invoke(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9, T10 a10, T11 a11, T12 a12, T13 a13, T14 a14, T15 a15)
        {
            IntPtr gs = PythonEngine.AcquireLock();
            try
            {
            IntPtr args = Runtime.PyTuple_New(15);
            if (args == IntPtr.Zero) throw new PythonException();
            try
            {
                IntPtr item1 = PyValueConverter<T1>.Convert(a1);
                Runtime.PyTuple_SetItem(args, 0, item1);
                IntPtr item2 = PyValueConverter<T2>.Convert(a2);
                Runtime.PyTuple_SetItem(args, 1, item2);
                IntPtr item3 = PyValueConverter<T3>.Convert(a3);
                Runtime.PyTuple_SetItem(args, 2, item3);
                IntPtr item4 = PyValueConverter<T4>.Convert(a4);
                Runtime.PyTuple_SetItem(args, 3, item4);
                IntPtr item5 = PyValueConverter<T5>.Convert(a5);
                Runtime.PyTuple_SetItem(args, 4, item5);
                IntPtr item6 = PyValueConverter<T6>.Convert(a6);
                Runtime.PyTuple_SetItem(args, 5, item6);
                IntPtr item7 = PyValueConverter<T7>.Convert(a7);
                Runtime.PyTuple_SetItem(args, 6, item7);
                IntPtr item8 = PyValueConverter<T8>.Convert(a8);
                Runtime.PyTuple_SetItem(args, 7, item8);
                IntPtr item9 = PyValueConverter<T9>.Convert(a9);
                Runtime.PyTuple_SetItem(args, 8, item9);
                IntPtr item10 = PyValueConverter<T10>.Convert(a10);
                Runtime.PyTuple_SetItem(args, 9, item10);
                IntPtr item11 = PyValueConverter<T11>.Convert(a11);
                Runtime.PyTuple_SetItem(args, 10, item11);
                IntPtr item12 = PyValueConverter<T12>.Convert(a12);
                Runtime.PyTuple_SetItem(args, 11, item12);
                IntPtr item13 = PyValueConverter<T13>.Convert(a13);
                Runtime.PyTuple_SetItem(args, 12, item13);
                IntPtr item14 = PyValueConverter<T14>.Convert(a14);
                Runtime.PyTuple_SetItem(args, 13, item14);
                IntPtr item15 = PyValueConverter<T15>.Convert(a15);
                Runtime.PyTuple_SetItem(args, 14, item15);
            }
            catch (Exception)
            {
                Runtime.XDecref(args);
                throw;
            }
            IntPtr pyres = Runtime.PyObject_Call(PyTarget, args, IntPtr.Zero);
            Runtime.XDecref(args);
            if (pyres == IntPtr.Zero) throw new PythonException();
            try
            {
                return ValueConverter<TResult>.Get(pyres);
            }
            finally
            {
                Runtime.XDecref(pyres);
            }
            }
            finally
            {
                PythonEngine.ReleaseLock(gs);
            }
        }
    }

}
