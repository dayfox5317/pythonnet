#if AOT
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Python.Runtime
{
    public static class DynamicGenericHelper
    {
        private static HashSet<Type> _genericTypes = new HashSet<Type>();

        [Conditional("AOT")]
        public static void RecordDynamicType(Type type)
        {
            if (_genericTypes.Contains(type))
            {
                return;
            }
            if (!type.IsGenericType)
            {
                return;
            }
            var genericArgs = type.GetGenericArguments();
            bool needRecord = false;
            foreach (var item in genericArgs)
            {
                if (item.IsValueType)
                {
                    needRecord = true;
                    break;
                }
            }
            if (!needRecord)
            {
                return;
            }
            _genericTypes.Add(type);
        }

        public static IEnumerable<string> GetAllTypeNames()
        {
            return _genericTypes
                .Select(T => GetDeclaringName(T))
                .Distinct()
                .OrderBy(T => T.Substring(0, T.IndexOf("<")));
        }

        private static string GetDeclaringName(Type type)
        {
            string name = type.FullName;
            var args = type.GetGenericArguments();
            var declArgs = new string[args.Length];
            string objName = typeof(object).FullName;
            for (int i = 0; i < args.Length; i++)
            {
                declArgs[i] = args[i].IsValueType ? args[i].FullName : objName;
            }
            string clsName = name.Substring(0, name.IndexOf('`'));
            return $"{clsName}<{string.Join(", ", declArgs)}>";
        }
    }
}
#endif
