using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myclock
{
    public partial class clock : Form
    {
        public clock()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = DateTime.Now.ToString("hh:mm");
            lblsco.Text = DateTime.Now.ToString("ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
