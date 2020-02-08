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
        SqlDataReader dr;
        string conString, qryString;

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10125\\SQLEXPRESS2014; initial catalog= Northwind; Integrated Security=True;";
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
            qryString = "select Country from Customers";
            sqlCmd = new SqlCommand(qryString, sqlCon);

            dr = sqlCmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Country"]);
            }
            dr.Close();
            sqlCon.Close();
        }
        private void omboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "Select Unitprice from Products where ProductName='" + listBox1.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlCon);

            sqlCon.Open();
            listBox1.Text = "Unit Price:" + sqlCmd.ExecuteScalar().ToString();
            sqlCon.Close();
        }
    }
}
