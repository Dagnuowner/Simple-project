using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm");
            label2.Text = DateTime.Now.ToString("ss");
            label3.Text = DateTime.Now.ToString("MM/dd/yy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnred_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            
        }

        private void btngreen_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
            label2.ForeColor = Color.Green;
            label3.ForeColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Cyan;
            label2.ForeColor = Color.Cyan;
            label3.ForeColor = Color.Cyan;
        }
    }
}
