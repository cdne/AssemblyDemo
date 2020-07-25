using System;
using System.Reflection;

[assembly: AssemblyDescription("This is a demo of the AssemblyDescription attribute.")]

namespace AssemblyAttrDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type type = typeof(AssemblyDescriptionAttribute);

            object[] assemblyAttributes = assembly.GetCustomAttributes(type, false);

            if(assemblyAttributes.Length > 0)
            {
                var description = (AssemblyDescriptionAttribute)assemblyAttributes[0];
                Console.WriteLine("Description is: {0}", description);
            }
        }
    }
}