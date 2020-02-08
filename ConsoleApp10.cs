using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Empoylee e1 = new Empoylee();
            Console.WriteLine("Add with two int parameter :" + e1.Add(3, 2));
            Console.WriteLine("Add with three int parameter :" + e1.Add(3, 2, 8));
            
        }
    }
    public class Empoylee
    {
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }
        public int Add(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3);
        }
       
    }
}
