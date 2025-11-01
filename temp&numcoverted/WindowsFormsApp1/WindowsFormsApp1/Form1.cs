using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            int numconverte = int.Parse(numconvert.Text);
            numbinary.Text = Convert.ToString(numconverte, 2);
            numoctal.Text = Convert.ToString(numconverte, 8);
            numhexa.Text = Convert.ToString(numconverte, 16);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            numcel.Text = "";
            numfarha.Text = "";
            numconvert.Text = "";
            numbinary.Text = "";
            numoctal.Text = "";
            numhexa.Text = "";
        }

        private void btnforcel_Click(object sender, EventArgs e)
        {
            double f;
            if (numfarha.Text != "")
            {
                f = Convert.ToDouble(numfarha.Text);
                numcel.Text = (((f - 32) * 5) / 9).ToString();
            }
            else
            {
                MessageBox.Show("enter temperature faranait");
            }
        }

        private void btnforfar_Click(object sender, EventArgs e)
        {
            double c;
            if (numcel.Text != "")
            {
                c = Convert.ToDouble(numcel.Text);
                numfarha.Text = (((c * 32) / 5) + 32).ToString();
            }
            else
            {
                MessageBox.Show("enter temperature celsius");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
