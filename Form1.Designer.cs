
namespace _3rd_week_progect
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ampm = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.DomainUpDown();
            this.hour = new System.Windows.Forms.DomainUpDown();
            this.meetwith = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(473, 66);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.Phone);
            this.groupBox1.Controls.Add(this.lname);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Location = new System.Drawing.Point(43, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 405);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vistor Detials ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(31, 306);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(173, 20);
            this.Email.TabIndex = 3;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(34, 215);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(172, 20);
            this.Phone.TabIndex = 2;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(34, 140);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(172, 20);
            this.lname.TabIndex = 1;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(34, 54);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(175, 20);
            this.fname.TabIndex = 0;
            this.fname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ampm);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.min);
            this.groupBox2.Controls.Add(this.hour);
            this.groupBox2.Controls.Add(this.meetwith);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Location = new System.Drawing.Point(328, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 404);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meeting details";
            // 
            // ampm
            // 
            this.ampm.FormattingEnabled = true;
            this.ampm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.ampm.Location = new System.Drawing.Point(179, 117);
            this.ampm.Name = "ampm";
            this.ampm.Size = new System.Drawing.Size(53, 21);
            this.ampm.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = ":";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // min
            // 
            this.min.Items.Add("00");
            this.min.Items.Add("01");
            this.min.Items.Add("02");
            this.min.Items.Add("03");
            this.min.Items.Add("04");
            this.min.Items.Add("05");
            this.min.Items.Add("06");
            this.min.Items.Add("07");
            this.min.Items.Add("08");
            this.min.Items.Add("09");
            this.min.Items.Add("10");
            this.min.Items.Add("11");
            this.min.Items.Add("12");
            this.min.Items.Add("13");
            this.min.Items.Add("14");
            this.min.Items.Add("15");
            this.min.Items.Add("16");
            this.min.Items.Add("17");
            this.min.Items.Add("18");
            this.min.Items.Add("19");
            this.min.Items.Add("20");
            this.min.Items.Add("21");
            this.min.Items.Add("22");
            this.min.Items.Add("23");
            this.min.Items.Add("24");
            this.min.Items.Add("25");
            this.min.Items.Add("26");
            this.min.Items.Add("27");
            this.min.Items.Add("28");
            this.min.Items.Add("29");
            this.min.Items.Add("30");
            this.min.Items.Add("31");
            this.min.Items.Add("32");
            this.min.Items.Add("33");
            this.min.Items.Add("34");
            this.min.Items.Add("35");
            this.min.Items.Add("36");
            this.min.Items.Add("37");
            this.min.Items.Add("38");
            this.min.Items.Add("39");
            this.min.Items.Add("40");
            this.min.Items.Add("41");
            this.min.Items.Add("42");
            this.min.Items.Add("43");
            this.min.Items.Add("44");
            this.min.Items.Add("45");
            this.min.Items.Add("46");
            this.min.Items.Add("47");
            this.min.Items.Add("48");
            this.min.Items.Add("49");
            this.min.Items.Add("50");
            this.min.Items.Add("51");
            this.min.Items.Add("52");
            this.min.Items.Add("53");
            this.min.Items.Add("54");
            this.min.Items.Add("55");
            this.min.Items.Add("56");
            this.min.Items.Add("57");
            this.min.Items.Add("58");
            this.min.Items.Add("59");
            this.min.Items.Add("60");
            this.min.Location = new System.Drawing.Point(101, 118);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(62, 20);
            this.min.TabIndex = 10;
            this.min.SelectedItemChanged += new System.EventHandler(this.domainUpDown2_SelectedItemChanged);
            // 
            // hour
            // 
            this.hour.Items.Add("0");
            this.hour.Items.Add("1");
            this.hour.Items.Add("2");
            this.hour.Items.Add("3");
            this.hour.Items.Add("4");
            this.hour.Items.Add("5");
            this.hour.Items.Add("6");
            this.hour.Items.Add("7");
            this.hour.Items.Add("8");
            this.hour.Items.Add("9");
            this.hour.Items.Add("10");
            this.hour.Items.Add("11");
            this.hour.Items.Add("12");
            this.hour.Location = new System.Drawing.Point(9, 118);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(62, 20);
            this.hour.TabIndex = 9;
            this.hour.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // meetwith
            // 
            this.meetwith.FormattingEnabled = true;
            this.meetwith.Items.AddRange(new object[] {
            "David Romez",
            "Bill Door",
            "Albert Sky",
            "Bartholomeu Wynstringham"});
            this.meetwith.Location = new System.Drawing.Point(6, 194);
            this.meetwith.Name = "meetwith";
            this.meetwith.Size = new System.Drawing.Size(223, 21);
            this.meetwith.TabIndex = 8;
            this.meetwith.SelectedIndexChanged += new System.EventHandler(this.meetwith_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "Meeting aim";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Meeting Aim";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Meeting With";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(9, 54);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(223, 20);
            this.date.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(599, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 405);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vistors On Site";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(399, 355);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 563);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox meetwith;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DomainUpDown min;
        private System.Windows.Forms.DomainUpDown hour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ampm;
        private System.Windows.Forms.ListBox listBox1;
    }
}

