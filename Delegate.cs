using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateexercise
{
    class Program
    {
        public delegate void Mathdelegate(int a, int b);
        static void Main(string[] args)
        {
            Mathdelegate deleg = new Mathdelegate(GetAddition);
            deleg += GetSubraction;
            deleg += GetMultiplication;
            deleg += GetDivition;
            deleg.Invoke(50, 30);

        }
        public static void GetAddition(int a, int b )
        {
            double Add = (a + b);
            Console.WriteLine("The Addition of the {0} and {1} = {2}", a, b,Add);
        }
        public static void GetSubraction(int a, int b)
        {
            double Sub = (a - b);
            Console.WriteLine("The Subraction of the {0} and {1} = {2}", a, b, Sub);
        }
        public static void GetMultiplication(int a, int b)
        {
            double Multi = (a * b);
            Console.WriteLine("The Multiplication of the {0} and {1} = {2}", a, b, Multi);
        }
        public static void GetDivition(int a, int b)
        {
            double Div = (a / b);
            Console.WriteLine("The Divition of the {0} and {1} = {2}", a, b, Div);
        }
    }
}
