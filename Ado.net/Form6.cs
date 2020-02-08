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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;
        string conString, qryString;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "select Country from Customers where ContactName = '" + comboBox2.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            label2.Text = " Country : " + sqlCmd.ExecuteScalar().ToString();
            sqlCon.Close();
        }

        private void NewName_TextChanged(object sender, EventArgs e)
        {
            qryString = "Update Customers Set Country = " + " Where ContactName ='" + comboBox2.Text + "'";
            sqlCmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            MessageBox.Show("Country Update", "New Product Price:");
            sqlCon.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10125\\SQLEXPRESS2014; initial catalog= Northwind; Integrated Security=True;";
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
            qryString = "select ContactName from Customers";
            sqlCmd = new SqlCommand(qryString, sqlCon);

            dr = sqlCmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox2.Items.Add(dr["ContactName"]);
            }
            dr.Close();
            sqlCon.Close();
        }
    }
}
