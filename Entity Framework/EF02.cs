using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstDemoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDBContext context = new ProductDBContext();
            var product = context.Products;
            var product1 = product.Add(new Product()
            {
                ProductID = 1,
                Name = "Badam",
                Price = 99.90,
                Quantity = "250ml",
                CategoryID = 1
            });
            var product2 = product.Add(new Product()
            {
                ProductID = 2,
                Name = "Coffee",
                Price = 89.90,
                Quantity = "250ml",
                CategoryID = 2
            });
            var product3 = product.Add(new Product()
            {
                ProductID = 3,
                Name = "Cold Coffee",
                Price = 79.90,
                Quantity = "550ml",
                CategoryID = 3
            });

            var Category = context.Categories;

            var Category1 = Category.Add(new category() { CategoryID = 3, Name = "Orange mint" });
            var Category2 = Category.Add(new category() { CategoryID = 3, Name = "Lemon mint" });
            context.SaveChanges();

        }
    }

    public class ProductDBContext : DbContext
    {
        public ProductDBContext() :
            base("name=ProductDBContext")
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<category> Categories { get; set; }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Quantity { get; set; }
        public int CategoryID { get; set; }

    }
    public class category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
