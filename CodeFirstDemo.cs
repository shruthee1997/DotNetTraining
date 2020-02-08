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

            var orders = context.Orders;


            var orders1 = orders.Add(new Order()
            {
                OrderID = 1,
                OrderDate = new DateTime(01 / 01 / 2020),
                CustomerID = 1,
                ShippedDate = new DateTime(01 - 15 - 2020)
            });

        }

        public class CustomerDBContext : DbContext

        {
            public CustomerDBContext() : base(" Name = CustomerDBContext")

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


     
