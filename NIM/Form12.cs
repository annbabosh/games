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
    public partial class Form12 : Form
    {
        List<Button> buttons = new List<Button>();
        List<Label> labels = new List<Label>();

        public Form12()
        {
            InitializeComponent();
        }

        int count = 0, count2 = 0;
        bool FlagForS1 = false, rezim = false;


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void деманстрационныеРежимыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СП_главная;
            Form13 f1 = new Form13();
            f1.Hide();
            f1.Show();
            f1.label1.Text = "1";
            f1.Text = "Демонстрационные режимы";

            if (FlagForS1 == true)
            {
                for (int i = 0; i < 35; i++)
                {
                    buttons[i].Visible = false;
                    labels[i].Visible = false;
                }
                button1.Visible = false;
                richTextBox1.Visible = false;
            }
            richTextBox2.Visible = false;
        }

        private void режимыСПодсказкамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СП_главная;
            Form13 f1 = new Form13();
            f1.Hide();
            f1.Show();
            f1.label1.Text = "2";
            f1.Text = "Режимы с подсказками";

            if (FlagForS1 == true)
            {
                for (int i = 0; i < 35; i++)
                {
                    buttons[i].Visible = false;
                    labels[i].Visible = false;
                }
                button1.Visible = false;
                richTextBox1.Visible = false;
            }
            richTextBox2.Visible = false;
        }

        private void определениеВыигрышныхПозицийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region

            buttons.Add(button2);
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
            buttons.Add(button18);
            buttons.Add(button19);
            buttons.Add(button20);
            buttons.Add(button21);
            buttons.Add(button22);
            buttons.Add(button23);
            buttons.Add(button24);
            buttons.Add(button25);
            buttons.Add(button26);
            buttons.Add(button27);
            buttons.Add(button28);
            buttons.Add(button29);
            buttons.Add(button30);
            buttons.Add(button31);
            buttons.Add(button32);
            buttons.Add(button33);
            buttons.Add(button34);
            buttons.Add(button35);
            buttons.Add(button36);

            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);
            labels.Add(label8);
            labels.Add(label9);
            labels.Add(label10);
            labels.Add(label11);
            labels.Add(label12);
            labels.Add(label13);
            labels.Add(label14);
            labels.Add(label15);
            labels.Add(label16);
            labels.Add(label17);
            labels.Add(label18);
            labels.Add(label19);
            labels.Add(label20);
            labels.Add(label21);
            labels.Add(label22);
            labels.Add(label23);
            labels.Add(label24);
            labels.Add(label25);
            labels.Add(label26);
            labels.Add(label27);
            labels.Add(label28);
            labels.Add(label29);
            labels.Add(label30);
            labels.Add(label31);
            labels.Add(label32);
            labels.Add(label33);
            labels.Add(label34);
            labels.Add(label35);

            for (int i = 0; i < 35; i++)
            {
                buttons[i].Image = null;
                buttons[i].Visible = true;
                labels[i].Visible = true;
            }

            FlagForS1 = true;
            #endregion

            button1.Visible = true;
            button1.Text = "Начать";
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СП_фон_для_игры;
            richTextBox1.Visible = false;
            richTextBox1.Text = "";
            rezim = false;
            richTextBox2.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rezim == false)
            {
                #region

                if (button1.Text == "Начать")
                {
                    button1.Text = "Далее";
                    count = 0;
                    richTextBox1.Visible = true;

                    buttons[0].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
                    richTextBox1.Text = "Положение 0 является выигрывающим, каково бы ни было число спичек, только что взятых, чтобы достичь этого состояния.";
                }
                else if (count == 0)
                {
                    count++;

                    buttons[1].Image = global::WindowsFormsApplication1.Properties.Resources.крест_1;
                    buttons[2].Image = global::WindowsFormsApplication1.Properties.Resources.крест_1;

                    richTextBox1.Text = "Число 1 для игрока является проигрышным, так как на предыдущем ходе сделан ход, отличный от нуля. То же самое можно сказать и о числе 2. ";

                }
                else if (count == 1)
                {
                    count++;

                    buttons[3].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;

                    richTextBox1.Text = "Рассмотрим теперь число 3. Ваш соперник должен сделать ход и взять 1 или 2 (см. правила игры). Вы можете на своем ходе взять оставшееся число. Значит, число 3 для вас является выигрышным.";
                }
                else if (count == 2)
                {
                    count++;

                    buttons[4].Image = global::WindowsFormsApplication1.Properties.Resources.крест_1;

                    richTextBox1.Text = "По тем же самым причинам число 4 является для вас проигрышным, так как ваш соперник может встать на число 3, а эту задачу мы уже рассмотрели.";
                }
                else if (count == 3)
                {
                    count++;

                    buttons[5].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;

                    richTextBox1.Text = "Число 5 для нас выигрышное, так как если ваш соперник берет 1, то вы тоже берете 1, и встаете на выигрышное число 3, а если 2, то вы достигаете победы, удвоив взятое противником число.";
                }
                else if (count == 4)
                {
                    count++;

                    buttons[6].Image = global::WindowsFormsApplication1.Properties.Resources.крест_1;
                    buttons[7].Image = global::WindowsFormsApplication1.Properties.Resources.крест_1;
                    buttons[8].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;

                    richTextBox1.Text = "По тем же самым причинам числа 6 и 7 для нас являются проигрышными, а число 8, выигрышным.";
                }
                else if (count == 5)
                {
                    count++;

                    richTextBox1.Text = "Мы получили последовательность выигрышных чисел – 3, 5, 8. Видно, что выигрышными для нас будут являться числа последовательности 3, 5, 8, 13, 21 и т.д. А как идти от числа 13 к числу 8?";

                    buttons[13].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
                    buttons[21].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
                    buttons[34].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
                }
                else if (count == 6)
                {
                    count++;

                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.V1;

                    richTextBox1.Text = "Последовательность Фибоначчи обладает чудесным свойством, разность данного числа и предыдущего является числом той же последовательности. Движение из числа 13 в число 8 нужно через число 11 (13 - 8 = 5).";

                    for (int i = 9; i < 13; i++)
                    {
                        buttons[i].Image = global::WindowsFormsApplication1.Properties.Resources.крест_1;
                    }
                    buttons[11].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
                }
                else if (count == 7)
                {
                    count++;

                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.V2;

                    for (int i = 14; i < 21; i++)
                    {
                        buttons[i].Image = global::WindowsFormsApplication1.Properties.Resources.крест_1;
                    }
                    buttons[16].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
                    buttons[18].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;

                    richTextBox1.Text = "Из числа 21 в число 13 нужно идти через числа 16 и 18 (21 - 13 = 8).";
                }
                else if (count == 8)
                {
                    count++;

                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.V3;

                    for (int i = 22; i < 34; i++)
                    {
                        buttons[i].Image = global::WindowsFormsApplication1.Properties.Resources.крест_1;
                    }
                    buttons[24].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
                    buttons[26].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
                    buttons[29].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
                    buttons[32].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;

                    richTextBox1.Text = "Движение из числа 34 в число 21 осуществляется через числа 24, 26 и 29 (34 - 21 = 13). Из числа 34 в 29 через число 32. И ТАК ДАЛЕЕ. ";

                    button1.Text = "Завершить";
                }
                else if (button1.Text == "Завершить")
                {
                    richTextBox1.Text = "";
                    richTextBox1.Visible = false;
                    button1.Text = "Начать";

                    for (int i = 0; i < 35; i++)
                    {
                        buttons[i].Image = null;
                    }

                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СП_фон_для_игры;
                }

                #endregion
            }
            else
            {
                #region

                if (button1.Text == "Начать")
                {
                    button1.Text = "Далее";
                    count2 = 0;
                    richTextBox1.Visible = true;

                    richTextBox1.Text = "Положение 0 является выигрывающим, каково бы ни было число спичек, только что взятых, чтобы достичь этого состояния.";
                    
                }
                else if (count2 == 0)
                {
                    count2++;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.спички3;

                    richTextBox1.Text = "Позиция 3 является выигрышной. Если, находясь в позиции 4, мы возьмем 1 спичку, соперник сможет взять 1 или 2 (см. Правила игры). После чего мы в любом случае забираем последнюю спичку. Но! Если мы отправим соперника в позицию 3, находясь в 5, соперник сможет взять от 1 до 4 спичек, что приведет его к победе. Следовательно, позиция 3 является выигрышной, если достигается из позиции 4.";

                }
                else if (count2 == 1)
                {
                    count2++;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.спички5;

                    richTextBox1.Text = "В позицию 5 отправить соперника можно из позиций 6 и 7. Если мы отправляем в позицию 5 из 6, соперник может взять 1 спичку (после чего мы отправляем его в позицию 3, которая уже рассмотрена) или 2 спички (после чего мы забираем оставшиеся). Если же мы отправляем в позицию 5 из 7, соперник сможет взять ещё 3 или 4, после чего мы также забираем последнюю спичку. Но! Если мы отправим соперника в позицию 5 из 8, то он сможет забрать все оставшиеся спички, т.к. взяв 3, мы даем сопернику возможность брать от 1 от 6 спичек.";
                }
                else if (count2 == 2)
                {
                    count2++;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.спички8;

                    richTextBox1.Text = "Анологичным образом определяются позиции, из которых можно отправить соперника в позицию 8. Это позиции 9, 10, 11.";
                }
                else if (count2 == 3)
                {
                    count2++;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.спички11;

                    richTextBox1.Text = "В позицию 11 из позиции 12.";
                }
                else if (count2 == 4)
                {
                    count2++;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.спички13;

                    richTextBox1.Text = "В позицию 13 из позиций с 14ой по 19ую. Если отправить соперника в позицию 13 из 20, он сможет забрать все оставшиеся спички.";
                }
                else if (count2 == 5)
                {
                    count2++;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.спички16;

                    richTextBox1.Text = "В позицию 16 из позиции 17.";
                }
                else if (count2 == 6)
                {
                    count2++;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.спички18;

                    richTextBox1.Text = "В позицию 18 из позиций 19 и 20.";
                }
                else if (count2 == 7)
                {
                    count2++;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.спички21;

                    richTextBox1.Text = "В позицию 21 из позиций с 22ой по 31ую.";
                }
                else if (count2 == 8)
                {
                    count2++;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.спички24;

                    richTextBox1.Text = "В позицию 24 из позиции 25.";
                }
                else if (count2 == 9)
                {
                    count2++;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.спички26;

                    richTextBox1.Text = "В позицию 26 из позиций 27 и 26.";
                }
                else if (count2 == 10)
                {
                    count2++;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.спички29;

                    richTextBox1.Text = "В позицию 29 из позиций 30, 31 и 32.";
                }
                else if (count2 == 11)
                {
                    count2++;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.спички32;

                    richTextBox1.Text = "В позицию 32 из позиции 33.";
                }
                else if (count2 == 12)
                {
                    count2++;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.спички34;

                    richTextBox1.Text = "В позицию 34 из позиций с 35ой по 50ую. И ТАК ДАЛЕЕ.";

                    button1.Text = "Завершить";
                }
                else if (button1.Text == "Завершить")
                {
                    richTextBox1.Text = "";
                    richTextBox1.Visible = false;
                    button1.Text = "Начать";

                    for (int i = 0; i < 35; i++)
                    {
                        buttons[i].Image = null;
                    }

                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СП_фон_для_игры;
                }

                #endregion
            }
        }

        private void справочныйМатериалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox2.Visible = false;
            //pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СП_главная;
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СП_главная;
            richTextBox2.Visible = false;
            if (FlagForS1 == true)
            {
                for (int i = 0; i < 35; i++)
                {
                    buttons[i].Visible = false;
                    labels[i].Visible = false;
                }
                button1.Visible = false;
                richTextBox1.Visible = false;
            }
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СП_фон_для_игры;
            if (FlagForS1 == true)
            {
                for (int i = 0; i < 35; i++)
                {
                    buttons[i].Visible = false;
                    labels[i].Visible = false;
                }
                button1.Visible = false;
                richTextBox1.Visible = false;
            }

            richTextBox2.Visible = true;

        }

        private void теорияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FlagForS1 == true)
            {
                for (int i = 0; i < 35; i++)
                {
                    buttons[i].Visible = false;
                    labels[i].Visible = false;
                }
                button1.Visible = false;
                richTextBox1.Visible = false;
            }
            richTextBox2.Visible = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (FlagForS1 == true)
            {
                for (int i = 0; i < 35; i++)
                {
                    buttons[i].Visible = false;
                    labels[i].Visible = false;
                }
                button1.Visible = false;
                richTextBox1.Visible = false;
            }
            richTextBox2.Visible = false;
            #region

            buttons.Add(button2);
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
            buttons.Add(button18);
            buttons.Add(button19);
            buttons.Add(button20);
            buttons.Add(button21);
            buttons.Add(button22);
            buttons.Add(button23);
            buttons.Add(button24);
            buttons.Add(button25);
            buttons.Add(button26);
            buttons.Add(button27);
            buttons.Add(button28);
            buttons.Add(button29);
            buttons.Add(button30);
            buttons.Add(button31);
            buttons.Add(button32);
            buttons.Add(button33);
            buttons.Add(button34);
            buttons.Add(button35);
            buttons.Add(button36);

            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);
            labels.Add(label8);
            labels.Add(label9);
            labels.Add(label10);
            labels.Add(label11);
            labels.Add(label12);
            labels.Add(label13);
            labels.Add(label14);
            labels.Add(label15);
            labels.Add(label16);
            labels.Add(label17);
            labels.Add(label18);
            labels.Add(label19);
            labels.Add(label20);
            labels.Add(label21);
            labels.Add(label22);
            labels.Add(label23);
            labels.Add(label24);
            labels.Add(label25);
            labels.Add(label26);
            labels.Add(label27);
            labels.Add(label28);
            labels.Add(label29);
            labels.Add(label30);
            labels.Add(label31);
            labels.Add(label32);
            labels.Add(label33);
            labels.Add(label34);
            labels.Add(label35);

            for (int i = 0; i < 35; i++)
            {
                buttons[i].Image = global::WindowsFormsApplication1.Properties.Resources.крест_1;
                buttons[i].Visible = true;
                labels[i].Visible = true;
            }

            buttons[0].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
            buttons[3].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
            buttons[5].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
            buttons[8].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
            buttons[11].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
            buttons[13].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
            buttons[16].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
            buttons[18].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
            buttons[21].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
            buttons[24].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
            buttons[26].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
            buttons[29].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
            buttons[32].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
            buttons[34].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;

            FlagForS1 = true;

            #endregion

            button1.Visible = true;
            button1.Text = "Начать";
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СП_фон_для_игры;
            richTextBox1.Visible = false;
            richTextBox1.Text = "";
            rezim = true;
        }

        private void руководствоПользователюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FlagForS1 == true)
            {
                for (int i = 0; i < 35; i++)
                {
                    buttons[i].Visible = false;
                    labels[i].Visible = false;
                }
                button1.Visible = false;
                richTextBox1.Visible = false;
            }
            richTextBox2.Visible = false;
        }
    }
}
