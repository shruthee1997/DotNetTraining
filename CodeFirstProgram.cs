using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;


namespace CodeFirstProgramDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDBContext context = new CustomerDBContext();

            var orders1 = orders.Add(new Order() { OrderID = 1, OrderDate = '01/01/2020',
                CustomerID = 1, ShippedDate = ' 01-15-2020' });

        }
    }
}
