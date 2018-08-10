 
using System;
using System.Reflection;
using Python.Runtime.Binder;

namespace Python.Runtime.Method
{
    interface IMethodCaller
    {
        bool IsStatic { get; }
        bool CheckSelf(IntPtr self);
        bool Check(IntPtr args, int start);
        IntPtr Call(IntPtr self, IntPtr args, int start);
    }

    abstract class StaticMethodCaller : IMethodCaller
    {
        public bool IsStatic => true;
        public bool CheckSelf(IntPtr self)
        {
            throw new NotImplementedException();
        }

        public abstract bool Check(IntPtr args, int start);
        public abstract IntPtr Call(IntPtr self, IntPtr args, int start);
    }

    abstract class BoundMethodCaller<Cls> : IMethodCaller
    {
        public bool IsStatic => false;

        public bool CheckSelf(IntPtr self)
        {
            return TypeTraits<Cls>.Is(self);
        }

        public abstract bool Check(IntPtr args, int start);
        public abstract IntPtr Call(IntPtr self, IntPtr args, int start);
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


    class ActionMethodCaller<Cls> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls>)Delegate.CreateDelegate(typeof(Action<Cls>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return true;
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            _action(clrObj);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller : StaticMethodCaller
    {
        private readonly Action _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action)Delegate.CreateDelegate(typeof(Action), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return true;
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            _action();
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1>)Delegate.CreateDelegate(typeof(Action<Cls, T1>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            _action(clrObj, arg_1);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1> : StaticMethodCaller
    {
        private readonly Action<T1> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1>)Delegate.CreateDelegate(typeof(Action<T1>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            _action(arg_1);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1, T2> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            _action(clrObj, arg_1, arg_2);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2> : StaticMethodCaller
    {
        private readonly Action<T1, T2> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2>)Delegate.CreateDelegate(typeof(Action<T1, T2>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            _action(arg_1, arg_2);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1, T2, T3> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            _action(clrObj, arg_1, arg_2, arg_3);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3> : StaticMethodCaller
    {
        private readonly Action<T1, T2, T3> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            _action(arg_1, arg_2, arg_3);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1, T2, T3, T4> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            _action(clrObj, arg_1, arg_2, arg_3, arg_4);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4> : StaticMethodCaller
    {
        private readonly Action<T1, T2, T3, T4> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            _action(arg_1, arg_2, arg_3, arg_4);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            _action(clrObj, arg_1, arg_2, arg_3, arg_4, arg_5);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5> : StaticMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            _action(clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6> : StaticMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            _action(clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7> : StaticMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            _action(clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8> : StaticMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            _action(clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9> : StaticMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            _action(clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : StaticMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            _action(clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : StaticMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            T12 arg_12 = ArgParser.Extract<T12>(args, start++);
            _action(clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : StaticMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            T12 arg_12 = ArgParser.Extract<T12>(args, start++);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            T12 arg_12 = ArgParser.Extract<T12>(args, start++);
            T13 arg_13 = ArgParser.Extract<T13>(args, start++);
            _action(clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : StaticMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            T12 arg_12 = ArgParser.Extract<T12>(args, start++);
            T13 arg_13 = ArgParser.Extract<T13>(args, start++);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            T12 arg_12 = ArgParser.Extract<T12>(args, start++);
            T13 arg_13 = ArgParser.Extract<T13>(args, start++);
            T14 arg_14 = ArgParser.Extract<T14>(args, start++);
            _action(clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13, arg_14);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : StaticMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            T12 arg_12 = ArgParser.Extract<T12>(args, start++);
            T13 arg_13 = ArgParser.Extract<T13>(args, start++);
            T14 arg_14 = ArgParser.Extract<T14>(args, start++);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13, arg_14);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : BoundMethodCaller<Cls>
    {
        private readonly Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _action;

        public ActionMethodCaller(MethodInfo info)
        {
            _action = (Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>)Delegate.CreateDelegate(typeof(Action<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            T12 arg_12 = ArgParser.Extract<T12>(args, start++);
            T13 arg_13 = ArgParser.Extract<T13>(args, start++);
            T14 arg_14 = ArgParser.Extract<T14>(args, start++);
            T15 arg_15 = ArgParser.Extract<T15>(args, start++);
            _action(clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13, arg_14, arg_15);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }

    class ActionStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : StaticMethodCaller
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _action;

        public ActionStaticMethodCaller(MethodInfo info)
        {
            _action = (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>)Delegate.CreateDelegate(typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            T12 arg_12 = ArgParser.Extract<T12>(args, start++);
            T13 arg_13 = ArgParser.Extract<T13>(args, start++);
            T14 arg_14 = ArgParser.Extract<T14>(args, start++);
            T15 arg_15 = ArgParser.Extract<T15>(args, start++);
            _action(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13, arg_14, arg_15);
            Runtime.Py_IncRef(Runtime.PyNone);
            return Runtime.PyNone;
        }
    }




    class FuncMethodCaller<Cls, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return true;
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            TResult result = _func((Cls)clrObj);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<TResult> : StaticMethodCaller
    {
        private readonly Func<TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<TResult>)Delegate.CreateDelegate(typeof(Func<TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return true;
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            TResult result = _func();
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, TResult>)Delegate.CreateDelegate(typeof(Func<T1, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            TResult result = _func(arg_1);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, T2, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, T2, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1, arg_2);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, T2, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, T2, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            TResult result = _func(arg_1, arg_2);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, T2, T3, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1, arg_2, arg_3);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, T2, T3, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            TResult result = _func(arg_1, arg_2, arg_3);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, T2, T3, T4, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1, arg_2, arg_3, arg_4);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1, arg_2, arg_3, arg_4, arg_5);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4, arg_5);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            T1 arg_1 = ArgParser.Extract<T1>(args, 0);
            T2 arg_2 = ArgParser.Extract<T2>(args, 1);
            T3 arg_3 = ArgParser.Extract<T3>(args, 2);
            T4 arg_4 = ArgParser.Extract<T4>(args, 3);
            T5 arg_5 = ArgParser.Extract<T5>(args, 4);
            T6 arg_6 = ArgParser.Extract<T6>(args, 5);
            T7 arg_7 = ArgParser.Extract<T7>(args, 6);
            TResult result = _func(arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
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
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
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
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
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
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
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
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            T12 arg_12 = ArgParser.Extract<T12>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
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
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            T12 arg_12 = ArgParser.Extract<T12>(args, start++);
            T13 arg_13 = ArgParser.Extract<T13>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
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
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            T12 arg_12 = ArgParser.Extract<T12>(args, start++);
            T13 arg_13 = ArgParser.Extract<T13>(args, start++);
            T14 arg_14 = ArgParser.Extract<T14>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13, arg_14);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
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
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncMethodCaller<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : BoundMethodCaller<Cls>
    {
        private readonly Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> _func;

        public FuncMethodCaller(MethodInfo info)
        {
            _func = (Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>)Delegate.CreateDelegate(typeof(Func<Cls, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
        {
            Cls clrObj = ValueConverter<Cls>.Get(self);
            T1 arg_1 = ArgParser.Extract<T1>(args, start++);
            T2 arg_2 = ArgParser.Extract<T2>(args, start++);
            T3 arg_3 = ArgParser.Extract<T3>(args, start++);
            T4 arg_4 = ArgParser.Extract<T4>(args, start++);
            T5 arg_5 = ArgParser.Extract<T5>(args, start++);
            T6 arg_6 = ArgParser.Extract<T6>(args, start++);
            T7 arg_7 = ArgParser.Extract<T7>(args, start++);
            T8 arg_8 = ArgParser.Extract<T8>(args, start++);
            T9 arg_9 = ArgParser.Extract<T9>(args, start++);
            T10 arg_10 = ArgParser.Extract<T10>(args, start++);
            T11 arg_11 = ArgParser.Extract<T11>(args, start++);
            T12 arg_12 = ArgParser.Extract<T12>(args, start++);
            T13 arg_13 = ArgParser.Extract<T13>(args, start++);
            T14 arg_14 = ArgParser.Extract<T14>(args, start++);
            T15 arg_15 = ArgParser.Extract<T15>(args, start++);
            TResult result = _func((Cls)clrObj, arg_1, arg_2, arg_3, arg_4, arg_5, arg_6, arg_7, arg_8, arg_9, arg_10, arg_11, arg_12, arg_13, arg_14, arg_15);
            return PyValueConverter<TResult>.Convert(result);
        }
    }

    class FuncStaticMethodCaller<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : StaticMethodCaller
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> _func;

        public FuncStaticMethodCaller(MethodInfo info)
        {
            _func = (Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>)Delegate.CreateDelegate(typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>), info);
        }

        public override bool Check(IntPtr args, int start)
        {
            return TypeCheck.Check<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(args, start);
        }

        public override IntPtr Call(IntPtr self, IntPtr args, int start)
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
            return PyValueConverter<TResult>.Convert(result);
        }
    }

}
