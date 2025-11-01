namespace WindowsFormsApp1
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
            this.btnclear = new System.Windows.Forms.Button();
            this.btnconvert = new System.Windows.Forms.Button();
            this.numhexa = new System.Windows.Forms.TextBox();
            this.numoctal = new System.Windows.Forms.TextBox();
            this.numbinary = new System.Windows.Forms.TextBox();
            this.numconvert = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numcel = new System.Windows.Forms.TextBox();
            this.numfarha = new System.Windows.Forms.TextBox();
            this.btnforfar = new System.Windows.Forms.Button();
            this.btnforcel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Tomato;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(768, 322);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(108, 56);
            this.btnclear.TabIndex = 36;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnconvert
            // 
            this.btnconvert.BackColor = System.Drawing.Color.Gold;
            this.btnconvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvert.Location = new System.Drawing.Point(188, 322);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(171, 59);
            this.btnconvert.TabIndex = 35;
            this.btnconvert.Text = "convert";
            this.btnconvert.UseVisualStyleBackColor = false;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // numhexa
            // 
            this.numhexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numhexa.Location = new System.Drawing.Point(747, 228);
            this.numhexa.Name = "numhexa";
            this.numhexa.ReadOnly = true;
            this.numhexa.Size = new System.Drawing.Size(129, 44);
            this.numhexa.TabIndex = 34;
            // 
            // numoctal
            // 
            this.numoctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numoctal.Location = new System.Drawing.Point(453, 228);
            this.numoctal.Name = "numoctal";
            this.numoctal.ReadOnly = true;
            this.numoctal.Size = new System.Drawing.Size(129, 44);
            this.numoctal.TabIndex = 33;
            // 
            // numbinary
            // 
            this.numbinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbinary.Location = new System.Drawing.Point(201, 228);
            this.numbinary.Name = "numbinary";
            this.numbinary.ReadOnly = true;
            this.numbinary.Size = new System.Drawing.Size(129, 44);
            this.numbinary.TabIndex = 32;
            // 
            // numconvert
            // 
            this.numconvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numconvert.Location = new System.Drawing.Point(453, 93);
            this.numconvert.Name = "numconvert";
            this.numconvert.Size = new System.Drawing.Size(260, 44);
            this.numconvert.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(740, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 37);
            this.label7.TabIndex = 30;
            this.label7.Text = "hexadecimal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(446, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 37);
            this.label6.TabIndex = 29;
            this.label6.Text = "octal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(194, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 37);
            this.label5.TabIndex = 28;
            this.label5.Text = "binary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(194, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 37);
            this.label4.TabIndex = 27;
            this.label4.Text = "enter number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 37);
            this.label3.TabIndex = 26;
            this.label3.Text = "number conversion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(672, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "celsiuse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "farhaniet";
            // 
            // numcel
            // 
            this.numcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numcel.Location = new System.Drawing.Point(543, 499);
            this.numcel.Name = "numcel";
            this.numcel.Size = new System.Drawing.Size(100, 44);
            this.numcel.TabIndex = 21;
            // 
            // numfarha
            // 
            this.numfarha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numfarha.Location = new System.Drawing.Point(291, 553);
            this.numfarha.Name = "numfarha";
            this.numfarha.Size = new System.Drawing.Size(100, 44);
            this.numfarha.TabIndex = 22;
            // 
            // btnforfar
            // 
            this.btnforfar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnforfar.Location = new System.Drawing.Point(414, 551);
            this.btnforfar.Name = "btnforfar";
            this.btnforfar.Size = new System.Drawing.Size(100, 46);
            this.btnforfar.TabIndex = 23;
            this.btnforfar.Text = " <---";
            this.btnforfar.UseVisualStyleBackColor = true;
            this.btnforfar.Click += new System.EventHandler(this.btnforfar_Click);
            // 
            // btnforcel
            // 
            this.btnforcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnforcel.Location = new System.Drawing.Point(414, 499);
            this.btnforcel.Name = "btnforcel";
            this.btnforcel.Size = new System.Drawing.Size(100, 46);
            this.btnforcel.TabIndex = 24;
            this.btnforcel.Text = "--->";
            this.btnforcel.UseVisualStyleBackColor = true;
            this.btnforcel.Click += new System.EventHandler(this.btnforcel_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(939, 624);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 59);
            this.button3.TabIndex = 25;
            this.button3.Text = "cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.YellowGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(351, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(384, 37);
            this.label8.TabIndex = 37;
            this.label8.Text = "Tempereture conversion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1117, 695);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnconvert);
            this.Controls.Add(this.numhexa);
            this.Controls.Add(this.numoctal);
            this.Controls.Add(this.numbinary);
            this.Controls.Add(this.numconvert);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnforcel);
            this.Controls.Add(this.btnforfar);
            this.Controls.Add(this.numfarha);
            this.Controls.Add(this.numcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Window conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.TextBox numhexa;
        private System.Windows.Forms.TextBox numoctal;
        private System.Windows.Forms.TextBox numbinary;
        private System.Windows.Forms.TextBox numconvert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numcel;
        private System.Windows.Forms.TextBox numfarha;
        private System.Windows.Forms.Button btnforfar;
        private System.Windows.Forms.Button btnforcel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
    }
}

