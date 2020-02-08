using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexercise
{
    public class Customer
    {
        string CustomerName;
        string CustomerCountry;
        int CustomerID;

        public Customer(String Cname, string ccountry, int CCId)
        {
            CustomerName = Cname;
            CustomerCountry = ccountry;
            CustomerID = CCId;
        }

        public void ShowData()
        {
            Console.WriteLine("Customername = {0}", CustomerName);
            Console.WriteLine("CustomerCountry = {0}", CustomerCountry);
            Console.WriteLine("CustomerID = {0}", CustomerID);

        } 
            public static void Main(string[] args)
            {
                Customer Cus = new Customer(  "Surendar",  "India", 844527);
                Cus.ShowData();
            }

        }

    } 
