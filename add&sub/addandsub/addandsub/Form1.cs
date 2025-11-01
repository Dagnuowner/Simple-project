using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace addandsub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double txt1;
            double txt2 ;
            double sum2, sub2, multi2;
            string result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
            double txt1 = Convert.ToDouble(ttb1.Text);
           
            double txt2 = Convert.ToDouble(ttb2.Text);

            double sum2 = txt1 + txt2;
            double sub2 = txt1 - txt2;
            double div = txt1 / txt2;

            //result.Text = sum2.ToString();
            //result.Text = sub2.ToString();
            result.Text = div.ToString();
            result.Text = sub2.ToString();
            result.Text = sum2.ToString();  
        }

        private void btn1_Click(object sender, EventArgs e)
        {
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ttb1.Text = "";
            ttb2.Text = "";
            result.Text = "";
            operaturs.Text = "";
        }
    }
}
