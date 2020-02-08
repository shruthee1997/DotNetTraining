using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDBContext context = new ProductDBContext();
            var Product = context.Products;

            var product1 = Product.Add(new Product() { ProductID = 1, Name = "Surendar", Price = 99.99, Quantity = "500ml", CategoryID = 1 });

            var product2 = Product.Add(new Product() { ProductID = 2, Name = "Suray", Price = 999.99, Quantity = "5000ml", CategoryID = 2 });

            var product3 = Product.Add(new Product() { ProductID = 3, Name = "Pughal", Price = 1999.99, Quantity = "50000ml", CategoryID = 3 });

            var Category = context.Categories;

            var Category1 = Category.Add(new category() { CategoryID = 1, Name = "Lemon Juice"});

            var Category2 = Category.Add(new category() { CategoryID = 2, Name = "fruit Juice" });
        }
    }
    public class ProductDBContext : DbContext
    {
        public ProductDBContext() : 
            base("name=ProductDBContext")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<category> Categories { get; set; }
    }
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Quantity { get; set; }
        public  int CategoryID { get; set; }

    }
    public class category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
