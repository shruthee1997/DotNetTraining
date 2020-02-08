﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    delegate int Calculator(int n); 

    public class DelegateExample
    {
        static int number = 2;
        public static int add(int n)
        {
            number = number + n;
            return number;
        }
        public static int mul(int n)
        {
            number = number * n;
            return number;
        }
        public static int getNumber()
        {
            return number;
        }
        public static void Main(string[] args)
        {
            Calculator c1 = new Calculator(add); 
            Calculator c2 = new Calculator(mul);
            c1(2);  
            Console.WriteLine("Add of two Number is: " + getNumber());
            c2(3);
            Console.WriteLine("multi of Number is: " + getNumber());

        }
    }
}
