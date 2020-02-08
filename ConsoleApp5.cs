using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {

        public int age;
        public string name;
        public float salarly;

        public Program(int a, string n, float s)
        {
            age = 50;
            name = "sairam";
            salarly = s;
        }

        
        static void Main(string[] args)
        {
            string Program = string.Format( " {0}  {1}");
            Console.WriteLine(Program);
        }
    }
}
