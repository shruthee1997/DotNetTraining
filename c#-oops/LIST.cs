using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the Array Index");
            a = int.Parse(Console.ReadLine());
            int[] Numbers = new int[a];
            for(int i = 0; i < a; i++)
            {
                Numbers[i] = int.Parse(Console.ReadLine());
            }
            var Even = from h in Numbers
                       where h % 2 == 0
                       select h;
            foreach(var h in Even)
            {
                Console.WriteLine("Even Number = {0}", h);
            }
        }
    }
}
