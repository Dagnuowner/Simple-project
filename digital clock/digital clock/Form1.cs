using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digital_clock
{
    public partial class Form1 : Form
    {
        bool manualMode = false;
        DateTime manualTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
   
            if (manualMode)
            {
  
                manualTime = manualTime.AddSeconds(1);
                lblTime.Text = manualTime.ToString("HH:mm:ss");
            }
            else
            {
            
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
                lblcalander.Text = DateTime.Now.ToString("dd/MM/yy");
            }
        }

        private void btnsetTime_Click(object sender, EventArgs e)
        {
            try
            {
                int h = int.Parse(txtHour.Text);
                int m = int.Parse(txtMinute.Text);
                int s = int.Parse(txtSecond.Text);
                if (txtHour.Text == "" || txtMinute.Text == "" || txtSecond.Text == "")
                {
                    MessageBox.Show("Please enter time values before setting the time.");
                }

                if (h < 0 || h > 23|| m < 0 || m > 59 || s < 0 || s > 59)
                {
                    MessageBox.Show("Invalid time! Please enter hour (0–23), minute (0–59), and second (0–59).");
                    return;
                }

                manualTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, h, m, s);
                manualMode = true;

                MessageBox.Show("Manual time set successfully!");
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers for hour, minute, and second.");
            }
         
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtHour.Text= "00";
            txtMinute.Text = "00";
            txtSecond.Text = "00";
            
        }
    }
}
