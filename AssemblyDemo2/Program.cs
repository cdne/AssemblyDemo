using System;
using System.Reflection;

namespace AssemblyDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.ServiceProcess.dll";

            BindingFlags flags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;

            Assembly assembly = Assembly.LoadFrom(path);

            Console.WriteLine(assembly.FullName);

            Type[] type = assembly.GetTypes();

            foreach (Type t in type)
            {
                Console.WriteLine("Type: {0}", t.Name);
                MemberInfo[] members = t.GetMembers(flags);

                foreach (var member in members)
                {
                    Console.WriteLine(" {0}: {1}", member.MemberType, member.Name);
                }
            }

            Console.Read();
        }
    }
}
