using System;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;
using Python.Runtime;
using Python.Runtime.Binder;

namespace Python.EmbeddingTest
{
    namespace BindingTest
    {
        public class DummyClass
        {
            public void AFuck<T>()
            {
                Console.WriteLine(typeof(T));
            }
            public void MethodVoid()
            {

            }

            public void Method_Arg(int a)
            {

            }

            public static void StaticCall(int a)
            {
                Console.WriteLine(a);
            }

            private int myVar = 100;

            public int MyProperty
            {
                set
                {
                    myVar = value;
                }
                get {
                    return myVar;

                }
            }

        }


        internal class DummyWrapper : WrapBinder
        {
            public override void Register(Type type)
            {
                RegisterMethod("MethodVoid", MethodVoid);
                RegisterMethod("Method_Arg", Method_Arg);
            }

            private static IntPtr MethodVoid(IntPtr self, IntPtr args)
            {
                int argc = Runtime.Runtime.PyTuple_Size(args);
                var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
                var obj = (DummyClass)clrObj.inst;
                if (argc == 0)
                {
                    obj.MethodVoid();
                    Runtime.Runtime.Py_IncRef(Runtime.Runtime.PyNone);
                    return Runtime.Runtime.PyNone;
                }
                return IntPtr.Zero;
            }

            private static IntPtr Method_Arg(IntPtr self, IntPtr args)
            {
                int argc = Runtime.Runtime.PyTuple_Size(args);
                var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
                var obj = (DummyClass)clrObj.inst;
                if (argc == 1 && TypeCheck.Check<int>(args))
                {
                    int arg_0 = ArgParser.ExtractInt32(args, 0);
                    obj.Method_Arg(arg_0);
                    Runtime.Runtime.Py_IncRef(Runtime.Runtime.PyNone);
                    return Runtime.Runtime.PyNone;
                }
                return IntPtr.Zero;
            }
        }


        public class DummyClass_Overloads
        {
            public void Method()
            {

            }

            public void Method(int a)
            {
            }

            public void Method(double a)
            {
            }

            public void Method(DummyClass_Overloads self)
            {

            }
        }

        internal class DummyClass_Overloads_Wrapper : WrapBinder
        {
            public override void Register(Type type)
            {
                RegisterMethod("Method", Method);
            }

            private static IntPtr Method(IntPtr self, IntPtr args)
            {
                int argc = Runtime.Runtime.PyTuple_Size(args);
                var clrObj = (CLRObject)ManagedType.GetManagedObject(self);
                var obj = (DummyClass_Overloads)clrObj.inst;
                if (argc == 0)
                {
                    obj.Method();
                    Runtime.Runtime.Py_IncRef(Runtime.Runtime.PyNone);
                    return Runtime.Runtime.PyNone;
                }
                if (argc == 1)
                {
                    if (TypeCheck.Check<int>(args))
                    {
                        int arg_0 = ArgParser.ExtractInt32(args, 0);
                        obj.Method(arg_0);
                        Runtime.Runtime.Py_IncRef(Runtime.Runtime.PyNone);
                        return Runtime.Runtime.PyNone;
                    }
                    else if (TypeCheck.Check<double>(args))
                    {
                        double arg_0 = ArgParser.ExtractDouble(args, 0);
                        obj.Method(arg_0);
                        Runtime.Runtime.Py_IncRef(Runtime.Runtime.PyNone);
                        return Runtime.Runtime.PyNone;
                    }
                    else if (TypeCheck.Check<BindingTest.DummyClass_Overloads>(args))
                    {
                        DummyClass_Overloads arg_0 = ArgParser.ExtractObject<DummyClass_Overloads>(args, 0);
                        obj.Method(arg_0);
                        Runtime.Runtime.Py_IncRef(Runtime.Runtime.PyNone);
                        return Runtime.Runtime.PyNone;
                    }
                    else
                    {
                        return IntPtr.Zero;
                    }
                }
                return IntPtr.Zero;
            }
        }
    }


    public class TestBinding
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            PythonEngine.Initialize();
        }

        [OneTimeTearDown]
        public void Dispose()
        {
            PythonEngine.Shutdown();
        }

        [Test]
        public void TestCall()
        {
            //NativeBinder.RegisterType(typeof(BindingTest.DummyClass), binder);
            using (var ps = Py.CreateScope())
            {
                ps.Exec(@"
from Python.EmbeddingTest.BindingTest import *
obj = DummyClass()
DummyClass.StaticCall(1233)
obj.AFuck[int]()
print(obj.MyProperty)
obj.MyProperty = 1233
obj.MethodVoid()
obj.Method_Arg(100)
");
            }
        }

        [Test]
        public void Run()
        {
            using (var ps = Py.CreateScope())
            {
                ps.Exec(@"
import sys
sys.path.append('I:/Projects/pythonnet_1/src')
import asd
");
            }
        }
    }
}
