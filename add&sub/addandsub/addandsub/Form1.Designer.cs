namespace addandsub
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
            this.btn2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.operaturs = new System.Windows.Forms.ComboBox();
            this.opp = new System.Windows.Forms.Label();
            this.ttb1 = new System.Windows.Forms.TextBox();
            this.ttb2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.ForeColor = System.Drawing.Color.Red;
            this.btn2.Location = new System.Drawing.Point(440, 315);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(85, 38);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "clear";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.ForeColor = System.Drawing.Color.Cyan;
            this.num1.Location = new System.Drawing.Point(123, 68);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(117, 20);
            this.num1.TabIndex = 2;
            this.num1.Text = "enter number 1";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.ForeColor = System.Drawing.Color.Cyan;
            this.num2.Location = new System.Drawing.Point(123, 174);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(117, 20);
            this.num2.TabIndex = 3;
            this.num2.Text = "enter number 2";
            // 
            // operaturs
            // 
            this.operaturs.FormattingEnabled = true;
            this.operaturs.Items.AddRange(new object[] {
            "+",
            "-",
            "/"});
            this.operaturs.Location = new System.Drawing.Point(273, 117);
            this.operaturs.Name = "operaturs";
            this.operaturs.Size = new System.Drawing.Size(175, 28);
            this.operaturs.TabIndex = 4;
            this.operaturs.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // opp
            // 
            this.opp.AutoSize = true;
            this.opp.ForeColor = System.Drawing.Color.Cyan;
            this.opp.Location = new System.Drawing.Point(497, 125);
            this.opp.Name = "opp";
            this.opp.Size = new System.Drawing.Size(77, 20);
            this.opp.TabIndex = 5;
            this.opp.Text = "operators";
            // 
            // ttb1
            // 
            this.ttb1.Location = new System.Drawing.Point(273, 62);
            this.ttb1.Name = "ttb1";
            this.ttb1.Size = new System.Drawing.Size(175, 26);
            this.ttb1.TabIndex = 6;
            // 
            // ttb2
            // 
            this.ttb2.Location = new System.Drawing.Point(273, 174);
            this.ttb2.Name = "ttb2";
            this.ttb2.Size = new System.Drawing.Size(175, 26);
            this.ttb2.TabIndex = 7;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(273, 248);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(175, 26);
            this.result.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(179, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.ttb2);
            this.Controls.Add(this.ttb1);
            this.Controls.Add(this.opp);
            this.Controls.Add(this.operaturs);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.btn2);
            this.Name = "Form1";
            this.Text = "simple calculetion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.ComboBox operaturs;
        private System.Windows.Forms.Label opp;
        private System.Windows.Forms.TextBox ttb1;
        private System.Windows.Forms.TextBox ttb2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
    }
}

