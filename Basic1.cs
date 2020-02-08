using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeComponent;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { EmployeID = 10, EmpName = " Surendar", Department = "Technical" };

            var empdata = emp.ShowData();
            Console.WriteLine(empdata);

            var salary = emp.GetSalary(30, 10000);
            var incent = emp.GetIncentives(salary);

            var tsalary = salary + incent;
            Console.WriteLine("Salary: {0}, Incentives: {1}, Total Salary: {2}", salary, incent, tsalary);

            Console.ReadKey();
        }
    }
}
