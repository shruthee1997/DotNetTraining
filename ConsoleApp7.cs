using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        int empid;
        string empname;
        int salary;
        static string company = "cts";

        public Program(int id, string name, int sa)
        {
            empid = id;
            empname = name;
            salary = sa;
        }
        public void datashow()
        {
            Console.WriteLine("empid = {0} ", empid);
            Console.WriteLine("empname = {0} ", empname);
            Console.WriteLine("empsalary = {0} ", salary);
            Console.WriteLine("company = {0}", company);


        }
        public static void Main(String[] args)
        {
            Program emp1 = new Program(1, "ram", 90000);
            Program emp2 = new Program(1, "lekha", 90000);
            emp1.datashow();
            emp2.datashow();

            badam bd = new badam()
            { Productid = 1, ProductName = "ram", Price = 85 };
            bd.showdata1();

            Cuostmer c1 = new Cuostmer()
            {
                cusID = 1,
                CusName = "sairam",
                Country = "India"
            };
            c1.showdata2();
        }
        public class badam
        {


            public int Productid
            {
                get;
                set;
            }

            public string ProductName
            {
                get;
                set;
            }
            public int Price
            {
                get;
                set;
            }
            public void showdata1()
            {
                Console.WriteLine("ProID {0}", Productid);
                Console.WriteLine("ProName {0}", ProductName);
                Console.WriteLine("ProPrice{0}", Price);

            }



        }

        public class Cuostmer
        {
            public int CusID;
            public int cusID
            {
                get { return CusID; }
                set { CusID = value; }
            }

            public string CusName
            {
                get;
                set;
            }

            public string Country
            {
                get;
                set;
            }

            public void showdata2()
            {
                Console.WriteLine("Cuostmer ID = {0}", CusID);
                Console.WriteLine("Cuostmer Name = {0}", CusName);
                Console.WriteLine("Cuostmer Country = {0}", Country);
            }





        }


    }
}
