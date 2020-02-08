using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Suplier
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Department { get; set; }
        public double GetBenefits(int Cashback, double Balance)
        {
            var Benefits = Cashback + Balance;
            return Benefits;
        }               
        public string ShowData()
        {
            return string.Format("CustomerID : {0}, CustomerName : {1}, Department: {2}", CustomerID, CustomerName, Department);
        }
    }
}
