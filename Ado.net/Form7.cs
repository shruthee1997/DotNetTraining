using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataAdapter da;
        DataSet ds;
        String qrystring, constring;

        private void btnProducts_Click(object sender, EventArgs e)
        {
            qrystring = "select ProductID,ProductName, UnitPrice, Quantityperunit, categoryID from Products";
            sqlCmd = new SqlCommand(qrystring, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            ds = new DataSet();
            da.Fill(ds, "ProductsInfo");
            gvProducts.DataSource = ds;
            gvProducts.DataMember = "ProductsInfo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qrystring = "Select * from Categories";
            sqlCmd = new SqlCommand(qrystring, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            da.Fill(ds, "CategoriesInfo");
            gvProducts.DataSource = ds;
            gvProducts.DataMember = "CategoriesInfo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            constring = "data source = BLT10125\\SQLEXPRESS2014; Initial Catalog = Northwind; Integrated Security=True;";
            sqlCon = new SqlConnection(constring);
        }
    }
}
