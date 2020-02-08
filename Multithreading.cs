using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tread starts processing");

            Thread T1 = new Thread(Method1);
            Thread T2 = new Thread(Method2);
            Thread Tp = new Thread(new ParameterizedThreadStart(Test));
            Thread Ta = new Thread(new ThreadStart(FindArea));
            T1.Start();
            T2.Start();
            Tp.Start(100);
            Ta.Start();

            Console.WriteLine("Tread Ends processing");
            Console.ReadLine();
        }

        public static void Method1()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Method1 : {0}", i);
            }
        }
        public static void Method2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Method2 : {0}", i);
            }
        }
        public static void Test(object Max)
        {
            int j = Convert.ToInt32(Max);
            for (int i = 1; i <= j; i++)
            {
                Console.WriteLine("Test : {0}", i);
            }
        }

        public static void FindArea()
        {
            double area;
            Console.WriteLine("Enter the Length");
            double length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the breadth");
            double breadth = int.Parse(Console.ReadLine());

            double area = length * breadth;
            Console.WriteLine("Area : {0}", area);

        }
    }
}
