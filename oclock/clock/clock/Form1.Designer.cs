namespace clock
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cancel = new System.Windows.Forms.Button();
            this.btnred = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btngreen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Digital Dismay", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 209);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Digital Dismay", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(503, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(165, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(570, 114);
            this.label3.TabIndex = 2;
            this.label3.Text = "MM/DD/YY";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cancel
            // 
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.Red;
            this.cancel.Location = new System.Drawing.Point(672, 9);
            this.cancel.Margin = new System.Windows.Forms.Padding(0);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(73, 53);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "x";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // btnred
            // 
            this.btnred.BackColor = System.Drawing.Color.Red;
            this.btnred.ForeColor = System.Drawing.Color.Red;
            this.btnred.Location = new System.Drawing.Point(36, 511);
            this.btnred.Name = "btnred";
            this.btnred.Size = new System.Drawing.Size(75, 41);
            this.btnred.TabIndex = 4;
            this.btnred.UseVisualStyleBackColor = false;
            this.btnred.Click += new System.EventHandler(this.btnred_Click);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.White;
            this.btn10.ForeColor = System.Drawing.Color.Red;
            this.btn10.Location = new System.Drawing.Point(161, 511);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(75, 41);
            this.btn10.TabIndex = 5;
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btngreen
            // 
            this.btngreen.BackColor = System.Drawing.Color.Green;
            this.btngreen.ForeColor = System.Drawing.Color.Red;
            this.btngreen.Location = new System.Drawing.Point(293, 511);
            this.btngreen.Name = "btngreen";
            this.btngreen.Size = new System.Drawing.Size(75, 41);
            this.btngreen.TabIndex = 6;
            this.btngreen.UseVisualStyleBackColor = false;
            this.btngreen.Click += new System.EventHandler(this.btngreen_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(426, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(758, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngreen);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btnred);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button btnred;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btngreen;
        private System.Windows.Forms.Button button1;
    }
}

