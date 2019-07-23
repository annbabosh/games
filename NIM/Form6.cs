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
    public partial class Form6 : Form
    {
        List<Button> buttons = new List<Button>();
        List<Image> images1 = new List<Image>();
        List<Image> images2 = new List<Image>();
        List<PictureBox> p1 = new List<PictureBox>();
        List<PictureBox> p2 = new List<PictureBox>();

        int mcount, hcount = 0;

        public Form6()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void демонстрационныеРежимыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБзаставка1;
            Form7 f1 = new Form7();
            f1.Hide();
            f1.Show();
            f1.label2.Text = "1";
            f1.Text = "Демонстрационные режимы";
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            //richTextBox3.Visible = false;
            
        }

        private void режимыСПодсказкамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБзаставка1;
            Form7 f1 = new Form7();
            f1.Hide();
            f1.Show();
            f1.label2.Text = "2";
            f1.Text = "Режимы с подсказками";
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
        }

        private void обучающийРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБзаставка1;
            Form7 f1 = new Form7();

            f1.Hide();
            f1.Show();
            f1.label2.Text = "3";
            f1.button4.Visible = true;
            f1.textBox2.Visible = true;
            f1.button1.Visible = false;
            f1.button2.Visible = false;
            f1.button3.Visible = false;
            f1.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБ_имя_ч_л_к_ч;
            f1.textBox2.Text = "";
            f1.Text = "Обучающий режим";
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            richTextBox2.Visible = false;

            button1.Visible = false;
            button2.Visible = false;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБзаставка1;

            label2.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            for (int i = 0; i < 15; i++)
            {
                buttons[i].Visible = false;
                p2[i].Visible = false;
            }

            for (int i = 0; i < 14; i++)
            {
                p1[i].Visible = false;
            }
            mcount = 0;
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;

            button1.Visible = false;
            button2.Visible = false;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБзаставка1;

            label2.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            for (int i = 0; i < 15; i++)
            {
                buttons[i].Visible = false;
                p2[i].Visible = false;
            }

            for (int i = 0; i < 14; i++)
            {
                p1[i].Visible = false;
            }


            for (int i = 0; i < 15; i++)
            {
                buttons[i].BackColor = Color.Gainsboro;
            }

            for (int i = 0; i < 14; i++)
            {
                p1[i].Visible = false;
            }
            mcount = 0;

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void теорияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            richTextBox1.Visible = false;

            button1.Visible = false;
            button2.Visible = false;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБзаставка1;

            label2.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            for (int i = 0; i < 15; i++)
            {
                buttons[i].Visible = false;
                p2[i].Visible = false;
            }

            for (int i = 0; i < 14; i++)
            {
                p1[i].Visible = false;
            }

            for (int i = 0; i < 14; i++)
            {
                p1[i].Visible = false;
            }
            mcount = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Начать!")
            {
                button2.Text = "Далее";
                buttons[0].Text = "4";
                buttons[1].Text = "0";
                buttons[1].BackColor = Color.Salmon;
                label2.Visible = true;
                label3.Visible = true;
                hcount = 0;
                mcount = 1;
            }
            else
            if (button2.Text == "Далее")
            {
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;

                mcount++;
                if (mcount == 14)
                {                    
                    button2.Text = "Готово!";
                }

                if (hcount == 3)
                    hcount = 0;
                else hcount++;

                for (int i = 0; i < 14; i++)
                {
                    p1[i].Visible = false;
                }
                for (int i = 0; i < 15; i++)
                {
                    buttons[i].BackColor = Color.Gainsboro;
                }

                buttons[mcount].BackColor = Color.Salmon;
                buttons[mcount].Text = Convert.ToString(hcount);
                p1[mcount - 1].Visible = true;
            }
            else
                if (button2.Text == "Готово!")
                {
                    for (int i = 0; i < 14; i++)
                    {
                        p1[i].Visible = false;
                    }
                    for (int i = 0; i < 15; i++)
                    {
                        buttons[i].BackColor = Color.Gainsboro;
                    }
                }
               
                    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void примерЗаполненияМассиваSGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБББ;

            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button2.Text = "Начать!";
            //pictureBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            for (int i = 0; i < 15; i++)
            {
                buttons[i].Visible = false;
                p2[i].Visible = false;
            }

            for (int i = 0; i < 14; i++)
            {
                p1[i].Visible = false;
            }


            #region

            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttons.Add(button10);
            buttons.Add(button11);
            buttons.Add(button12);
            buttons.Add(button13); 
            buttons.Add(button14);
            buttons.Add(button15);
            buttons.Add(button16);
            buttons.Add(button17);

            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_1);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_2);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);

            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_0_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_1_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_2_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_3_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_4_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_5_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_6_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_7_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_8_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_9_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_10_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_11_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_12_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_13_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_14_вид2);

            p1.Add(pictureBox18);
            p1.Add(pictureBox19);
            p1.Add(pictureBox20);
            p1.Add(pictureBox21);
            p1.Add(pictureBox22);
            p1.Add(pictureBox23);
            p1.Add(pictureBox24);
            p1.Add(pictureBox25);
            p1.Add(pictureBox26);
            p1.Add(pictureBox27);
            p1.Add(pictureBox28);
            p1.Add(pictureBox29);
            p1.Add(pictureBox30);
            p1.Add(pictureBox31);

            p2.Add(pictureBox3);
            p2.Add(pictureBox4);
            p2.Add(pictureBox5);
            p2.Add(pictureBox6);
            p2.Add(pictureBox7);
            p2.Add(pictureBox8);
            p2.Add(pictureBox9);
            p2.Add(pictureBox10);
            p2.Add(pictureBox11);
            p2.Add(pictureBox12);
            p2.Add(pictureBox13);
            p2.Add(pictureBox14);
            p2.Add(pictureBox15);
            p2.Add(pictureBox16);
            p2.Add(pictureBox17);

            #endregion

            for (int i = 0; i < 15; i++)
            {
                buttons[i].Visible = true;
                buttons[i].Text = "";
                p2[i].Visible = true;
                p2[i].Image = images2[i];
                mcount = 0;
                buttons[i].BackColor = Color.Gainsboro;
            }

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            #region

            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttons.Add(button10);
            buttons.Add(button11);
            buttons.Add(button12);
            buttons.Add(button13);
            buttons.Add(button14);
            buttons.Add(button15);
            buttons.Add(button16);
            buttons.Add(button17);

            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_1);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_2);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_Визуал_3);

            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_0_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_1_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_2_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_3_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_4_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_5_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_6_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_7_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_8_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_9_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_10_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_11_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_12_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_13_вид2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_14_вид2);

            p1.Add(pictureBox18);
            p1.Add(pictureBox19);
            p1.Add(pictureBox20);
            p1.Add(pictureBox21);
            p1.Add(pictureBox22);
            p1.Add(pictureBox23);
            p1.Add(pictureBox24);
            p1.Add(pictureBox25);
            p1.Add(pictureBox26);
            p1.Add(pictureBox27);
            p1.Add(pictureBox28);
            p1.Add(pictureBox29);
            p1.Add(pictureBox30);
            p1.Add(pictureBox31);

            p2.Add(pictureBox3);
            p2.Add(pictureBox4);
            p2.Add(pictureBox5);
            p2.Add(pictureBox6);
            p2.Add(pictureBox7);
            p2.Add(pictureBox8);
            p2.Add(pictureBox9);
            p2.Add(pictureBox10);
            p2.Add(pictureBox11);
            p2.Add(pictureBox12);
            p2.Add(pictureBox13);
            p2.Add(pictureBox14);
            p2.Add(pictureBox15);
            p2.Add(pictureBox16);
            p2.Add(pictureBox17);

            #endregion
        }

        private void справочныйМатериалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 14; i++)
            //{
            //    p1[i].Visible = false;
            //}
            //mcount = 0;
        }

        private void руководствоПользователюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 14; i++)
            //{
            //    p1[i].Visible = false;
            //}
            //mcount = 0;
        }

    }
}
