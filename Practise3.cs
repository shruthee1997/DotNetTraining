using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket1
{
    
        public class Customer
        {
            public int CustomerID { get; set; }
            public string CustomerName { get; set; }
            public string CustomerLocation { get; set; }
            public double GetOffers(int cashback, double balance)
            {
                double Offerdetails = (cashback + balance);
                return Offerdetails;
            }
            
            public string ShowData()
            {
                return string.Format("CustomerID : {0}, CustomerName : {1}, CustomerLocation : {2}", CustomerID, CustomerName, CustomerLocation);
            }
        }
    }


