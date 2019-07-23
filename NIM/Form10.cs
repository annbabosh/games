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
    public partial class Form10 : Form
    {
        List<Button> FirstRow = new List<Button>();
        List<Button> SecondRow = new List<Button>();
        List<Label> NumbersOfMass = new List<Label>();


        public Form10()
        {
            InitializeComponent();
        }

        int[,] SG = new int[2, 14];
        int count = -1, line = -1;
        int OnTheTable2;
        int RivalHave2;
        int CompHave2;
        int raz2 ;
        int ct2;
        bool ZeroOrNot2 ;
        int memory2;
        bool prov = false;

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void демонстрационныеРежимыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_каквар;
            Form11 f1 = new Form11();
            f1.Hide();
            f1.Show();
            f1.label1.Text = "1";
            f1.Text = "Демонстрационные режимы";

            button48.Visible = false;
            button49.Visible = false;
            richTextBox1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            //pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фонн_для_массива2;
            if (prov == true)
            {
                for (int i = 0; i < 14; i++)
                {
                    FirstRow[i].Text = "";
                    FirstRow[i].Visible = false;
                    SecondRow[i].Text = "";
                    SecondRow[i].Visible = false;
                    NumbersOfMass[i].Visible = false;
                }
            }
        }

        private void режимыСПодсказкамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_каквар;
            Form11 f1 = new Form11();
            f1.Hide();
            f1.Show();
            f1.label1.Text = "2";
            f1.Text = "Режимы с подсказками";

            button48.Visible = false;
            button49.Visible = false;
            richTextBox1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            //pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фонн_для_массива2;
            if (prov == true)
            {
                for (int i = 0; i < 14; i++)
                {
                    FirstRow[i].Text = "";
                    FirstRow[i].Visible = false;
                    SecondRow[i].Text = "";
                    SecondRow[i].Visible = false;
                    NumbersOfMass[i].Visible = false;
                }
            }
        }

        private void заполнениеМассиваSGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фонн_для_массива2;

            //заполнение массива SG
            #region

            SG[0, 0] = 0;
            SG[1, 0] = 1;
            SG[0, 1] = 0;
            SG[1, 1] = 1;

            bool[] flags = new bool[14];
            for (int i = 0; i < 14; i++)
            {
                flags[i] = false;
            }

            int my = 0;

            for (int j = 2; j < 14; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    if ((i + j) % 2 == 0)  //у меня нечетное
                        my = 1;
                    else my = 2;


                    int raz = j - 1;
                    int ct = 1;
                    while ((raz >= 0) && (ct <= 4))
                    {
                        flags[SG[(my + ct) % 2, raz]] = true;
                        ct++;
                        raz--;
                    }

                    int memory = 0;
                    for (int l = 13; l >= 0; l--)
                    {
                        if (flags[l] == false)
                            memory = l;
                    }

                    SG[i, j] = memory;

                    for (int l = 0; l < 14; l++)
                    {
                        flags[l] = false;
                    }


                }
            }

            #endregion

            #region

            FirstRow.Add(button1);
            FirstRow.Add(button2);
            FirstRow.Add(button3);
            FirstRow.Add(button4);
            FirstRow.Add(button5);
            FirstRow.Add(button6);
            FirstRow.Add(button7);
            FirstRow.Add(button8);
            FirstRow.Add(button9);
            FirstRow.Add(button10);
            FirstRow.Add(button11);
            FirstRow.Add(button12);
            FirstRow.Add(button13);
            FirstRow.Add(button14);

            SecondRow.Add(button15);
            SecondRow.Add(button16);
            SecondRow.Add(button17);
            SecondRow.Add(button18);
            SecondRow.Add(button19);
            SecondRow.Add(button20);
            SecondRow.Add(button21);
            SecondRow.Add(button22);
            SecondRow.Add(button23);
            SecondRow.Add(button24);
            SecondRow.Add(button25);
            SecondRow.Add(button26);
            SecondRow.Add(button27);
            SecondRow.Add(button28);

            NumbersOfMass.Add(label7);
            NumbersOfMass.Add(label8);
            NumbersOfMass.Add(label9);
            NumbersOfMass.Add(label10);
            NumbersOfMass.Add(label11);
            NumbersOfMass.Add(label12);
            NumbersOfMass.Add(label13);
            NumbersOfMass.Add(label14);
            NumbersOfMass.Add(label15);
            NumbersOfMass.Add(label16);
            NumbersOfMass.Add(label17);
            NumbersOfMass.Add(label18);
            NumbersOfMass.Add(label19);
            NumbersOfMass.Add(label20);

            #endregion

            button48.Visible = true;
            button49.Visible = true;
            richTextBox1.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            prov = true;

            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фонн_для_массива2;

            for (int i = 0; i < 14; i++)
            {
                FirstRow[i].Text = "";
                FirstRow[i].Visible = true;
                SecondRow[i].Text = "";
                SecondRow[i].Visible = true;
                NumbersOfMass[i].Visible = true;
                FirstRow[i].BackColor = Color.Ivory;
                SecondRow[i].BackColor = Color.Ivory;
                NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
            }
            richTextBox1.Text = "";
            button49.Text = "Начать";
            button49.Image = null;
            label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
            label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
            count = -1;
            line = 0;
        }

        private void button49_Click(object sender, EventArgs e)
        {

            #region

            if ((button49.Text == "Начать") && (count == -1))
            {
                button49.Text = "";
                button49.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_стрелка;

                count = 0;

                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    FirstRow[i].Text = "";
                    SecondRow[i].BackColor = Color.Ivory;
                    SecondRow[i].Text = "";
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }

                FirstRow[count].Text = Convert.ToString(SG[line,count]);
                richTextBox1.Text = "Выигрывающей позиции сопоставляется число 0 (на столе монет не осталось, у игрока ЧЕТНОЕ количество монет).";

                FirstRow[count].BackColor = Color.Salmon;
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 1;
            }
            else if (count == 0)
            {
                //
                for (int i = 0; i < 14 ; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                SecondRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данная позиция является проигрышной (на столе монет не осталось, у игрока НЕЧЕТНОЕ количество монет). " + 
                    "Данной игровой позиции сопоставляется целое неотрицательное число, отличное от 0. Например, один.";

                SecondRow[count].BackColor = Color.Salmon;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                count++;
                line = 0;
            }
            else if ((count == 1) && (line == 0))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 =count;
                RivalHave2 = line;
                
                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;                             
                
                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }
                                      
                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                FirstRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе 1 монета, " +
                             "у соперника ЧЕТНОЕ количество монет, у игрока ЧЕТНОЕ)";

                FirstRow[count].BackColor = Color.Salmon;
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 1;
            }
            else if ((count == 1) && (line == 1))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                SecondRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе 1 монета, " +
                             "у соперника НЕЧЕТНОЕ количество монет, у игрока НЕЧЕТНОЕ) ";

                SecondRow[count].BackColor = Color.Salmon;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 0;
                count++;
            }
            else if ((count == 2) && (line == 0))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                FirstRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе 2 монеты, " +
                             "у соперника ЧЕТНОЕ количество монет, следовательно у игрока НЕЧЕТНОЕ)";

                FirstRow[count].BackColor = Color.Salmon;
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 1;
            }
            else if ((count == 2) && (line == 1))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                SecondRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе 2 монеты, " +
                             "у соперника НЕЧЕТНОЕ количество монет, у игрока ЧЕТНОЕ) ";

                SecondRow[count].BackColor = Color.Salmon;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 0;
                count++;
            }
            else if ((count == 3) && (line == 0))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                FirstRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе 3 монеты, " +
                             "у соперника ЧЕТНОЕ количество монет, следовательно у игрока ЧЕТНОЕ)";

                FirstRow[count].BackColor = Color.Salmon;
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 1;
            }
            else if ((count == 3) && (line == 1))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                SecondRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе 3 монеты, " +
                             "у соперника НЕЧЕТНОЕ количество монет, у игрока НЕЧЕТНОЕ) ";

                SecondRow[count].BackColor = Color.Salmon;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 0;
                count++;
            }
            else if ((count == 4) && (line == 0))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                FirstRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе 4 монеты, " +
                             "у соперника ЧЕТНОЕ количество монет, следовательно у игрока НЕЧЕТНОЕ)";

                FirstRow[count].BackColor = Color.Salmon;
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 1;
            }
            else if ((count == 4) && (line == 1))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                SecondRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе 4 монеты, " +
                             "у соперника НЕЧЕТНОЕ количество монет, у игрока ЧЕТНОЕ) ";

                SecondRow[count].BackColor = Color.Salmon;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 0;
                count++;
            }
            else if ((count == 5) && (line == 0))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                FirstRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе 5 монет, " +
                             "у соперника ЧЕТНОЕ количество монет, следовательно у игрока ЧЕТНОЕ)";

                FirstRow[count].BackColor = Color.Salmon;
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 1;
            }
            else if ((count == 5) && (line == 1))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                SecondRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе 5 монет, " +
                             "у соперника НЕЧЕТНОЕ количество монет, у игрока НЕЧЕТНОЕ) ";

                SecondRow[count].BackColor = Color.Salmon;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 0;
                count++;
            }

            else if ((count == 6) && (line == 0))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                FirstRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника ЧЕТНОЕ количество монет, следовательно у игрока НЕЧЕТНОЕ)";

                FirstRow[count].BackColor = Color.Salmon;
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 1;
            }
            else if ((count == 6) && (line == 1))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                SecondRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным).  (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника НЕЧЕТНОЕ количество монет, у игрока ЧЕТНОЕ) ";

                SecondRow[count].BackColor = Color.Salmon;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 0;
                count++;
            }
            else if ((count == 7) && (line == 0))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                FirstRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника ЧЕТНОЕ количество монет, следовательно у игрока ЧЕТНОЕ)";

                FirstRow[count].BackColor = Color.Salmon;
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 1;
            }
            else if ((count ==7) && (line == 1))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                SecondRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника НЕЧЕТНОЕ количество монет, у игрока НЕЧЕТНОЕ) ";

                SecondRow[count].BackColor = Color.Salmon;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 0;
                count++;
            }

            else if ((count == 8) && (line == 0))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                FirstRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника ЧЕТНОЕ количество монет, следовательно у игрока НЕЧЕТНОЕ)";

                FirstRow[count].BackColor = Color.Salmon;
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 1;
            }
            else if ((count == 8) && (line == 1))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                SecondRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным).  (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника НЕЧЕТНОЕ количество монет, у игрока ЧЕТНОЕ) ";

                SecondRow[count].BackColor = Color.Salmon;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 0;
                count++;
            }
            else if ((count == 9) && (line == 0))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                FirstRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника ЧЕТНОЕ количество монет, следовательно у игрока ЧЕТНОЕ)";

                FirstRow[count].BackColor = Color.Salmon;
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 1;
            }
            else if ((count == 9) && (line == 1))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                SecondRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника НЕЧЕТНОЕ количество монет, у игрока НЕЧЕТНОЕ) ";

                SecondRow[count].BackColor = Color.Salmon;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 0;
                count++;
            }

            else if ((count == 10) && (line == 0))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                FirstRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника ЧЕТНОЕ количество монет, следовательно у игрока НЕЧЕТНОЕ)";

                FirstRow[count].BackColor = Color.Salmon;
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 1;
            }
            else if ((count == 10) && (line == 1))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                SecondRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным).  (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника НЕЧЕТНОЕ количество монет, у игрока ЧЕТНОЕ) ";

                SecondRow[count].BackColor = Color.Salmon;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 0;
                count++;
            }
            else if ((count == 11) && (line == 0))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                FirstRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника ЧЕТНОЕ количество монет, следовательно у игрока ЧЕТНОЕ)";

                FirstRow[count].BackColor = Color.Salmon;
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 1;
            }
            else if ((count ==11) && (line == 1))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                SecondRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника НЕЧЕТНОЕ количество монет, у игрока НЕЧЕТНОЕ) ";

                SecondRow[count].BackColor = Color.Salmon;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 0;
                count++;
            }

            else if ((count == 12) && (line == 0))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                FirstRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника ЧЕТНОЕ количество монет, следовательно у игрока НЕЧЕТНОЕ)";

                FirstRow[count].BackColor = Color.Salmon;
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 1;
            }
            else if ((count == 12) && (line == 1))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                SecondRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным).  (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника НЕЧЕТНОЕ количество монет, у игрока ЧЕТНОЕ) ";

                SecondRow[count].BackColor = Color.Salmon;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 0;
                count++;
            }
            else if ((count == 13) && (line == 0))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                FirstRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника ЧЕТНОЕ количество монет, следовательно у игрока ЧЕТНОЕ)";

                FirstRow[count].BackColor = Color.Salmon;
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 1;
            }
            else if ((count == 13) && (line == 1))
            {
                //
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                //

                //////
                #region

                OnTheTable2 = count;
                RivalHave2 = line;

                if ((OnTheTable2 + RivalHave2) % 2 == 0)
                {
                    CompHave2 = 1;
                }
                else CompHave2 = 2;

                if (RivalHave2 % 2 == 0)                                 //
                {
                    FirstRow[OnTheTable2].BackColor = Color.Salmon;      //
                }
                else SecondRow[OnTheTable2].BackColor = Color.Salmon;    //

                raz2 = OnTheTable2 - 1;
                ct2 = 1;
                ZeroOrNot2 = false;
                memory2 = 0;

                while ((raz2 >= 0) && (ct2 <= 4))
                {
                    if (ZeroOrNot2 == false)
                    {
                        memory2 = raz2;
                    }

                    if ((CompHave2 + ct2) % 2 == 0)                      //
                    {
                        FirstRow[raz2].BackColor = Color.LightGreen;    //
                    }
                    else SecondRow[raz2].BackColor = Color.LightGreen;  //

                    if ((SG[(CompHave2 + ct2) % 2, raz2] == 0) && (ZeroOrNot2 == false))
                    {
                        ZeroOrNot2 = true;
                    }

                    ct2++;
                    raz2--;
                }

                #endregion
                //////

                SecondRow[count].Text = Convert.ToString(SG[line, count]);
                richTextBox1.Text = "Данной игровой позиции сопоставляется наименьшее целое число, отличающееся от чисел, " +
                             "связанных с позициями, которые могут быть достигнуты (выделены зеленым цветом), исходя из данной (выделена красным). (На столе " + Convert.ToString(count) + " монет, " +
                             "у соперника НЕЧЕТНОЕ количество монет, у игрока НЕЧЕТНОЕ) ";

                SecondRow[count].BackColor = Color.Salmon;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                NumbersOfMass[count].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;

                line = 0;
                count++;

                button49.Text = "Завершить";
                button49.Image = null;
            }
            else if (button49.Text == "Завершить")
            {
                button49.Text = "Начать";
                for (int i = 0; i < 14; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                }
                richTextBox1.Text = "";
                count = -1;
            }
            #endregion
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button48.Visible = false;
            button49.Visible = false;
            richTextBox1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            richTextBox2.Visible = false;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_каквар;
            if (prov == true)
            {
                for (int i = 0; i < 14; i++)
                {
                    FirstRow[i].Text = "";
                    FirstRow[i].Visible = false;
                    SecondRow[i].Text = "";
                    SecondRow[i].Visible = false;
                    NumbersOfMass[i].Visible = false;
                }
            }
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фонн_для_массива2;


            button48.Visible = false;
            button49.Visible = false;
            richTextBox1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фонн_для_массива2;
            if (prov == true)
            {
                for (int i = 0; i < 14; i++)
                {
                    FirstRow[i].Text = "";
                    FirstRow[i].Visible = false;
                    SecondRow[i].Text = "";
                    SecondRow[i].Visible = false;
                    NumbersOfMass[i].Visible = false;
                }
            }
        }

        private void справочныйМатериалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox2.Visible = false;
           

            //button48.Visible = false;
            //button49.Visible = false;
            //richTextBox1.Visible = false;
            //label5.Visible = false;
            //label6.Visible = false;

            //pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_каквар;
            //if (prov == true)
            //{
            //    for (int i = 0; i < 14; i++)
            //    {
            //        FirstRow[i].Text = "";
            //        FirstRow[i].Visible = false;
            //        SecondRow[i].Text = "";
            //        SecondRow[i].Visible = false;
            //        NumbersOfMass[i].Visible = false;
            //    }
            //}
        }

        private void теорияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фонн_для_массива2;

            button48.Visible = false;
            button49.Visible = false;
            richTextBox1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фонн_для_массива2;
            if (prov == true)
            {
                for (int i = 0; i < 14; i++)
                {
                    FirstRow[i].Text = "";
                    FirstRow[i].Visible = false;
                    SecondRow[i].Text = "";
                    SecondRow[i].Visible = false;
                    NumbersOfMass[i].Visible = false;
                }
            }
        }

        private void руководствоПользователюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фонн_для_массива2;

            button48.Visible = false;
            button49.Visible = false;
            richTextBox1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фонн_для_массива2;
            if (prov == true)
            {
                for (int i = 0; i < 14; i++)
                {
                    FirstRow[i].Text = "";
                    FirstRow[i].Visible = false;
                    SecondRow[i].Text = "";
                    SecondRow[i].Visible = false;
                    NumbersOfMass[i].Visible = false;
                }
            }
        }


    }
}
