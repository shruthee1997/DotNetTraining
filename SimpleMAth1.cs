using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GreaterFun();
        }
        public static void GreaterFun()
        {
            int a, b, c;
            Console.WriteLine("Enter the Value a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value c");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("The Greater Number = {0}", a);
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("The Greater Number = {0}", b);
            }
            else
            {
                Console.WriteLine("The Greater Number = {0}", c);
            }
        }
    }
}
