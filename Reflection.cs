using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load("EmployeeComponent");
            Type[] types = assembly.GetTypes();
            foreach(Type type in types)
            {
                Console.WriteLine("Base type: {0}", type.BaseType);
                Console.WriteLine("Base type: {0}", type.BaseType);

                MethodInfo[] methods = type.GetMethods();
                foreach(MethodInfo method in methods)
                {
                    Console.WriteLine("Method name: {0}", method.Name);
                    Console.WriteLine("Method type: {0}", method.ReturnType);

                    ParameterInfo[] parameters = method.GetParameters();
                    foreach(ParameterInfo param in parameters)
                    {
                        Console.WriteLine("Parameter name: {0}", param.Name);
                        Console.WriteLine("Method type: {0}", param.ParameterType);
                        Console.WriteLine("---------------------------------------------------");
                    }
                    Console.WriteLine("---------------------------------------------------");
                }
                Console.WriteLine("---------------------------------------------------");
                Console.ReadKey();
            }
        }
    }
}
