using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
       public static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Enter your number");
            a = int.Parse(Console.WriteLine());
             

            if (a%2 == 0 && a%3 == 0 )
            {
                Console.WriteLine("The number you entered is a PRIME number");
            }
            else
            {
                Console.WriteLine("The number you entered is not a prime number. Please enter another number");
            }
        }
    }
}
