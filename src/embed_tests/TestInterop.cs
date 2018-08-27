using NUnit.Framework;
using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Python.EmbeddingTest
{
    public class TestInterop
    {
        [Test]
        public void TestGetProtoType()
        {
            MethodProtoInfo protoInfo = new MethodProtoInfo()
            {
                ReturnType = typeof(IntPtr),
                ParametersType = new Type[] {typeof(IntPtr)}
            };
            Type t1 = Interop.GetPrototype(protoInfo);
            Type t2 = Interop.GetPrototype("tp_repr");
            Assert.AreEqual(t1, t2);
        }
    }
}
