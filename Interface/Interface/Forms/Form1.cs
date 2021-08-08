using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Interface
{
    
    public partial class Form1 : Form
    {
        public int a , b;
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a==1&&b==1)
            {
                Form6 ss = new Form6();
                ss.Show();
                this.Hide();
                
            }
            if (a == 2 && b== 2)
            {

                Form8 s = new Form8();
                s.Show();
                this.Hide();
            }
            if (a == 3 && b==3)
            {

                Form9 s = new Form9();
                s.Show();
                this.Hide();
            }
            if (a == 4 && b==4)
            {

                Form2 s = new Form2();
                s.Show();
                this.Hide();
            }
            if (a == 5 && b == 5)
            {
                Form7 s = new Form7();
                s.Show();
                this.Hide();
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
          // pictureBox1.Image
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "EL-Sebaee's Company";
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text == "Admin" || textBox2.Text == "1")
                a = 1;
            if (textBox2.Text == "CEO" || textBox2.Text == "2")
                a = 2;
            if (textBox2.Text == "Sales"||textBox2.Text =="3")
                a = 3;
            if (textBox2.Text == "Accountant"||textBox2.Text =="4")
                a = 4;
            if (textBox2.Text == "Inventory"||textBox2.Text =="5")
                a = 5;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "hr123" || textBox1.Text == "1")
                b = 1;
            if (textBox1.Text == "ceo123" || textBox1.Text == "2")
                b = 2;
            if (textBox1.Text == "sales123"||textBox1.Text == "3")
                b = 3;
            if (textBox1.Text == "acc123" || textBox1.Text == "4")
                b = 4;
            if (textBox1.Text == "inv123" || textBox1.Text == "5")
                b = 5;
        }
    }
}
