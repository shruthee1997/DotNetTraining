using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlCon;
            SqlCommand sqlCmd;
            SqlDataReader dr;
            String conString, qryString;

            conString = "data Source = BLT10125\\SQLEXPRESS2014; Initial Catalog =Northwind; Integrated Security = True;";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            Console.WriteLine("Enter the Country Name Germany,Mexico,UK,Sweden,France,Spain");
            var Country = Console.ReadLine();
            qryString = "Select CompanyName from Customers where Country = '" + Country + "'";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            dr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read()) 
            {
                Console.WriteLine("CompanyName = {0}",dr["CompanyName"]);
            }
            dr.Close();
            sqlCon.Close();
        }
    }
}
