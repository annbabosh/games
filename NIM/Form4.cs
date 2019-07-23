using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void таблицаРезультатовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.заставка1;
        }

        private void безПодсказокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.заставка1;
            Form5 f1 = new Form5();
            f1.Hide();
            f1.Show();
            f1.label6.Text = "1";
            f1.Text = "Демонстрационные режимы";
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
        }

        private void сПодсказкамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.заставка1;
            Form5 f1 = new Form5();
            f1.Hide();
            f1.Show();
            f1.label6.Text = "0";
            f1.Text = "Режимы с подсказками";
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Правила_для_24;
            richTextBox2.Visible = true;
            richTextBox1.Visible = false;
            richTextBox3.Visible = false;
          
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void справочныйМатериалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = true;

            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.заставка1;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
