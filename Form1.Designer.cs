namespace Lab_04_OOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textboxname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textboxbirthyear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtotalname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbgrade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbmax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbmin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbavggrade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbnamemax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbnamemin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อ";
            // 
            // textboxname
            // 
            this.textboxname.Location = new System.Drawing.Point(86, 41);
            this.textboxname.Name = "textboxname";
            this.textboxname.Size = new System.Drawing.Size(125, 27);
            this.textboxname.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 76);
            this.button1.TabIndex = 2;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxbirthyear
            // 
            this.textboxbirthyear.Location = new System.Drawing.Point(86, 92);
            this.textboxbirthyear.Name = "textboxbirthyear";
            this.textboxbirthyear.Size = new System.Drawing.Size(125, 27);
            this.textboxbirthyear.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ปีเกิด";
            // 
            // tbtotalname
            // 
            this.tbtotalname.Location = new System.Drawing.Point(362, 259);
            this.tbtotalname.Multiline = true;
            this.tbtotalname.Name = "tbtotalname";
            this.tbtotalname.Size = new System.Drawing.Size(134, 219);
            this.tbtotalname.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "รายชื่อ";
            // 
            // textboxtotal
            // 
            this.textboxtotal.Location = new System.Drawing.Point(371, 208);
            this.textboxtotal.Multiline = true;
            this.textboxtotal.Name = "textboxtotal";
            this.textboxtotal.Size = new System.Drawing.Size(125, 27);
            this.textboxtotal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "อายุรวม";
            // 
            // tbgrade
            // 
            this.tbgrade.Location = new System.Drawing.Point(86, 138);
            this.tbgrade.Name = "tbgrade";
            this.tbgrade.Size = new System.Drawing.Size(125, 27);
            this.tbgrade.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "GPA";
            // 
            // tbmax
            // 
            this.tbmax.Location = new System.Drawing.Point(371, 69);
            this.tbmax.Name = "tbmax";
            this.tbmax.Size = new System.Drawing.Size(125, 27);
            this.tbmax.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "GPA Max";
            // 
            // tbmin
            // 
            this.tbmin.Location = new System.Drawing.Point(371, 122);
            this.tbmin.Name = "tbmin";
            this.tbmin.Size = new System.Drawing.Size(125, 27);
            this.tbmin.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "GPA Min";
            // 
            // tbavggrade
            // 
            this.tbavggrade.Location = new System.Drawing.Point(371, 163);
            this.tbavggrade.Name = "tbavggrade";
            this.tbavggrade.Size = new System.Drawing.Size(125, 27);
            this.tbavggrade.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "GPA Avg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "ข้อมูลรายวิชา";
            // 
            // tbnamemax
            // 
            this.tbnamemax.Location = new System.Drawing.Point(562, 69);
            this.tbnamemax.Name = "tbnamemax";
            this.tbnamemax.Size = new System.Drawing.Size(125, 27);
            this.tbnamemax.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(530, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "ชื่อ";
            // 
            // tbnamemin
            // 
            this.tbnamemin.Location = new System.Drawing.Point(562, 126);
            this.tbnamemin.Name = "tbnamemin";
            this.tbnamemin.Size = new System.Drawing.Size(125, 27);
            this.tbnamemin.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(530, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "ชื่อ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(578, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "GPA สูงสุด";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(578, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "GPA ต่ำสุด";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 490);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbnamemin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbnamemax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbavggrade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbmax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbgrade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textboxtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbtotalname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxbirthyear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textboxname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textboxname;
        private Button button1;
        private TextBox textboxbirthyear;
        private Label label2;
        private TextBox tbtotalname;
        private Label label3;
        private TextBox textboxtotal;
        private Label label4;
        private TextBox tbgrade;
        private Label label5;
        private TextBox tbmax;
        private Label label6;
        private TextBox tbmin;
        private Label label7;
        private TextBox tbavggrade;
        private Label label8;
        private Label label9;
        private TextBox tbnamemax;
        private Label label10;
        private TextBox tbnamemin;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}