using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce;
namespace CustomerPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Suplier sup = new Suplier() { CustomerID = 10, CustomerName = " Surendar", Department = "Technical" };

            var supdata = sup.ShowData();
            Console.WriteLine(supdata);

            var Benefits = sup.GetBenefits(30, 10000);
 
            Console.WriteLine("Benefits : {0}", Benefits);

            Console.ReadKey();
        }
    }
}
