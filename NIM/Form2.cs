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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = true;
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Правила_для_ним;
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
        }

        private void режимыСОбъяснениемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.нью2;
            Form3 f1 = new Form3();
            f1.Hide();
            f1.Show();
            f1.label9.Text = "1";
            f1.Text = "Демонстрационные режимы";
            //f1.button2.Enabled = false;
            //f1.button2.Image = null;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
        }

        private void режимыСПодсказкойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.нью2;
            Form3 f1 = new Form3();
            f1.Hide();
            f1.Show();
            f1.label9.Text = "2";
            f1.Text = "Режимы с подсказками";
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
        }

        private void обучающийРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.нью2;
            Form3 f1 = new Form3();
            f1.Hide();
            f1.Show();
            f1.label9.Text = "3";
            f1.Text = "Обучающий режим";

            richTextBox1.Visible = false;
            richTextBox2.Visible = false;

            f1.textBox3.Visible = true;
            f1.textBox3.Text = "";
            f1.button1.Visible = false;
            f1.button2.Visible = false;
            f1.button3.Visible = false;
            richTextBox3.Visible = false;
            f1.button4.Visible = true;
            f1.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.для_ч_к_к_ч;
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void справочныйМаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            richTextBox2.Visible = true;
            richTextBox3.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        


       
    }
}
