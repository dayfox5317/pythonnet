using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Python.Runtime.PythonEngine.Initialize();
            try
            {
                string[] cmd = Environment.GetCommandLineArgs();
                Runtime.Py_Main(cmd.Length, cmd);
//                using (var ps = Py.CreateScope())
//                {
//                    ps.Exec(@"
//import sys
//sys.path.append('I:/Projects/pythonnet_1/src')
//import asd
//");
//                }
            }
            finally
            {
                Python.Runtime.PythonEngine.Shutdown();
            }


        }
    }
}
