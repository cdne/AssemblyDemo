using System;
using System.Reflection;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFile(@"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.dll");
            ShowAssembly(assembly);

            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            ShowAssembly(executingAssembly);

            Console.Read();
        }

        public static void ShowAssembly(Assembly assembly)
        {
            Console.WriteLine($"Fullname: {assembly.FullName}\nLocation: {assembly.Location}\nCache: {assembly.GlobalAssemblyCache}, " +
                $"\nImageRunTimeVersion: {assembly.ImageRuntimeVersion}");

            foreach (var item in assembly.Modules)
            {
                Console.WriteLine($"Module Name: {item.Name}");
            }
        }
    }
}
