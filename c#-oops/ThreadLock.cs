using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadlockingApp
{
    class Threadlock
    {
        static void Main(string[] args)
        {
            Threadlock objTL = new Threadlock();

            Thread T1 = new Thread(objTL.Display);
            Thread T2 = new Thread(objTL.Display);
            Thread T3 = new Thread(objTL.Display);

            T1.Start();
            T2.Start();
            T3.Start();

            Console.ReadLine();
        }
        public void Display()
        {
            lock(this)
            {
                Console.Write("[csharp is an");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented Language]");
            }
        }
    }
}
