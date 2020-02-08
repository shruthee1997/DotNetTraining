using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employees = new string[6] { "fgsgh", "dfgsg", "dfgsfg", "fgfdsg", "dfsdf", "dfgsfg" };

            var knownEmpls = from emp in employees
                             where emp.StartsWith("f")
                             select emp;

            foreach(string emp in knownEmpls)
            {
                Console.WriteLine("Name starts with f : {0}", emp);
            }
            Console.WriteLine("**********************************************************************");

            List <string> fruits = new List<string>()
            { "gsfdgfdg","ggfdgfdg","trytryy"};

            var fruitswitht = from fruit in fruits
                             where fruit.Contains("t")
                             select fruit;

            foreach(string fruit in fruitswitht)
            {
                Console.WriteLine("Fruits starts with t:{0}", fruit);
            }

            var fruitsorder = from fruit in fruits
                              orderby fruit
                              select fruit;

            foreach (string fruit in fruitsorder)
            {
                Console.WriteLine("Fruits Order by:{0}", fruit);
            }

            Console.WriteLine("**********************************************************************");

            var largefruitname = from fruit in fruits
                             where fruit.Length > 6
                             select fruit;

            foreach (string fruit in largefruitname)
            {
                Console.WriteLine("Fruits starts with length more than 6:{0}", fruit);
            }

            int[] marks = new int[] { 95, 25, 65, 54, 87, 74, 85, 21, 54 };

            var highmarks = from m in marks
                            where m > 90
                            select m;

            foreach(var m in highmarks)
            {
                Console.WriteLine("Mark greater than 90 : {0}", m);
            }

            var marksinorder = from m in marks
                            orderby m descending
                            select m;

            foreach (var m in marksinorder)
            {
                Console.WriteLine("Mark in order : {0}", m);
            }

            Console.ReadLine();
        }
    }
}
