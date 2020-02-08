using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymerpism
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Employee emp = new Employee();

                var salary = emp.GetSalary(30, 800);
                Console.WriteLine("salary without incentives :Rs {0}", salary);

                var incent = emp.GetSalary(30, 800, 5000);
                Console.WriteLine("salary with incebtives:{0}", incent);

                Manager Mng = new Manager();
                var ts = Mng.GetPerks(30000, 5000);
                Console.WriteLine("salary of the Manager:{0}", ts);

            }
        }
            
        
        public class Employee
        {
            public double GetSalary(int nds, float spd)
            {
                double salary = nds * spd;
                return salary;
            }

            public double GetSalary(int nds, float spd, float incent)
            {
                double salary = (nds * spd) + incent;
                return salary;
            }

            public virtual double GetPerks(float salary, float perks)
            {
                double ts = (salary + perks);
                return ts;
            }
        }
        public class Manager : Employee
        {
            public override double GetPerks(float salary, float perks)
            {
                return base.GetPerks(salary, perks) * 1.10;
            }
        }
    }
}
