using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Maths  //overloading 
    {
        public static int mulDisplay(int one, int two)
        {
            return one * two;
        }

        public static int mulDisplay(int one, int two, int three)
        {
            return one * two * three;
        }

        public static int mulDisplay(int one, int two, int three, int four)
        {
            return one * two * three * four;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Multiplication of two numbers: " + Maths.mulDisplay(10, 15));
            Console.WriteLine("Multiplication of three numbers: " + Maths.mulDisplay(8, 13, 20));
            Console.WriteLine("Multiplication of four numbers: " + Maths.mulDisplay(3, 7, 10, 7));
        }
    }


}


