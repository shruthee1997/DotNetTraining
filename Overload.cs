using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMarket TotalPrice = new SuperMarket();
            var TP = TotalPrice.GetPrice(500, 15.5);
            Console.WriteLine("Total Price = {0}", TP);
            var TPD = TotalPrice.GetPrice(500, 15.5, 20);
            Console.WriteLine("Total Price after discount = {0}", TPD);
            var TPDC = TotalPrice.GetCashBack(500, 15.5, 20, 10);
            Console.WriteLine("Total Price after discount with CashBack = {0}", TPDC);
        }
        public class SuperMarket
        {
            public double GetPrice(double price, double Tax)
            {
                double TP = (price + (price * (Tax / 100)));
                return TP;
            }
            public double GetPrice(double price, double Tax, double Discount)
            {
                double TPD = ((price + (price * (Tax / 100)) - (price * (Discount / 100))));
                return TPD;
            }
            public virtual double GetCashBack(double price, double Tax, double Discount, double Cashback)
            {
                double TPDC = ((price + (price * (Tax / 100)) - ((price * (Discount / 100)) + (Cashback))));
                return TPDC;
            }
        }
        public class CashBack : SuperMarket
        {
            public override double GetCashBack(double price, double Tax, double Discount, double Cashback)

            {
                return base.GetCashBack(price, Tax, Discount, Cashback);
            }       
        }
    }
}
