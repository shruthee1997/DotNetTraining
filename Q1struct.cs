using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Q1structcubeandsquare
{
    struct NUmber
    {
        public int num;
        public int sq;
        public int cb;

        public int square(int num)
        {
            return sq = num * num;
        }
        public int cube(int num)
        { 
        return cb = num * num * num;

        }

    }


    class Program
    {
        static void Main(string[] args)
        {

     

            int choice, num = 9;
            NUmber obj = new NUmber();

            Console.WriteLine("1. square");
            Console.WriteLine("2. cube");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {

                case 1:
                    Console.WriteLine("The Square of the number is : {0}", obj.square(num));
                    break;

                case 2:
                    Console.WriteLine("The Cube of the number is : {0}", obj.cube(num));
                    break;
            }
        }
    }
}

