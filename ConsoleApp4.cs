using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {

        public int age;
        public string name;
        public float salarly;

        public Program( int a, string n, float s)
        {
            age = a;
            name = n;
            salarly = s;
        }

        public void display()
        {
            Console.WriteLine("happy birthday at the of" +age +" " + name+ " " + salarly);
        }
        static void Main(string[] args)
        {
            Program n1 = new Program(22, "ram", 25000);
            n1.display();
        }
    }
}
