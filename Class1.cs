using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponent
{
    public class Employee
    {
        public int EmployeID { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public double GetSalary(int nds, double spd)
        {
        var salary = nds * spd;
        return salary;
        }
        public double GetIncentives(double salary)
        {
            var incent = 0.05 * salary;
            return incent;
        }
        public string ShowData()
        {
            return string.Format("EmpID : {0}, Name: {1}, Department: {2}", EmployeID, EmpName, Department);
        }
    }
}
