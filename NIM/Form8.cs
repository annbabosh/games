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
    public partial class Form8 : Form
    {
        List<Button> number1 = new List<Button>();
        List<Button> number2 = new List<Button>();
        List<Button> result = new List<Button>();
        List<Button> massivsg = new List<Button>();
        List<Label> numbers = new List<Label>();
        List<PictureBox> arrows = new List<PictureBox>();

        bool V = false, VV = false;
        int globcount = 0;

        public Form8()
        {
            InitializeComponent();
        }


        public static int NimSum(int[] mass)
        {
            int sum = mass[0];
            for (int i = 1; i < mass.Length; i++)
            {
                sum = sum ^ mass[i];
            }

            return sum;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void деманстрационныеРежимыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (V == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    number1[i].Visible = false;
                    number2[i].Visible = false;
                    result[i].Visible = false;
                }
                button2.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_заставка;
            }

            if (VV == true)
            {
                button21.Visible = false;
                label4.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                listBox1.Visible = false;

                for (int i = 0; i < 8; i++)
                {
                    arrows[i].Visible = false;
                }

                for (int i = 0; i < 9; i++)
                {
                    numbers[i].Visible = false;
                    massivsg[i].Visible = false;
                }

                listBox1.Items.Clear();
                listBox1.Visible = false;

                globcount = 0;

                pictureBox2.Visible = false;
                button21.Text = "Начать!";
            }

            richTextBox1.Visible = false;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_заставка;
            Form9 f1 = new Form9();
            f1.Hide();
            f1.Show();
            f1.label1.Text = "1";
            f1.Text = "Демонстрационные режимы";
            f1.pictureBox1.Size = new System.Drawing.Size(560, 440);
            //richTextBox1.Visible = false;
            //richTextBox2.Visible = false;
            //richTextBox3.Visible = false;
        }

        private void режимыСПодсказкамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (V == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    number1[i].Visible = false;
                    number2[i].Visible = false;
                    result[i].Visible = false;
                }
                button2.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_заставка;
            }

            if (VV == true)
            {
                button21.Visible = false;
                label4.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                listBox1.Visible = false;

                for (int i = 0; i < 8; i++)
                {
                    arrows[i].Visible = false;
                }

                for (int i = 0; i < 9; i++)
                {
                    numbers[i].Visible = false;
                    massivsg[i].Visible = false;
                }

                listBox1.Items.Clear();
                listBox1.Visible = false;

                globcount = 0;

                pictureBox2.Visible = false;
                button21.Text = "Начать!";
            }

            richTextBox1.Visible = false;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_заставка;
            Form9 f1 = new Form9();
            f1.Hide();
            f1.Show();
            f1.label1.Text = "2";
            f1.Text = "Режимы с подсказкой";
            f1.pictureBox1.Size = new System.Drawing.Size(560, 440);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void подсчетНимсуммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;

            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_главный_фон;
            label1.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            button2.Visible = true;

            comboBox1.Text = "";
            comboBox2.Text = "";

            number1.Add(button1);
            number1.Add(button3);
            number1.Add(button4);
            number1.Add(button5);
            number1.Add(button6);

            number2.Add(button7);
            number2.Add(button8);
            number2.Add(button9);
            number2.Add(button10);
            number2.Add(button11);

            result.Add(button12);
            result.Add(button13);
            result.Add(button14);
            result.Add(button15);
            result.Add(button16);

            V = true;

            if (VV == true)
            {
                button21.Visible = false;
                label4.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                listBox1.Visible = false;

                for (int i = 0; i < 8; i++)
                {
                    arrows[i].Visible = false;
                }

                for (int i = 0; i < 9; i++)
                {
                    numbers[i].Visible = false;
                    massivsg[i].Visible = false;
                }

                listBox1.Items.Clear();
                listBox1.Visible = false;

                globcount = 0;

                pictureBox2.Visible = false;
                button21.Text = "Начать!";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text != "") && (comboBox2.Text != ""))
            {
                #region

                for (int i = 0; i < 5; i++)
                {
                    number1[i].Text = "0";
                    number2[i].Text = "0";
                    result[i].Text = "0";
                    number1[i].Visible = true;
                    number2[i].Visible = true;
                    result[i].Visible = true;
                }
                label2.Visible = true;
                label3.Visible = true;
                button17.Visible = true;
                button18.Visible = true;
                button19.Visible = true;
                button20.Visible = true;

                int n1 = Convert.ToInt32(comboBox1.Text);
                int n2 = Convert.ToInt32(comboBox2.Text);

                button17.Text = "(результат сложения чисел " + Convert.ToString(n1) + " и " + Convert.ToString(n2) + " в двоичной системе счисления без учета переноса разрядов)";
                button18.Text = Convert.ToString(n1);
                button19.Text = Convert.ToString(n2);

                int h1 = n1, h2 = n2;
                string[] ch1 = new string[5] { "0", "0", "0", "0", "0" };
                string[] ch2 = new string[5] { "0", "0", "0", "0", "0" };

                int j1 = 0;
                bool flag1 = false;
                while ((h1 >= 1) && (flag1 == false))
                {
                    if (h1 == 1)
                    {
                        flag1 = true;
                    }
                    if (h1 % 2 == 1)
                    {
                        ch1[j1] = Convert.ToString(1);
                        h1 = h1 / 2;
                        j1++;
                    }
                    else
                    {
                        ch1[j1] = Convert.ToString(0);
                        h1 = h1 / 2;
                        j1++;
                    }
                    
                }

                int l1 = 4;
                for (int i = 0; i < j1; i++)
                {
                    number1[l1].Text = Convert.ToString(ch1[i]);
                    l1--;
                }

                int j2 = 0;
                bool flag2 = false;
                while ((h2 >= 1) && (flag2 == false))
                {
                    if (h2 == 1)
                    {
                        flag2 = true;
                    }
                    if (h2 % 2 == 1)
                    {
                        ch2[j2] = Convert.ToString(1);
                        h2 = h2 / 2;
                        j2++;
                    }
                    else
                    {
                        ch2[j2] = Convert.ToString(0);
                        h2 = h2 / 2;
                        j2++;
                    }

                }

                int l2 = 4;
                for (int i = 0; i < j2; i++)
                {
                    number2[l2].Text = Convert.ToString(ch2[i]);
                    l2--;
                }

                int[] mass = new int[2] {n1,n2};
                int res = NimSum(mass);

                button20.Text = Convert.ToString(res);

                string[] r = new string[5] { "0", "0", "0", "0", "0" };

                int j3 = 0;
                bool flag3 = false;
                while ((res >= 1) && (flag3 == false))
                {
                    if (res == 1)
                    {
                        flag3 = true;
                    }
                    if (res % 2 == 1)
                    {
                        r[j3] = Convert.ToString(1);
                        res = res / 2;
                        j3++;
                    }
                    else
                    {
                        r[j3] = Convert.ToString(0);
                        res = res / 2;
                        j3++;
                    }

                }

                int l3 = 4;
                for (int i = 0; i < j3; i++)
                {
                    result[l3].Text = Convert.ToString(r[i]);
                    l3--;
                }


                ////////////////////////////
                Bitmap bmp = new Bitmap(global::WindowsFormsApplication1.Properties.Resources.ИК_главный_фон);
                Graphics g = Graphics.FromImage(bmp);
                Pen p = new Pen(Color.Black);
                pictureBox1.Image = bmp;
                p.Width = 4;

                g.DrawLine(p, 220, 200, 268, 200);
                g.DrawLine(p, 311, 200, 542, 200);
                                    

                #endregion
            }
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (V == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    number1[i].Visible = false;
                    number2[i].Visible = false;
                    result[i].Visible = false;
                }
                button2.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_заставка;
            }

            if (VV == true)
            {
                button21.Visible = false;
                label4.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                listBox1.Visible = false;

                for (int i = 0; i < 8; i++)
                {
                    arrows[i].Visible = false;
                }

                for (int i = 0; i < 9; i++)
                {
                    numbers[i].Visible = false;
                    massivsg[i].Visible = false;
                }
                
                listBox1.Items.Clear();
                listBox1.Visible = false;

                globcount = 0;

                pictureBox2.Visible = false;
                button21.Text = "Начать!";
            }

            richTextBox1.Visible = false;

        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (V == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    number1[i].Visible = false;
                    number2[i].Visible = false;
                    result[i].Visible = false;
                }
                button2.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_заставка;
            }
            if (VV == true)
            {
                button21.Visible = false;
                label4.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                listBox1.Visible = false;

                for (int i = 0; i < 8; i++)
                {
                    arrows[i].Visible = false;
                }

                for (int i = 0; i < 9; i++)
                {
                    numbers[i].Visible = false;
                    massivsg[i].Visible = false;
                }

                listBox1.Items.Clear();
                listBox1.Visible = false;

                globcount = 0;

                pictureBox2.Visible = false;
                button21.Text = "Начать!";
            }

            richTextBox1.Visible = true;
        }

        private void справочныйМатериалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (V == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    number1[i].Visible = false;
                    number2[i].Visible = false;
                    result[i].Visible = false;
                }
                button2.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_заставка;
            }

            if (VV == true)
            {
                button21.Visible = false;
                label4.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                listBox1.Visible = false;

                for (int i = 0; i < 8; i++)
                {
                    arrows[i].Visible = false;
                }

                for (int i = 0; i < 9; i++)
                {
                    numbers[i].Visible = false;
                    massivsg[i].Visible = false;
                }

                listBox1.Items.Clear();
                listBox1.Visible = false;

                globcount = 0;

                pictureBox2.Visible = false;
                button21.Text = "Начать!";
            }
            richTextBox1.Visible = false;
        }

        private void теорияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (V == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    number1[i].Visible = false;
                    number2[i].Visible = false;
                    result[i].Visible = false;
                }
                button2.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_заставка;
            }

            if (VV == true)
            {
                button21.Visible = false;
                label4.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                listBox1.Visible = false;

                for (int i = 0; i < 8; i++)
                {
                    arrows[i].Visible = false;
                }

                for (int i = 0; i < 9; i++)
                {
                    numbers[i].Visible = false;
                    massivsg[i].Visible = false;
                }

                listBox1.Items.Clear();
                listBox1.Visible = false;

                globcount = 0;

                pictureBox2.Visible = false;
                button21.Text = "Начать!";
            }

            richTextBox1.Visible = false;
        }

        private void заполненияМассиваSGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (V == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    number1[i].Visible = false;
                    number2[i].Visible = false;
                    result[i].Visible = false;
                }
                button2.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_заставка;
            }
            richTextBox1.Visible = false;
            
            #region

            numbers.Add(label5);
            numbers.Add(label6);
            numbers.Add(label7);
            numbers.Add(label8);
            numbers.Add(label9);
            numbers.Add(label10);
            numbers.Add(label11);
            numbers.Add(label12);
            numbers.Add(label13);

            massivsg.Add(button22);
            massivsg.Add(button23);
            massivsg.Add(button24);
            massivsg.Add(button25);
            massivsg.Add(button26);
            massivsg.Add(button27);
            massivsg.Add(button28);
            massivsg.Add(button29);
            massivsg.Add(button30);

            arrows.Add(pictureBox3);
            arrows.Add(pictureBox4);
            arrows.Add(pictureBox5);
            arrows.Add(pictureBox6);
            arrows.Add(pictureBox7);
            arrows.Add(pictureBox8);
            arrows.Add(pictureBox9);
            arrows.Add(pictureBox10);

            button21.Visible = true;
            label4.Visible = true;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            listBox1.Visible = true;

            for (int i = 0; i < 8; i++)
            {
                arrows[i].Visible = true;
            }

            for (int i = 0; i < 9; i++)
            {
                numbers[i].Visible = true;
                numbers[i].Text = Convert.ToString(i);
                massivsg[i].Visible = true;
                massivsg[i].Text = "";
                if (i < 8)
                {
                    arrows[i].Visible = false;
                }
                
                massivsg[i].BackColor = Color.Azure;
               

            }
            VV = true;
            listBox1.Items.Clear();

            globcount = 0;

            pictureBox2.Visible = true;

            #endregion
        }

        private void руководствоПользователюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (V == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    number1[i].Visible = false;
                    number2[i].Visible = false;
                    result[i].Visible = false;
                }
                button2.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_заставка;
            }

            if (VV == true)
            {
                button21.Visible = false;
                label4.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                listBox1.Visible = false;

                for (int i = 0; i < 8; i++)
                {
                    arrows[i].Visible = false;
                }

                for (int i = 0; i < 9; i++)
                {
                    numbers[i].Visible = false;
                    massivsg[i].Visible = false;
                }

                listBox1.Items.Clear();
                listBox1.Visible = false;

                globcount = 0;

                pictureBox2.Visible = false;
                button21.Text = "Начать!";
            }

            richTextBox1.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.Text == "Начать!")
            {
                button21.Text = "Далее";
                massivsg[globcount].Text = "0";
                massivsg[globcount].BackColor = Color.MediumAquamarine;
                label14.Visible = true;
                label15.Visible = true;

                globcount++;
            }
            else if (button21.Text == "Далее")
            {
                if (globcount < 9)
                {
                    if (globcount == 1)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            massivsg[i].BackColor = Color.Azure;
                        }
                        massivsg[globcount].Text = "1";
                        massivsg[globcount].BackColor = Color.MediumAquamarine;
                        arrows[globcount - 1].Visible = true;
                        globcount++;
                    }
                    else
                    if (globcount == 2)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            massivsg[i].BackColor = Color.Azure;
                            if (i < 8)
                            {
                                arrows[i].Visible = false;
                            }
                        }
                        massivsg[globcount].Text = "2";
                        massivsg[globcount].BackColor = Color.MediumAquamarine;
                        arrows[globcount - 1].Visible = true;
                        globcount++;
                    }
                    else if (globcount == 3)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            massivsg[i].BackColor = Color.Azure;
                            if (i < 8)
                            {
                                arrows[i].Visible = false;
                            }
                        }
                        massivsg[globcount].Text = "3";
                        massivsg[globcount].BackColor = Color.MediumAquamarine;
                        arrows[globcount - 1].Visible = true;
                        listBox1.Items.Add("SG(1,1) = НИМ-СУММE SG[1] и SG[1] = 0");
                        globcount++;
                    }
                    else if (globcount == 4)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            massivsg[i].BackColor = Color.Azure;
                            if (i < 8)
                            {
                                arrows[i].Visible = false;
                            }
                        }
                        listBox1.Items.Clear();
                        massivsg[globcount].Text = "1";
                        massivsg[globcount].BackColor = Color.MediumAquamarine;
                        arrows[globcount - 1].Visible = true;
                        listBox1.Items.Add("SG(2,1) = НИМ-СУММE SG[2] и SG[1] = 3");
                        listBox1.Items.Add("SG(1,1) = НИМ-СУММE SG[1] и SG[1] = 0");
                        globcount++;
                    }
                    else if (globcount == 5)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            massivsg[i].BackColor = Color.Azure;
                            if (i < 8)
                            {
                                arrows[i].Visible = false;
                            }
                        }
                        listBox1.Items.Clear();
                        massivsg[globcount].Text = "4";
                        massivsg[globcount].BackColor = Color.MediumAquamarine;
                        arrows[globcount - 1].Visible = true;
                        listBox1.Items.Add("SG(3,1) = НИМ-СУММE SG[3] и SG[1] = 2");
                        listBox1.Items.Add("SG(2,2) = НИМ-СУММE SG[2] и SG[2] = 0");
                        listBox1.Items.Add("SG(2,1) = НИМ-СУММE SG[2] и SG[1] = 3");
                        globcount++;
                    }
                    else if (globcount == 6)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            massivsg[i].BackColor = Color.Azure;
                            if (i < 8)
                            {
                                arrows[i].Visible = false;
                            }
                        }
                        listBox1.Items.Clear();
                        massivsg[globcount].Text = "3";
                        massivsg[globcount].BackColor = Color.MediumAquamarine;
                        arrows[globcount - 1].Visible = true;
                        listBox1.Items.Add("SG(4,1) = НИМ-СУММE SG[4] и SG[1] = 0");
                        listBox1.Items.Add("SG(3,1) = НИМ-СУММE SG[3] и SG[1] = 2");
                        listBox1.Items.Add("SG(3,2) = НИМ-СУММE SG[3] и SG[2] = 1");
                        listBox1.Items.Add("SG(2,2) = НИМ-СУММE SG[2] и SG[2] = 0");
                        globcount++;
                    }
                    else if (globcount == 7)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            massivsg[i].BackColor = Color.Azure;
                            if (i < 8)
                            {
                                arrows[i].Visible = false;
                            }
                        }
                        listBox1.Items.Clear();
                        massivsg[globcount].Text = "2";
                        massivsg[globcount].BackColor = Color.MediumAquamarine;
                        arrows[globcount - 1].Visible = true;
                        listBox1.Items.Add("SG(5,1) = НИМ-СУММE SG[5] и SG[1] = 5");
                        listBox1.Items.Add("SG(4,1) = НИМ-СУММE SG[4] и SG[1] = 0");
                        listBox1.Items.Add("SG(4,2) = НИМ-СУММE SG[4] и SG[2] = 3");
                        listBox1.Items.Add("SG(3,3) = НИМ-СУММE SG[3] и SG[3] = 0");
                        listBox1.Items.Add("SG(3,2) = НИМ-СУММE SG[3] и SG[2] = 1");
                        globcount++;
                    }
                    else if (globcount == 8)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            massivsg[i].BackColor = Color.Azure;
                            if (i < 8)
                            {
                                arrows[i].Visible = false;
                            }
                        }
                        listBox1.Items.Clear();
                        massivsg[globcount].Text = "1";
                        massivsg[globcount].BackColor = Color.MediumAquamarine;
                        arrows[globcount - 1].Visible = true;
                        listBox1.Items.Add("SG(6,1) = НИМ-СУММE SG[6] и SG[1] = 2");
                        listBox1.Items.Add("SG(5,1) = НИМ-СУММE SG[5] и SG[1] = 5");
                        listBox1.Items.Add("SG(5,2) = НИМ-СУММE SG[5] и SG[2] = 6");
                        listBox1.Items.Add("SG(4,2) = НИМ-СУММE SG[4] и SG[2] = 0");
                        listBox1.Items.Add("SG(4,3) = НИМ-СУММE SG[4] и SG[3] = 2");
                        listBox1.Items.Add("SG(3,3) = НИМ-СУММE SG[3] и SG[3] = 0");
                        globcount++;
                    }
                }
                else
                {
                    button21.Text = "И ТАК ДАЛЕЕ";
                    for (int i = 0; i < 9; i++)
                    {
                        massivsg[i].BackColor = Color.Azure;
                        if (i < 8)
                        {
                            arrows[i].Visible = false;
                        }
                    }
                    listBox1.Items.Clear();
                    listBox1.Visible = false;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
