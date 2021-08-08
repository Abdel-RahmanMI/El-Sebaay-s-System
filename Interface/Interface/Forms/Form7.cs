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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 s = new Form4();
            s.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 s = new Form5();
            s.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 s = new Form3();
            s.Show();
            this.Close();
        }
        

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
