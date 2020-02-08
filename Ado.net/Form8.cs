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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        String qrystring, constring;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qrystring = "select * from Customers where Country = '" + comboBox1.Text + "'";
            sqlCmd = new SqlCommand(qrystring, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            ds = new DataSet();
            da.Fill(ds, "CustomerDetails");
            gvCustomer.DataSource = ds;
            gvCustomer.DataMember = "CustomerDetails";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qrystring = "Select C.CustomerID, C.CompanyName, C.Address, C.Country, O.OrderID, O.OrderDate, O.ShippedDate From Customers C JOIN Orders O ON O.CustomerID = C.CustomerID";
            sqlCmd = new SqlCommand(qrystring, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            ds = new DataSet();
            da.Fill(ds, "CustomerDetails");
            gvCustomer.DataSource = ds;
            gvCustomer.DataMember = "CustomerDetails";
        }

        private void ButJOIN_Click(object sender, EventArgs e)
        {
            qrystring = "Select * From Categories C JOIN Products P ON P.CategoryID = C.CategoryID";
            sqlCmd = new SqlCommand(qrystring, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            ds = new DataSet();
            da.Fill(ds, "CustomerDetails");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CustomerDetails";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            qrystring = "Select * from Products where CategoryID = '" + comboBox2.Text + "'";
            sqlCmd = new SqlCommand(qrystring, sqlCon);
            da = new SqlDataAdapter(sqlCmd);
            ds = new DataSet();
            da.Fill(ds, "CustomerDetails");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CustomerDetails";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qrystring = "Select count(OrderID) From Orders";
            sqlCon.Open();
            sqlCmd = new SqlCommand(qrystring, sqlCon);
            //MessageBox.Show(sqlCmd.ExecuteScalar().ToString());
            textBox1.Text = sqlCmd.ExecuteScalar().ToString();
            sqlCon.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            constring = "data source = BLT10125\\SQLEXPRESS2014; Initial Catalog = Northwind; Integrated Security=True;";
            sqlCon = new SqlConnection(constring);
            qrystring = "Select distinct Country from Customers";
            sqlCon.Open();
            sqlCmd = new SqlCommand(qrystring, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while (dr.Read()) 
            {
                comboBox1.Items.Add(dr["Country"]);
            }
            dr.Close();
            sqlCon.Close();
            ds = new DataSet();

            constring = "data source = BLT10125\\SQLEXPRESS2014; Initial Catalog = Northwind; Integrated Security=True;";
            sqlCon = new SqlConnection(constring);
            qrystring = "Select CategoryID from Categories";
            sqlCon.Open();
            sqlCmd = new SqlCommand(qrystring, sqlCon);
            dr = sqlCmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["CategoryID"]);
            }
            dr.Close();
            sqlCon.Close();
            ds = new DataSet();
        }
    }
}
