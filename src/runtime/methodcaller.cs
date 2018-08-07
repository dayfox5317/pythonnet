 
using System;
using System.Reflection;
using Python.Runtime.Binder;

namespace Python.Runtime.Method
{
    interface IMethodCaller
    {
        bool Check(IntPtr args);
        IntPtr Call(IntPtr self, IntPtr args);
    }

    static class ActionCallerCreator
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
            Type genericType = typeof(ActionMethodCaller<>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_1(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_2(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_3(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_4(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_5(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_6(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_7(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_8(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_9(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_10(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_11(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_12(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_13(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_14(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_15(Type[] types)
        {
            Type genericType = typeof(ActionMethodCaller<,,,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

    }

    static class ActionStaticCallerCreator
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
            return typeof(ActionStaticMethodCaller);
        }

        static Type CreateActionCaller_1(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_2(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_3(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_4(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_5(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_6(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_7(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_8(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_9(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_10(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_11(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_12(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_13(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_14(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateActionCaller_15(Type[] types)
        {
            Type genericType = typeof(ActionStaticMethodCaller<,,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

    }

    static class FuncCallerCreator
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
            Type genericType = typeof(FuncMethodCaller<,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_1(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_2(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_3(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_4(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_5(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_6(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_7(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_8(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_9(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_10(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_11(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_12(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_13(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_14(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_15(Type[] types)
        {
            Type genericType = typeof(FuncMethodCaller<,,,,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

    }

    static class FuncStaticCallerCreator
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
            Type genericType = typeof(FuncStaticMethodCaller<>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_1(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_2(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_3(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_4(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_5(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_6(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_7(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_8(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_9(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_10(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_11(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_12(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_13(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_14(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

        static Type CreateFuncCaller_15(Type[] types)
        {
            Type genericType = typeof(FuncStaticMethodCaller<,,,,,,,,,,,,,,,>);
            return genericType.MakeGenericType(types);
        }

    }


    class ActionMethodCaller<Cls> : IMethodCaller
    {
        private readonly Action<Cls> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls>)Delegate.CreateDelegate(typeof(Action<Cls>), info);
        }

        public bool Check(IntPtr args)
        {
            return true;
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            _action((Cls)clrObj.inst);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller : IMethodCaller
    {
        private readonly Action _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action)Delegate.CreateDelegate(typeof(Action), info);
        }

        public bool Check(IntPtr args)
        {
            return true;
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            _action();
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1> : IMethodCaller
    {
        private readonly Action<Cls, T1> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1>)Delegate.CreateDelegate(typeof(Action<Cls, T1>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            _action((Cls)clrObj.inst, arg_1);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1> : IMethodCaller
    {
        private readonly Action<T1> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1>)Delegate.CreateDelegate(typeof(Action<T1>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            _action(arg_1);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2> : IMethodCaller
    {
        private readonly Action<Cls, T1, T2> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            _action((Cls)clrObj.inst, arg_1, arg_2);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2> : IMethodCaller
    {
        private readonly Action<T1, T2> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2>)Delegate.CreateDelegate(typeof(Action<T1, T2>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            _action(arg_1, arg_2);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3> : IMethodCaller
    {
        private readonly Action<Cls, T1, T2, T3> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            _action((Cls)clrObj.inst, arg_1, arg_2, arg_3);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3> : IMethodCaller
    {
        private readonly Action<T1, T2, T3> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            _action(arg_1, arg_2, arg_3);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4> : IMethodCaller
    {
        private readonly Action<Cls, T1, T2, T3, T4> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            _action((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4> : IMethodCaller
    {
        private readonly Action<T1, T2, T3, T4> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            _action(arg_1, arg_2, arg_3, arg_4);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5> : IMethodCaller
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            _action((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5> : IMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6> : IMethodCaller
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            _action((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6> : IMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7> : IMethodCaller
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            _action((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7> : IMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8> : IMethodCaller
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            _action((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8> : IMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9> : IMethodCaller
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            _action((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IMethodCaller
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            _action((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IMethodCaller
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            _action((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IMethodCaller
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            _action((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IMethodCaller
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            T13 arg_13 = ArgParser.Extract<T13>(args, 12);
            _action((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            T13 arg_13 = ArgParser.Extract<T13>(args, 12);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IMethodCaller
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            T13 arg_13 = ArgParser.Extract<T13>(args, 12);
            T14 arg_14 = ArgParser.Extract<T14>(args, 13);
            _action((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13, arg_14);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            T13 arg_13 = ArgParser.Extract<T13>(args, 12);
            T14 arg_14 = ArgParser.Extract<T14>(args, 13);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13, arg_14);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IMethodCaller
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            T13 arg_13 = ArgParser.Extract<T13>(args, 12);
            T14 arg_14 = ArgParser.Extract<T14>(args, 13);
            T15 arg_15 = ArgParser.Extract<T15>(args, 14);
            _action((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13, arg_14, arg_15);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            T13 arg_13 = ArgParser.Extract<T13>(args, 12);
            T14 arg_14 = ArgParser.Extract<T14>(args, 13);
            T15 arg_15 = ArgParser.Extract<T15>(args, 14);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13, arg_14, arg_15);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }




    class FuncMethodCaller<Cls, TResult> : IMethodCaller
    {
        private readonly Func<Cls, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return true;
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            TResult result = _func((Cls)clrObj.inst);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<TResult> : IMethodCaller
    {
        private readonly Func<TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<TResult>)Delegate.CreateDelegate(typeof(Func<TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return true;
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            TResult result = _func();
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            TResult result = _func((Cls)clrObj.inst, arg_1);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, TResult> : IMethodCaller
    {
        private readonly Func<T1, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, TResult>)Delegate.CreateDelegate(typeof(Func<T1, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            TResult result = _func(arg_1);
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, T2, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, T2, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            TResult result = _func((Cls)clrObj.inst, arg_1, arg_2);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, T2, TResult> : IMethodCaller
    {
        private readonly Func<T1, T2, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            TResult result = _func(arg_1, arg_2);
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, T2, T3, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            TResult result = _func((Cls)clrObj.inst, arg_1, arg_2, arg_3);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, TResult> : IMethodCaller
    {
        private readonly Func<T1, T2, T3, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            TResult result = _func(arg_1, arg_2, arg_3);
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, T2, T3, T4, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            TResult result = _func((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, TResult> : IMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4);
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            TResult result = _func((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, TResult> : IMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4, arg_5);
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            TResult result = _func((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, TResult> : IMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6);
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            TResult result = _func((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, TResult> : IMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7);
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            TResult result = _func((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : IMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8);
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            TResult result = _func((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : IMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9);
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            TResult result = _func((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : IMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10);
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            TResult result = _func((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : IMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11);
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            TResult result = _func((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : IMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12);
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            T13 arg_13 = ArgParser.Extract<T13>(args, 12);
            TResult result = _func((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : IMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            T13 arg_13 = ArgParser.Extract<T13>(args, 12);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13);
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            T13 arg_13 = ArgParser.Extract<T13>(args, 12);
            T14 arg_14 = ArgParser.Extract<T14>(args, 13);
            TResult result = _func((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13, arg_14);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : IMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            T13 arg_13 = ArgParser.Extract<T13>(args, 12);
            T14 arg_14 = ArgParser.Extract<T14>(args, 13);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13, arg_14);
            return result.ToPythonPtr();
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : IMethodCaller
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            T13 arg_13 = ArgParser.Extract<T13>(args, 12);
            T14 arg_14 = ArgParser.Extract<T14>(args, 13);
            T15 arg_15 = ArgParser.Extract<T15>(args, 14);
            TResult result = _func((Cls)clrObj.inst, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13, arg_14, arg_15);
            return result.ToPythonPtr();
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : IMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>), info);
        }

        public bool Check(IntPtr args)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(args);
        }

        public IntPtr Call(IntPtr self, IntPtr args)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            T8 arg_8 = ArgParser.Extract<T8>(args, 7);
            T9 arg_9 = ArgParser.Extract<T9>(args, 8);
            T10 arg_10 = ArgParser.Extract<T10>(args, 9);
            T11 arg_11 = ArgParser.Extract<T11>(args, 10);
            T12 arg_12 = ArgParser.Extract<T12>(args, 11);
            T13 arg_13 = ArgParser.Extract<T13>(args, 12);
            T14 arg_14 = ArgParser.Extract<T14>(args, 13);
            T15 arg_15 = ArgParser.Extract<T15>(args, 14);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13, arg_14, arg_15);
            return result.ToPythonPtr();
        }
    }

}
