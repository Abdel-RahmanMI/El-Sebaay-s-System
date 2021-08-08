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

    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            Text = "EL-Sebaee's Company";
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form2());

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 s = new Form7();
            s.Show();
            this.Close();

        }
    }
}
