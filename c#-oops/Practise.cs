using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your content");
            String Input = Console.ReadLine();

            Char[] arr = Input.ToCharArray();
            int x = arr.Length;
            string rev = null;
            for(int i = x-1;i >= 0;i--)
            {
                rev = rev + arr[i];
            }
            Console.WriteLine(rev);
        }
    }
}
