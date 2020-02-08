using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Enter your number");
            a = int.Parse(Console.ReadLine());


            if ( a == 2 || a == 3 || a == 5)
            {
                Console.WriteLine("The number you entered is a PRIME number");
            }
            else if (a % 2 == 0 || a % 3 == 0 || a % 5 == 0 )
            {
                Console.WriteLine("The number you entered is not a prime number.Please enter another number");
            }
            else
            {
                Console.WriteLine("The number you entered is a PRIME number");
            }
        }
        
    }
}
