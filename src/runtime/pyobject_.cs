 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;

namespace Python.Runtime
{
    public partial class PyObject : DynamicObject, IEnumerable, IDisposable
    {
        // TODO: Invoke Func<>

        public void InvokeAction()
        {
            IntPtr args = Runtime.PyTuple_New(0);
            IntPtr r;
            try
            {
                r = Runtime.PyObject_Call(obj, args, IntPtr.Zero);
            }
            finally
            {
                Runtime.XDecref(args);
            }
            if (r == IntPtr.Zero)
            {
                throw new PythonException();
            }
            Runtime.XDecref(r);
        }

        public void InvokeAction<T1>(T1 a1)
        {
            IntPtr args = TuplePacker.Pack(a1);
            if (args == IntPtr.Zero)
            {
                throw new PythonException();
            }
            IntPtr r;
            try
            {
                r = Runtime.PyObject_Call(obj, args, IntPtr.Zero);
            }
            finally
            {
                Runtime.XDecref(args);
            }
            if (r == IntPtr.Zero)
            {
                throw new PythonException();
            }
            Runtime.XDecref(r);
        }

        public void InvokeAction<T1, T2>(T1 a1, T2 a2)
        {
            IntPtr args = TuplePacker.Pack(a1, a2);
            if (args == IntPtr.Zero)
            {
                throw new PythonException();
            }
            IntPtr r;
            try
            {
                r = Runtime.PyObject_Call(obj, args, IntPtr.Zero);
            }
            finally
            {
                Runtime.XDecref(args);
            }
            if (r == IntPtr.Zero)
            {
                throw new PythonException();
            }
            Runtime.XDecref(r);
        }

        public void InvokeAction<T1, T2, T3>(T1 a1, T2 a2, T3 a3)
        {
            IntPtr args = TuplePacker.Pack(a1, a2, a3);
            if (args == IntPtr.Zero)
            {
                throw new PythonException();
            }
            IntPtr r;
            try
            {
                r = Runtime.PyObject_Call(obj, args, IntPtr.Zero);
            }
            finally
            {
                Runtime.XDecref(args);
            }
            if (r == IntPtr.Zero)
            {
                throw new PythonException();
            }
            Runtime.XDecref(r);
        }

    }
}
