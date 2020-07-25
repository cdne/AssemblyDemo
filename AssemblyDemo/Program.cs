using System;
using System.Reflection;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void ShowAssembly(Assembly assembly)
        {
            Console.WriteLine($"Fullname: {assembly.FullName}, Location: {assembly.Location}, Cache: {assembly.GlobalAssemblyCache}, " +
                $"ImageRunTimeVersion: {assembly.ImageRuntimeVersion}");

            foreach (var item in assembly.Modules)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
    }
}
