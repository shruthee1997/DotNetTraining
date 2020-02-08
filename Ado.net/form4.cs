using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    class Program
    {

        static void Main(string[] args)
        {
            SqlConnection sqlCon;
            SqlCommand sqlCmd;
            SqlDataReader dr;
            String qrystring, constring;

            constring = "data source = BLT10125\\SQLEXPRESS2014; Initial Catalog = Northwind; Integrated Security=True;";
            sqlCon = new SqlConnection(constring);
            qrystring = "Select ProductName from Products";
            sqlCon.Open();
            sqlCmd = new SqlCommand(qrystring, sqlCon);
            dr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                Console.WriteLine("Product Name = {0}", dr);
            }
            dr.Close();
            sqlCon.Close();

        }
    }
}
