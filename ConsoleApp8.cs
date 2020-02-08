using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{

    public abstract class banking
    {
        public abstract double GetSimpleInterest(double pr, int td, short rt);
        public abstract double GetTotalAmount(double bal, double si);
        //public void show()
        //{
        //    Console.WriteLine("This is a concrete method defined with in a abstract class");
        //}
    }
    public class SBAccount : banking
    {
        public override double GetSimpleInterest(double pr, int td, short rt)
        {
            double si = (pr * td * rt) / 100;
            return si;
        }
        public override double GetTotalAmount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }
    }
    public class CCAccount : banking
    {
        public override double GetSimpleInterest(double pr, int td, short rt)
        {
            double si = 0.25 * (pr * td * rt) / 100;
            return si;
        }
        public override double GetTotalAmount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }
    }
    class demo
    {
        static void Main(string[] args)
        {
            SBAccount obj1 = new SBAccount();
            CCAccount obj2 = new CCAccount();

            double SA = obj1.GetSimpleInterest(10000, 5, 2);
            double totalamountSA = obj1.GetTotalAmount(10000, SA);
            Console.WriteLine(SA);
            Console.WriteLine(totalamountSA);

            double simpleinterestCA = obj2.GetSimpleInterest(10000, 5, 2);
            double totalamountCA = obj2.GetTotalAmount(10000, simpleinterestCA);
            Console.WriteLine(simpleinterestCA);
            Console.WriteLine(totalamountCA);

            //obj1.show();


        }
    }


}
