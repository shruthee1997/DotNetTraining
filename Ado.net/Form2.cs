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

namespace DataAccessAppProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        string conString, qryString;

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10125\\SQLEXPRESS2014; initial catalog= Northwind; Integrated Security=True;";
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
            qryString = "select ProductName from Products";
            sqlCmd = new SqlCommand(qryString, sqlCon);

            dr = sqlCmd.ExecuteReader();

            while (dr.Read())
            {
                cmbproducts.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();

        }

        private void cmbproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "Select Unitprice from Products where ProductName='" + cmbproducts.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlCon);

            sqlCon.Open();
            textBox1.Text = "Unit Price:" + sqlCmd.ExecuteScalar().ToString();
            sqlCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            qryString = "Select ProductName from Products";
            sqlCmd = new SqlCommand(qryString, sqlCon);

            dr = sqlCmd.ExecuteReader();

            while(dr.Read())
            {
                lstproducts.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
        }
    }
}
