using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SimpleMath
    {
        static void Main(string[] args)
        {
        float a, b, c;
        Console.WriteLine("Enter the a\n");
        a = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter the b\n");
        b = float.Parse(Console.ReadLine());
        c = a * b;
        Console.WriteLine("The product of {0} and {1} = {2}", a ,b , c);

         Console.ReadKey();
    }
    }
}
