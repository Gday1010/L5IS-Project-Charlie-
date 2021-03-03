using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3rd_week_progect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (fname.Text == "")
            {
                MessageBox.Show("First name can not be left empty");
                fname.BackColor = Color.Red;
                fname.Focus();
            }
            else if (lname.Text == "")
            {
                fname.BackColor = Color.White;
                MessageBox.Show("last name can not be left empty");
                lname.BackColor = Color.Red;
                lname.Focus();
            }
            else if (Phone.Text == "")
            {
                lname.BackColor = Color.White;
                MessageBox.Show("mobile number can not be left empty");
                Phone.BackColor = Color.Red;
                Phone.Focus();
            }
            else if (int.TryParse(Phone.Text, out num) == false)
            {
                MessageBox.Show("Enter digits only");
                Phone.BackColor = Color.Red;
            }
            else if (Email.Text == "")
            {
                Phone.BackColor = Color.White;
                MessageBox.Show("email can not be left empty");
                Email.BackColor = Color.Red;
                Email.Focus();
            }
            else if (meetwith.Text == "")
            {
                Email.BackColor = Color.White;
                MessageBox.Show("you must select someone to meet with");
                meetwith.BackColor = Color.Red;
                meetwith.Focus();
            }
            else if (button2.Text == "meeting aim")
            {
                MessageBox.Show("you must select a meeting aim");

            }
            else
            {
                listBox1.Items.Add("[" + button2.Text + "] " + fname.Text + " " + lname.Text + " - " + meetwith.Text + " at " + hour.Text + ":" + min.Text);
                fname.BackColor = Color.White;
                lname.BackColor = Color.White;
                Phone.BackColor = Color.White;
                Email.BackColor = Color.White;
                clearall();
            }
        }
        private void clearall()
        {
            fname.Clear();
            lname.Clear();
            Phone.Clear();
            Email.Clear();
            meetwith.ResetText();
            hour.Text = "00";
            min.Text = "00";
            ampm.Text = "AM/PM";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newform = new Form2();            
            if (newform.ShowDialog() == DialogResult.OK)
            {
                if(newform.radioButton1.Checked == true)
                button2.Text = newform.radioButton1.Text;
                else if (newform.radioButton2.Checked == true)
                    button2.Text = newform.radioButton2.Text;
                else if (newform.radioButton3.Checked == true)
                    button2.Text = newform.radioButton3.Text;
                else if (newform.radioButton4.Checked == true)
                    button2.Text = newform.radioButton4.Text;
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void meetwith_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}
