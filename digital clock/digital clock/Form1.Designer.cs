namespace digital_clock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.btnsetTime = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnclear = new System.Windows.Forms.Button();
            this.lblcalander = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Digital Dismay", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Cyan;
            this.lblTime.Location = new System.Drawing.Point(-1, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(567, 150);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "00:00:00\r\n";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Digital Dismay", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Cyan;
            this.textBox1.Location = new System.Drawing.Point(96, 209);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 111);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = ":";
            // 
            // txtSecond
            // 
            this.txtSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtSecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecond.Font = new System.Drawing.Font("Digital Dismay", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecond.ForeColor = System.Drawing.Color.Cyan;
            this.txtSecond.Location = new System.Drawing.Point(229, 264);
            this.txtSecond.Margin = new System.Windows.Forms.Padding(0);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(54, 56);
            this.txtSecond.TabIndex = 10;
            this.txtSecond.Text = "00";
            // 
            // txtMinute
            // 
            this.txtMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinute.Font = new System.Drawing.Font("Digital Dismay", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute.ForeColor = System.Drawing.Color.Cyan;
            this.txtMinute.Location = new System.Drawing.Point(136, 209);
            this.txtMinute.Margin = new System.Windows.Forms.Padding(0);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(88, 111);
            this.txtMinute.TabIndex = 9;
            this.txtMinute.Text = "00";
            // 
            // txtHour
            // 
            this.txtHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHour.Font = new System.Drawing.Font("Digital Dismay", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.ForeColor = System.Drawing.Color.Cyan;
            this.txtHour.Location = new System.Drawing.Point(8, 209);
            this.txtHour.Margin = new System.Windows.Forms.Padding(0);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(88, 111);
            this.txtHour.TabIndex = 8;
            this.txtHour.Text = "00";
            // 
            // btnsetTime
            // 
            this.btnsetTime.BackColor = System.Drawing.Color.Cyan;
            this.btnsetTime.Location = new System.Drawing.Point(286, 266);
            this.btnsetTime.Name = "btnsetTime";
            this.btnsetTime.Size = new System.Drawing.Size(87, 54);
            this.btnsetTime.TabIndex = 7;
            this.btnsetTime.Text = "set Time";
            this.btnsetTime.UseVisualStyleBackColor = false;
            this.btnsetTime.Click += new System.EventHandler(this.btnsetTime_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Location = new System.Drawing.Point(8, 335);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(87, 54);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblcalander
            // 
            this.lblcalander.AutoSize = true;
            this.lblcalander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblcalander.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalander.ForeColor = System.Drawing.Color.Cyan;
            this.lblcalander.Location = new System.Drawing.Point(15, 150);
            this.lblcalander.Name = "lblcalander";
            this.lblcalander.Size = new System.Drawing.Size(264, 55);
            this.lblcalander.TabIndex = 14;
            this.lblcalander.Text = "dd/MM/YY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(575, 427);
            this.Controls.Add(this.lblcalander);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.btnsetTime);
            this.Name = "Form1";
            this.Text = "digital clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Button btnsetTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblcalander;
    }
}

