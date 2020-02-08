using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Firstno.Text == "") || (Secondno.Text == ""))
            {
                MessageBox.Show("Give number");
            }
            else 
            {
                double n1, n2;
                n1 = double.Parse(Firstno.Text);
                n2 = double.Parse(Secondno.Text);
                double result = 0;

                if (RB1Add.Checked)
                {
                    result = (n1 + n2);
                    showresult.Text = "Addition" +  result;
                }
                else if (RB2Sub.Checked)
                {
                    result = (n1 - n2);
                    showresult.Text = "Subraction" + result;
                }
                else if (RB3Multi.Checked)
                {
                    result = (n1 * n2);
                    showresult.Text = "Multiplication" + result;
                }
                else if (RB4Divide.Checked)
                {
                    result = (n1 / n2);
                    showresult.Text = "Divition" + result;
                }
                else
                {
                    showresult.Text = "Select the choice";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
