using System;
using System.Reflection;


namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asb = Assembly.LoadFrom("C:/Users/Богатырев/source/repos/NixPracticeFirstDay/Library/bin/Debug/netcoreapp3.1/Library.dll");

            Type t = asb.GetType("Library.User", true, true);

            object obj = Activator.CreateInstance(t);

            MethodInfo method = t.GetMethod("GetSalary");

            object result = method.Invoke(obj, new object[] { 6, 100});

            Console.WriteLine((result));

        }
    }
}
