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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Close();
        }
    }
}
