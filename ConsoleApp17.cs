using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Codefirstprogramdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDBContext context = new CustomerDBContext();

            var orders = context.Orders;

            var order1 = orders.Add(new Order()
            {
                OrderID = 1,
                OrderDate = new DateTime(2020, 01, 01),
                CustomerID = 1,
                ShippedDate = new DateTime(2020, 01, 15)
            });

            var order2 = orders.Add(new Order()
            {
                OrderID = 2,
                OrderDate = new DateTime(2020, 01, 01),
                CustomerID = 2,
                ShippedDate = new DateTime(2020, 01, 15)
            });

            var order3 = orders.Add(new Order()
            {
                OrderID = 3,
                OrderDate = new DateTime(2020, 01, 01),
                CustomerID = 3,
                ShippedDate = new DateTime(2020, 01, 15)
            });
            context.SaveChanges();
        }
        public class CustomerDBContext : DbContext
        {
            public CustomerDBContext() : base("Name = CustomerDBContext")
            {

            }
            public DbSet<Order> Orders { get; set; }

        }

        public class Order
        {
            public int OrderID { get; set; }
            public DateTime OrderDate { get; set; }
            public int CustomerID { get; set; }
            public DateTime ShippedDate { get; set; }
        }
    }
}