using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age");
               age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your name");
            var n = (Console.ReadLine());

            Console.WriteLine("Hai {0} your age is {1}", n, age);

            Console.WriteLine("Enter your Salary");
            int Salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Phone number");
            int PhoneNumber = int.Parse(Console.ReadLine());

            var details = Greetings(Salary, PhoneNumber);
            Console.WriteLine(details);
            Console.ReadLine();
        }
        public static string Greetings(int Salary,int PhoneNumber)
        {
            return string.Format("congratulations your salary was {0} and your  phone number was {1}", Salary, PhoneNumber);
        }
    }
}