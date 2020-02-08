using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sample
    {
        static void Main(string[] args)
        {
            int empAge;
            string empName;

            Console.WriteLine("enter Employee Name /n");
            empName = Console.ReadLine();
            Console.WriteLine("enter Employee Age /n");
            empAge = int.parse( Console.ReadLine());
        }
    }
}
