using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prd = new Product() { Productid = 1, Productname = "Gulfie", Price = 35.00, Quantity = "20grams" };
            prd.ShowData();
        }
        public class Product
        {
            public int Productid
            { get;
                set;
            }
            public string Productname
            {
                get;
                set;
            }
            public double Price
            {
                get;
                set;
            }
            public string Quantity
            {
                get;
                set;
            }


            public void ShowData()
            {
                Console.WriteLine("Productid = {0}", Productid);
                Console.WriteLine("Productname = {0}", Productname);
                Console.WriteLine("Price = {0}", Price);
                Console.WriteLine("Quantity = {0}", Quantity);
            }
        }
    }
}
