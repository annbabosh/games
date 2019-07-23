using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("Project1.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.Hide();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form12 f = new Form12();
            f.Hide();
            f.Show();
        }

        
    }
}
