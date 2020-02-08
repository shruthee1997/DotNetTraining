using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i , j ;
            i = 11; j = 22;
            double Sum = ShowData(ref i, ref j);
            Console.WriteLine("values of i and j is {0} {1}", i, j);
            Console.WriteLine("Sum =  {0}", Sum);

        }

        public static double ShowData(ref int a, ref int b)
        {
            a +=5;
            b += 5;
           double Sum = a + b;
            Console.WriteLine("Sum = {0}", Sum);
            Console.WriteLine("value of i is {0} and value of j is {1}", a,b);
            return Sum;
        }
    }
}
