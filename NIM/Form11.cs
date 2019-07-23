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
    public partial class Form11 : Form
    {
        List<PictureBox> pictures = new List<PictureBox>();
        List<Image> images1 = new List<Image>();
        List<Image> images2 = new List<Image>();
        List<Button> FirstRow = new List<Button>();
        List<Button> SecondRow = new List<Button>();
        List<Label> NumbersOfMass = new List<Label>();

        public Form11()
        {
            InitializeComponent();
        }

        int countbut = 0, sum1, sum2, rd, temp = 4, count = 1, ForHr1, ForHr2, ForExplanations;
        string name1, name2;
        bool r1 = false, r2 = false, r3 = false, parity = false; 
        int[,] SG = new int[2, 20];

        int jRed = 0;
        int[,] Tries = new int[2, 4];
        int COUNT = 2;
        int CountForTries = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            r1 = true;
            r2 = false;
            r3 = false;
            sum1 = 0;
            sum2 = 0;

            textBox1.Text = "";
            textBox2.Text = "";

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_заст_для_ч_ч2;

            textBox1.Visible = true;
            textBox2.Visible = true;

            #region

            pictures.Add(pictureBox3);
            pictures.Add(pictureBox4);
            pictures.Add(pictureBox5);
            pictures.Add(pictureBox6);
            pictures.Add(pictureBox7);
            pictures.Add(pictureBox8);
            pictures.Add(pictureBox9);
            pictures.Add(pictureBox10);
            pictures.Add(pictureBox11);
            pictures.Add(pictureBox12);
            pictures.Add(pictureBox13);
            pictures.Add(pictureBox14);
            pictures.Add(pictureBox15);
            pictures.Add(pictureBox16);
            pictures.Add(pictureBox17);
            pictures.Add(pictureBox18);
            pictures.Add(pictureBox19);
            pictures.Add(pictureBox20);
            pictures.Add(pictureBox21);
            pictures.Add(pictureBox22);
            pictures.Add(pictureBox23);

            for (int i = 0; i < 20; i++)
            {
                images1.Add(global::WindowsFormsApplication1.Properties.Resources.монета1);
                images2.Add(global::WindowsFormsApplication1.Properties.Resources.монета2);
            }

            #endregion

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox2.Text != textBox1.Text) && (r1 == true))
            {
                #region

                label2.Visible = true;
                label2.Text = Convert.ToString(sum1);
                label3.Visible = true;
                label3.Text = Convert.ToString(sum2);

                label4.Visible = true;

                pictureBox2.Visible = true;
                pictureBox23.Visible = true;
                pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка1;
                pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка2;

                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фонн;

                textBox1.Visible = false;
                textBox2.Visible = false;
                button4.Visible = false;

                ForHr1 = 1;
                ForHr2 = 1;
                

                Random rand = new Random();
                rd = rand.Next(7) + 14;

                while (rd % 2 == 0)
                {
                    rd = rand.Next(7) + 14;
                }

                for (int i = 0; i < rd; i++)
                {
                    pictures[i].Visible = true;
                    pictures[i].Image = images1[i];
                }
                name1 = textBox1.Text;
                name2 = textBox2.Text;
                textBox1.Text = "";
                textBox2.Text = "";
                button5.Visible = true;
                button5.Text = name1;
                button6.Visible = true;
                button6.Text = name2;
                button5.BackColor = Color.Plum;
                button6.BackColor = Color.Ivory;

                

                count = 1;

                this.ClientSize = new System.Drawing.Size(775, 392);
                this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                #endregion
            }
            if ((textBox3.Text != "") && (r2 == true))
            {
                #region

                label2.Visible = true;
                label2.Text = Convert.ToString(sum1);
                label3.Visible = true;
                label3.Text = Convert.ToString(sum2);

                label4.Visible = true;

                pictureBox2.Visible = true;
                pictureBox23.Visible = true;
                pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка1;
                pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка2;

                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фонн;

                textBox3.Visible = false;
                button4.Visible = false;

                ForHr1 = 1;
                ForHr2 = 1;

                button52.Visible = true;
                countbut = 0;


                Random rand = new Random();
                rd = rand.Next(7) + 14;

                while (rd % 2 == 0)
                {
                    rd = rand.Next(7) + 14;
                }
                //rd = 19;
                for (int i = 0; i < rd; i++)
                {
                    pictures[i].Visible = true;
                    pictures[i].Image = images1[i];
                }
                
                name1 = textBox3.Text;
                name2 = "Компьютер";
                textBox3.Text = "";
                button5.Visible = true;
                button5.Text = name1;
                button6.Visible = true;
                button6.Text = name2;
                button5.BackColor = Color.Plum;
                button6.BackColor = Color.Ivory;

                count = 1;

                this.ClientSize = new System.Drawing.Size(775, 392);
                this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);


                

                //заполнение массива SG

                SG[0, 0] = 0;
                SG[1, 0] = 1;
                SG[0, 1] = 0;
                SG[1, 1] = 1;

                bool[] flags = new bool[20];
                for (int i = 0; i < 20; i++)
                {
                    flags[i] = false;
                }

                int my = 0;

                for (int j = 2; j < 20; j++) 
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
                        for (int l = 19; l >= 0; l--)
                        {
                            if (flags[l] == false)
                                memory = l;
                        }

                        SG[i, j] = memory;

                        for (int l = 0; l < 20; l++)
                        {
                            flags[l] = false;
                        }
                        
                        
                    }
                }

                #region

                FirstRow.Add(button10); FirstRow.Add(button11);
                FirstRow.Add(button12); FirstRow.Add(button13);
                FirstRow.Add(button14); FirstRow.Add(button15);
                FirstRow.Add(button16); FirstRow.Add(button17);
                FirstRow.Add(button18); FirstRow.Add(button19);
                FirstRow.Add(button20); FirstRow.Add(button21);
                FirstRow.Add(button22); FirstRow.Add(button23);
                FirstRow.Add(button24); FirstRow.Add(button25);
                FirstRow.Add(button26); FirstRow.Add(button27);
                FirstRow.Add(button28); FirstRow.Add(button50);

                SecondRow.Add(button29); SecondRow.Add(button30);
                SecondRow.Add(button31); SecondRow.Add(button32);
                SecondRow.Add(button33); SecondRow.Add(button34);
                SecondRow.Add(button35); SecondRow.Add(button36);
                SecondRow.Add(button37); SecondRow.Add(button38);
                SecondRow.Add(button39); SecondRow.Add(button40);
                SecondRow.Add(button41); SecondRow.Add(button42);
                SecondRow.Add(button43); SecondRow.Add(button44);
                SecondRow.Add(button45); SecondRow.Add(button46);
                SecondRow.Add(button47); SecondRow.Add(button51);

                NumbersOfMass.Add(label7); NumbersOfMass.Add(label8);
                NumbersOfMass.Add(label9); NumbersOfMass.Add(label10);
                NumbersOfMass.Add(label11); NumbersOfMass.Add(label12);
                NumbersOfMass.Add(label13); NumbersOfMass.Add(label14);
                NumbersOfMass.Add(label15); NumbersOfMass.Add(label16);
                NumbersOfMass.Add(label17); NumbersOfMass.Add(label18);
                NumbersOfMass.Add(label19); NumbersOfMass.Add(label20);
                NumbersOfMass.Add(label21); NumbersOfMass.Add(label22);
                NumbersOfMass.Add(label23); NumbersOfMass.Add(label24);
                NumbersOfMass.Add(label25); NumbersOfMass.Add(label26);

                button48.Visible = true;
                button49.Visible = false;
                ForExplanations = 0;
                button49.Enabled = false;
                richTextBox1.Visible = false;
                label5.Visible = true;
                label6.Visible = true;

                for (int i = 0; i < 20; i++)
                {
                    FirstRow[i].Text = "";
                    FirstRow[i].BackColor = Color.Ivory;
                    FirstRow[i].Visible = false;
                    SecondRow[i].Text = "";
                    SecondRow[i].BackColor = Color.Ivory;
                    SecondRow[i].Visible = false;
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    NumbersOfMass[i].Visible = false;
                }

                for (int i = 0; i <= rd; i++)
                {
                    FirstRow[i].Visible = true;
                    SecondRow[i].Visible = true;
                    NumbersOfMass[i].Visible = true;
                }

                for (int i = 0; i < 20; i++)
                {
                    FirstRow[i].Text = Convert.ToString(SG[0, i]);
                    SecondRow[i].Text = Convert.ToString(SG[1, i]);
                }

                #endregion

                if (label1.Text == "2")
                {

                    int cc = 0;
                    for (int i = 0; i < 20; i++)
                    {
                        if (pictures[i].Visible == true)
                            cc++;
                    }

                    int OnTheTable = cc;
                    int RivalHave = sum2;
                    int CompHave;

                    if ((OnTheTable + RivalHave) % 2 == 0)
                    {
                        CompHave = 1;
                    }
                    else CompHave = 2;

                    if (RivalHave % 2 == 0)                                 //
                    {
                        FirstRow[OnTheTable].BackColor = Color.Salmon;      //
                    }
                    else SecondRow[OnTheTable].BackColor = Color.Salmon;    //

                    int raz2 = OnTheTable - 1;
                    int ct2 = 1;
                    bool ZeroOrNot = false;
                    int memory2 = 0;
                    int memoryForRowNumber = 0, memoryForRowNumber2 = 0;    //
                    bool flagForRowNumber = false;                          //



                    while ((raz2 >= 0) && (ct2 <= 4))
                    {
                        if (ZeroOrNot == false)
                        {
                            memory2 = raz2;
                        }

                        if ((CompHave + ct2) % 2 == 0)                      //
                        {
                            FirstRow[raz2].BackColor = Color.LightGreen;    //
                        }
                        else SecondRow[raz2].BackColor = Color.LightGreen;  //

                        if ((SG[(CompHave + ct2) % 2, raz2] == 0) && (ZeroOrNot == false))
                        {
                            ZeroOrNot = true;
                            memoryForRowNumber2 = (CompHave + ct2) % 2;
                        }

                        if (flagForRowNumber == false)
                        {
                            memoryForRowNumber = (CompHave + ct2) % 2;
                            flagForRowNumber = true;
                        }

                        ct2++;
                        raz2--;
                    }

                    //if (ZeroOrNot == false)
                    //{
                    //    memory2 = OnTheTable - 1;
                    //    if (memoryForRowNumber == 0)
                    //        FirstRow[memory2].BackColor = Color.LimeGreen;
                    //    else SecondRow[memory2].BackColor = Color.LimeGreen;
                    //}
                    //else
                    //{
                    //    if (memoryForRowNumber2 == 0)
                    //        FirstRow[memory2].BackColor = Color.LimeGreen;
                    //    else SecondRow[memory2].BackColor = Color.LimeGreen;
                    //}
                }
                #endregion
            }
            
            if ((textBox3.Text != "") && (r3 == true))
            {
                #region

                label2.Visible = true;
                label2.Text = Convert.ToString(sum1);
                label3.Visible = true;
                label3.Text = Convert.ToString(sum2);
                pictureBox24.Visible = true;
                label4.Visible = true;

                pictureBox2.Visible = true;
                pictureBox23.Visible = true;
                pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка1;
                pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка2;

                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фонн;

                textBox3.Visible = false;
                button4.Visible = false;

                ForHr1 = 1;
                ForHr2 = 1;

                button52.Visible = true;
                countbut = 0;

                Random rand = new Random();
                rd = rand.Next(7) + 14;

                while (rd % 2 == 0)
                {
                    rd = rand.Next(7) + 14;
                }
                //rd = 19;
                for (int i = 0; i < rd; i++)
                {
                    pictures[i].Visible = true;
                    pictures[i].Image = images1[i];
                    
                }
               

                name1 = "Компьютер";
                name2 = textBox3.Text;
                textBox3.Text = "";
                button5.Visible = true;
                button5.Text = name1;
                button6.Visible = true;
                button6.Text = name2;
                button5.BackColor = Color.Ivory;
                button6.BackColor = Color.Plum;

                count = 1;

            this.ClientSize = new System.Drawing.Size(775, 392);
                this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                

                //заполнение массива SG

                SG[0, 0] = 0;
                SG[1, 0] = 1;
                SG[0, 1] = 0;
                SG[1, 1] = 1;

                bool[] flags = new bool[20];
                for (int i = 0; i < 20; i++)
                {
                    flags[i] = false;
                }

                int my = 0;

                for (int j = 2; j < 20; j++)
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
                        for (int l = 19; l >= 0; l--)
                        {
                            if (flags[l] == false)
                                memory = l;
                        }

                        SG[i, j] = memory;

                        for (int l = 0; l < 20; l++)
                        {
                            flags[l] = false;
                        }


                    }
                }

                #region

                FirstRow.Add(button10);
                FirstRow.Add(button11);
                FirstRow.Add(button12);
                FirstRow.Add(button13);
                FirstRow.Add(button14);
                FirstRow.Add(button15);
                FirstRow.Add(button16);
                FirstRow.Add(button17);
                FirstRow.Add(button18);
                FirstRow.Add(button19);
                FirstRow.Add(button20);
                FirstRow.Add(button21);
                FirstRow.Add(button22);
                FirstRow.Add(button23);
                FirstRow.Add(button24);
                FirstRow.Add(button25);
                FirstRow.Add(button26);
                FirstRow.Add(button27);
                FirstRow.Add(button28);
                FirstRow.Add(button50);

                SecondRow.Add(button29);
                SecondRow.Add(button30);
                SecondRow.Add(button31);
                SecondRow.Add(button32);
                SecondRow.Add(button33);
                SecondRow.Add(button34);
                SecondRow.Add(button35);
                SecondRow.Add(button36);
                SecondRow.Add(button37);
                SecondRow.Add(button38);
                SecondRow.Add(button39);
                SecondRow.Add(button40);
                SecondRow.Add(button41);
                SecondRow.Add(button42);
                SecondRow.Add(button43);
                SecondRow.Add(button44);
                SecondRow.Add(button45);
                SecondRow.Add(button46);
                SecondRow.Add(button47);
                SecondRow.Add(button51);

                NumbersOfMass.Add(label7); NumbersOfMass.Add(label8);
                NumbersOfMass.Add(label9); NumbersOfMass.Add(label10);
                NumbersOfMass.Add(label11); NumbersOfMass.Add(label12);
                NumbersOfMass.Add(label13); NumbersOfMass.Add(label14);
                NumbersOfMass.Add(label15); NumbersOfMass.Add(label16);
                NumbersOfMass.Add(label17); NumbersOfMass.Add(label18);
                NumbersOfMass.Add(label19); NumbersOfMass.Add(label20);
                NumbersOfMass.Add(label21); NumbersOfMass.Add(label22);
                NumbersOfMass.Add(label23); NumbersOfMass.Add(label24);
                NumbersOfMass.Add(label25); NumbersOfMass.Add(label26);

                button48.Visible = true;
                button49.Visible = true;
                ForExplanations = 0;
                richTextBox1.Visible = false;
                label5.Visible = true;
                label6.Visible = true;

                for (int i = 0; i < 20; i++)
                {
                    FirstRow[i].Text = "";
                    FirstRow[i].BackColor = Color.Ivory;
                    FirstRow[i].Visible = false;
                    SecondRow[i].Text = "";
                    SecondRow[i].BackColor = Color.Ivory;
                    SecondRow[i].Visible = false;
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    NumbersOfMass[i].Visible = false;
                }

                for (int i = 0; i <= rd; i++)
                {
                    FirstRow[i].Visible = true;
                    SecondRow[i].Visible = true;
                    NumbersOfMass[i].Visible = true;
                }


                for (int i = 0; i < 20; i++)
                {
                    FirstRow[i].Text = Convert.ToString(SG[0, i]);
                    SecondRow[i].Text = Convert.ToString(SG[1, i]);
                }

                #endregion

                if (label1.Text == "1")
                {
                    #region

                    int cc = 0;
                    for (int i = 0; i < 20; i++)
                    {
                        if (pictures[i].Visible == true)
                            cc++;
                    }

                    int OnTheTable = cc;
                    int RivalHave = sum1;
                    int CompHave;

                    if ((OnTheTable + RivalHave) % 2 == 0)
                    {
                        CompHave = 1;
                    }
                    else CompHave = 2;

                    if (RivalHave % 2 == 0)                                 //
                    {
                        FirstRow[OnTheTable].BackColor = Color.Salmon;      //
                    }
                    else SecondRow[OnTheTable].BackColor = Color.Salmon;    //

                    int raz2 = OnTheTable - 1;
                    int ct2 = 1;
                    bool ZeroOrNot = false;
                    int memory2 = 0;
                    int memoryForRowNumber = 0, memoryForRowNumber2 = 0;    //
                    bool flagForRowNumber = false;                          //



                    while ((raz2 >= 0) && (ct2 <= 4))
                    {
                        if (ZeroOrNot == false)
                        {
                            memory2 = raz2;
                        }

                        if ((CompHave + ct2) % 2 == 0)                      //
                        {
                            FirstRow[raz2].BackColor = Color.LightGreen;    //
                        }
                        else SecondRow[raz2].BackColor = Color.LightGreen;  //

                        if ((SG[(CompHave + ct2) % 2, raz2] == 0) && (ZeroOrNot == false))
                        {
                            ZeroOrNot = true;
                            memoryForRowNumber2 = (CompHave + ct2) % 2;
                        }

                        if (flagForRowNumber == false)
                        {
                            memoryForRowNumber = (CompHave + ct2) % 2;
                            flagForRowNumber = true;
                        }

                        ct2++;
                        raz2--;
                    }

                    if (ZeroOrNot == false)
                    {
                        memory2 = OnTheTable - 1;
                        if (memoryForRowNumber == 0)
                            FirstRow[memory2].BackColor = Color.LimeGreen;
                        else SecondRow[memory2].BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        if (memoryForRowNumber2 == 0)
                            FirstRow[memory2].BackColor = Color.LimeGreen;
                        else SecondRow[memory2].BackColor = Color.LimeGreen;
                    }

                    for (int i = memory2; i < OnTheTable; i++)
                    {
                        pictures[i].Visible = false;
                    }
                    sum1 = sum1 + (OnTheTable - memory2);
                    label2.Text = Convert.ToString(sum1);

                    ForHr1 = 1;
                    timer1.Enabled = true;
                    pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.ич_гиф_vsPYD;

                    #endregion
                }

                if (label1.Text == "2")
                {
                    #region

                    button49.Visible = false;

                    int cc = 0;
                    for (int i = 0; i < 20; i++)
                    {
                        if (pictures[i].Visible == true)
                            cc++;
                    }

                    int OnTheTable = cc;
                    int RivalHave = sum1;
                    int CompHave;

                    if ((OnTheTable + RivalHave) % 2 == 0)
                    {
                        CompHave = 1;
                    }
                    else CompHave = 2;



                    int raz2 = OnTheTable - 1;
                    int ct2 = 1;
                    bool ZeroOrNot = false;
                    int memory2 = 0;




                    while ((raz2 >= 0) && (ct2 <= 4))
                    {
                        if (ZeroOrNot == false)
                        {
                            memory2 = raz2;
                        }



                        if ((SG[(CompHave + ct2) % 2, raz2] == 0) && (ZeroOrNot == false))
                        {
                            ZeroOrNot = true;

                        }

                        ct2++;
                        raz2--;
                    }

                    if (ZeroOrNot == false)
                    {
                        memory2 = OnTheTable - 1;
                    }


                    for (int i = memory2; i < OnTheTable; i++)
                    {
                        pictures[i].Visible = false;
                    }
                    sum1 = sum1 + (OnTheTable - memory2);
                    label2.Text = Convert.ToString(sum1);

                    ForHr1 = 1;
                    timer1.Enabled = true;
                    pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.ич_гиф_vsPYD;

                    //////
                    #region

                    int cc3 = 0;
                    for (int i = 0; i < 20; i++)
                    {
                        if (pictures[i].Visible == true)
                            cc3++;
                    }

                    int OnTheTable3 = cc3;
                    int RivalHave3 = sum1;
                    int CompHave3;

                    if ((OnTheTable3 + RivalHave3) % 2 == 0)
                    {
                        CompHave3 = 1;
                    }
                    else CompHave3 = 2;

                    if (RivalHave3 % 2 == 0)                                 //
                    {
                        FirstRow[OnTheTable3].BackColor = Color.Salmon;      //
                    }
                    else SecondRow[OnTheTable3].BackColor = Color.Salmon;    //

                    int raz3 = OnTheTable3 - 1;
                    int ct3 = 1;
                    bool ZeroOrNot3 = false;
                    int memory3 = 0;
                    int memoryForRowNumber3 = 0, memoryForRowNumber23 = 0;    //
                    bool flagForRowNumber3 = false;                          //



                    while ((raz3 >= 0) && (ct3 <= 4))
                    {
                        if (ZeroOrNot3 == false)
                        {
                            memory3 = raz3;
                        }

                        if ((CompHave3 + ct3) % 2 == 0)                      //
                        {
                            FirstRow[raz3].BackColor = Color.LightGreen;    //
                        }
                        else SecondRow[raz3].BackColor = Color.LightGreen;  //

                        if ((SG[(CompHave3 + ct3) % 2, raz3] == 0) && (ZeroOrNot3 == false))
                        {
                            ZeroOrNot3 = true;
                            memoryForRowNumber23 = (CompHave3 + ct3) % 2;
                        }

                        if (flagForRowNumber3 == false)
                        {
                            memoryForRowNumber3 = (CompHave3 + ct3) % 2;
                            flagForRowNumber3 = true;
                        }

                        ct3++;
                        raz3--;
                    }

                    #endregion
                    ////////

                    #endregion
                }

                #endregion
            }

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (r1 == true)
            {
                #region

                int k = 0;
                string s = (sender as PictureBox).Name;

                int num = 0;
                bool f = false;
                for (int i = 0; i < 20; i++)
                {
                    if (f == false)
                        k++;
                    if (pictures[i].Name == s)
                    {
                        f = true;
                        num = i;
                    }

                }

                int kc;

                if (pictures[num].Image == images2[num])
                {
                    if (count == 1)
                    {
                        count = 0;
                        button6.BackColor = Color.Plum;
                        button5.BackColor = Color.Ivory;

                        kc = 0;

                        for (int i = k - 1; i < 20; i++)
                        {
                            if (pictures[i].Visible == true)
                            {
                                pictures[i].Visible = false;
                                kc++;
                            }
                        }
                        sum1 = sum1 + kc;
                        label2.Text = Convert.ToString(sum1);

                        ForHr1 = 1;
                        timer1.Enabled = true;
                        pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.ич_гиф_vsPYD;
                    }
                    else
                    {
                        count = 1;
                        button5.BackColor = Color.Plum;
                        button6.BackColor = Color.Ivory;

                        kc = 0;

                        for (int i = k - 1; i < 20; i++)
                        {
                            if (pictures[i].Visible == true)
                            {
                                pictures[i].Visible = false;
                                kc++;
                            }
                        }
                        sum2 = sum2 + kc;
                        label3.Text = Convert.ToString(sum2);

                        ForHr2 = 1;
                        timer2.Enabled = true;
                        pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_гиф;
                    }


                    int cc = 0;
                    for (int i = 0; i < 20; i++)
                    {
                        if (pictures[i].Visible == true)
                            cc++;
                    }

                    if (cc == 0)
                    {
                        button8.Visible = true;
                        button9.Visible = true;
                        button7.Visible = true;
                        pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_хотсыгрещё2;

                        if (sum1 % 2 == 0)
                        {
                            button7.Text = name1;
                        }
                        else button7.Text = name2;

                        

                        button5.Visible = false;
                        button6.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox23.Visible = false;

                        this.ClientSize = new System.Drawing.Size(620, 392);
                        this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                        (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                        pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка1;
                        pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка2;

                    }
                }
                #endregion
            }

            if ((r2 == true))
            {
                if (label1.Text == "1")
                {
                    #region

                    //Ход пользователя


                    for (int i = 0; i < 20; i++)
                    {
                        FirstRow[i].BackColor = Color.Ivory;
                        SecondRow[i].BackColor = Color.Ivory;
                        NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    }
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;

                    int k = 0;
                    string s = (sender as PictureBox).Name;
                    int nnum = 0;
                    bool f = false;
                    for (int i = 0; i < 20; i++)
                    {
                        if (f == false)
                            k++;
                        if (pictures[i].Name == s)
                        {
                            f = true;
                            nnum = i;
                        }

                    }

                    if (pictures[nnum].Image == images2[nnum])
                    {

                        int kc = 0;

                        for (int i = k - 1; i < 20; i++)
                        {
                            if (pictures[i].Visible == true)
                            {
                                pictures[i].Visible = false;
                                kc++;
                            }
                        }
                        sum1 = sum1 + kc;
                        label2.Text = Convert.ToString(sum1);

                        ForHr1 = 1;
                        timer1.Enabled = true;
                        pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.ич_гиф_vsPYD;

                        int cc = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (pictures[i].Visible == true)
                                cc++;
                        }

                        if (cc == 0)
                        {
                            button8.Visible = true;
                            button9.Visible = true;
                            button7.Visible = true;
                            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_хотсыгрещё2;

                            if (sum1 % 2 == 0)
                            {
                                button7.Text = name1;
                            }
                            else button7.Text = name2;

                            button5.Visible = false;
                            button6.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            pictureBox2.Visible = false;
                            pictureBox23.Visible = false;

                            button52.Visible = false;

                            this.ClientSize = new System.Drawing.Size(620, 392);
                            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                            (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                            pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка1;
                            pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка2;
                        }
                        else
                        {
                            //Ход компьютера

                            cc = 0;
                            for (int i = 0; i < 20; i++)
                            {
                                if (pictures[i].Visible == true)
                                    cc++;
                            }

                            int OnTheTable = cc;
                            int RivalHave = sum1;
                            int CompHave;

                            if ((OnTheTable + RivalHave) % 2 == 0)
                            {
                                CompHave = 1;
                            }
                            else CompHave = 2;

                            if (RivalHave % 2 == 0)                                 //
                            {
                                FirstRow[OnTheTable].BackColor = Color.Salmon;      //
                            }
                            else SecondRow[OnTheTable].BackColor = Color.Salmon;    //

                            int raz = OnTheTable - 1;
                            int ct = 1;
                            bool ZeroOrNot = false;
                            int memory = 0;
                            int memoryForRowNumber = 0, memoryForRowNumber2 = 0;    //
                            bool flagForRowNumber = false;                          //

                            

                            while ((raz >= 0) && (ct <= 4))
                            {
                                if (ZeroOrNot == false)
                                {
                                    memory = raz;
                                }

                                if ((CompHave + ct) % 2 == 0)                      //
                                {
                                    FirstRow[raz].BackColor = Color.LightGreen;    //
                                }
                                else SecondRow[raz].BackColor = Color.LightGreen;  //

                                if ((SG[(CompHave + ct) % 2, raz] == 0) && (ZeroOrNot == false))
                                {
                                    ZeroOrNot = true;
                                    memoryForRowNumber2 = (CompHave + ct) % 2; 
                                }

                                if (flagForRowNumber == false)
                                {
                                    memoryForRowNumber = (CompHave + ct) % 2;
                                    flagForRowNumber = true;
                                }
                                
                                ct++;
                                raz--;
                            }

                            if (ZeroOrNot == false)
                            {
                                memory = OnTheTable - 1;
                                if (memoryForRowNumber == 0)
                                    FirstRow[memory].BackColor = Color.LimeGreen;
                                else SecondRow[memory].BackColor = Color.LimeGreen;
                            }
                            else
                            {
                                if (memoryForRowNumber2 == 0)
                                    FirstRow[memory].BackColor = Color.LimeGreen;
                                else SecondRow[memory].BackColor = Color.LimeGreen;
                            }

                            for (int i = memory; i < OnTheTable; i++)
                            {
                                pictures[i].Visible = false;
                            }
                            sum2 = sum2 + (OnTheTable - memory);
                            label3.Text = Convert.ToString(sum2);

                            ForHr2 = 1;
                            timer2.Enabled = true;
                            pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_гиф;

                            cc = 0;
                            for (int i = 0; i < 20; i++)
                            {
                                if (pictures[i].Visible == true)
                                    cc++;
                            }

                            button49.Visible = true;
                            button49.Enabled = true;

                            if (cc == 0)
                            {
                                button8.Visible = true;
                                button9.Visible = true;
                                button7.Visible = true;
                                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_хотсыгрещё2;

                                if (sum1 % 2 == 0)
                                {
                                    button7.Text = name1;
                                }
                                else button7.Text = name2;

                                button52.Visible = false;

                                button5.Visible = false;
                                button6.Visible = false;
                                label2.Visible = false;
                                label3.Visible = false;
                                label4.Visible = false;
                                pictureBox2.Visible = false;
                                pictureBox23.Visible = false;

                                this.ClientSize = new System.Drawing.Size(620, 392);
                                this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                                pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка1;
                                pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка2;
                            }
                        }

                    }
                    #endregion
                }

                if (label1.Text == "2")
                {
                    #region

                    for (int i = 0; i < 20; i++)
                    {
                        FirstRow[i].BackColor = Color.Ivory;
                        SecondRow[i].BackColor = Color.Ivory;
                        NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    }
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;

                    //Ход пользователя

                    

                   

                    int k = 0;
                    string s = (sender as PictureBox).Name;
                    int nnum = 0;
                    bool f = false;
                    for (int i = 0; i < 20; i++)
                    {
                        if (f == false)
                            k++;
                        if (pictures[i].Name == s)
                        {
                            f = true;
                            nnum = i;
                        }

                    }

                    if (pictures[nnum].Image == images2[nnum])
                    {

                        int kc = 0;

                        for (int i = k - 1; i < 20; i++)
                        {
                            if (pictures[i].Visible == true)
                            {
                                pictures[i].Visible = false;
                                kc++;
                            }
                        }
                        sum1 = sum1 + kc;
                        label2.Text = Convert.ToString(sum1);

                        ForHr1 = 1;
                        timer1.Enabled = true;
                        pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.ич_гиф_vsPYD;

                        int cc = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (pictures[i].Visible == true)
                                cc++;
                        }

                        

                        if (cc == 0)
                        {
                            button8.Visible = true;
                            button9.Visible = true;
                            button7.Visible = true;
                            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_хотсыгрещё2;

                            if (sum1 % 2 == 0)
                            {
                                button7.Text = name1;
                            }
                            else button7.Text = name2;

                            button5.Visible = false;
                            button6.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            pictureBox2.Visible = false;
                            pictureBox23.Visible = false;

                            button52.Visible = false;

                            this.ClientSize = new System.Drawing.Size(620, 392);
                            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                            (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                            pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка1;
                            pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка2;
                        }
                        else
                        {
                            //Ход компьютера

                            cc = 0;
                            for (int i = 0; i < 20; i++)
                            {
                                if (pictures[i].Visible == true)
                                    cc++;
                            }

                            int OnTheTable = cc;
                            int RivalHave = sum1;
                            int CompHave;

                            if ((OnTheTable + RivalHave) % 2 == 0)
                            {
                                CompHave = 1;
                            }
                            else CompHave = 2;

                            

                            int raz = OnTheTable - 1;
                            int ct = 1;
                            bool ZeroOrNot = false;
                            int memory = 0;
                          



                            while ((raz >= 0) && (ct <= 4))
                            {
                                if (ZeroOrNot == false)
                                {
                                    memory = raz;
                                }
                                                              

                                if ((SG[(CompHave + ct) % 2, raz] == 0) && (ZeroOrNot == false))
                                {
                                    ZeroOrNot = true;
                                }


                                ct++;
                                raz--;
                            }

                            if (ZeroOrNot == false)
                            {
                                memory = OnTheTable - 1;
                            }
                            

                            for (int i = memory; i < OnTheTable; i++)
                            {
                                pictures[i].Visible = false;
                            }
                            sum2 = sum2 + (OnTheTable - memory);
                            label3.Text = Convert.ToString(sum2);

                            ForHr2 = 1;
                            timer2.Enabled = true;
                            pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_гиф;

                            cc = 0;
                            for (int i = 0; i < 20; i++)
                            {
                                if (pictures[i].Visible == true)
                                    cc++;
                            }

                            //button49.Visible = true;
                            //button49.Enabled = true;


                            //////
                            #region

                            int cc2 = 0;
                            for (int i = 0; i < 20; i++)
                            {
                                if (pictures[i].Visible == true)
                                    cc2++;
                            }

                            int OnTheTable2 = cc2;
                            int RivalHave2 = sum2;
                            int CompHave2;

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

                            int raz2 = OnTheTable2 - 1;
                            int ct2 = 1;
                            bool ZeroOrNot2 = false;
                            int memory2 = 0;
                            int memoryForRowNumber2 = 0, memoryForRowNumber22 = 0;    //
                            bool flagForRowNumber2 = false;                          //



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
                                    memoryForRowNumber22 = (CompHave2 + ct2) % 2;
                                }

                                if (flagForRowNumber2 == false)
                                {
                                    memoryForRowNumber2 = (CompHave2 + ct2) % 2;
                                    flagForRowNumber2 = true;
                                }

                                ct2++;
                                raz2--;
                            }

                            #endregion
                            ////////

                            if (cc == 0)
                            {
                                button8.Visible = true;
                                button9.Visible = true;
                                button7.Visible = true;
                                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_хотсыгрещё2;

                                if (sum1 % 2 == 0)
                                {
                                    button7.Text = name1;
                                }
                                else button7.Text = name2;

                                button52.Visible = false;

                                button5.Visible = false;
                                button6.Visible = false;
                                label2.Visible = false;
                                label3.Visible = false;
                                label4.Visible = false;
                                pictureBox2.Visible = false;
                                pictureBox23.Visible = false;

                                this.ClientSize = new System.Drawing.Size(620, 392);
                                this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                                pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка1;
                                pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка2;
                            }
                        }

                    }
                    #endregion
                }   
            }

            if ((r3 == true))
            {
                if (label1.Text == "1")
                {
                    #region

                    //Ход пользователя

                    for (int i = 0; i < 20; i++)
                    {
                        FirstRow[i].BackColor = Color.Ivory;
                        SecondRow[i].BackColor = Color.Ivory;
                        NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    }
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;


                    int k = 0;
                    string s = (sender as PictureBox).Name;
                    int nnum = 0;
                    bool f = false;
                    for (int i = 0; i < 20; i++)
                    {
                        if (f == false)
                            k++;
                        if (pictures[i].Name == s)
                        {
                            f = true;
                            nnum = i;
                        }

                    }

                    if (pictures[nnum].Image == images2[nnum])
                    {

                        int kc = 0;

                        for (int i = k - 1; i < 20; i++)
                        {
                            if (pictures[i].Visible == true)
                            {
                                pictures[i].Visible = false;
                                kc++;
                            }
                        }
                        sum2 = sum2 + kc;
                        label3.Text = Convert.ToString(sum2);

                        ForHr2 = 1;
                        timer2.Enabled = true;
                        pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_гиф;

                        

                        int cc = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (pictures[i].Visible == true)
                                cc++;
                        }

                        if (cc == 0)
                        {
                            button8.Visible = true;
                            button9.Visible = true;
                            button7.Visible = true;
                            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_хотсыгрещё2;

                            if (sum1 % 2 == 0)
                            {
                                button7.Text = name1;
                            }
                            else button7.Text = name2;

                            button5.Visible = false;
                            button6.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            pictureBox2.Visible = false;
                            pictureBox23.Visible = false;

                            button52.Visible = false;

                            this.ClientSize = new System.Drawing.Size(620, 392);
                            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                            (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                            pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка1;
                            pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка2;
                        }
                        else
                        {
                            //Ход компьютера

                            cc = 0;
                            for (int i = 0; i < 20; i++)
                            {
                                if (pictures[i].Visible == true)
                                    cc++;
                            }

                            int OnTheTable = cc;
                            int RivalHave = sum2;
                            int CompHave;

                            if ((OnTheTable + RivalHave) % 2 == 0)
                            {
                                CompHave = 1;
                            }
                            else CompHave = 2;

                            if (RivalHave % 2 == 0)                                 //
                            {
                                FirstRow[OnTheTable].BackColor = Color.Salmon;      //
                            }
                            else SecondRow[OnTheTable].BackColor = Color.Salmon;    //

                            int raz = OnTheTable - 1;
                            int ct = 1;
                            bool ZeroOrNot = false;
                            int memory = 0; int memoryForRowNumber = 0, memoryForRowNumber2 = 0;    //
                            bool flagForRowNumber = false;                          //



                            while ((raz >= 0) && (ct <= 4))
                            {
                                if (ZeroOrNot == false)
                                {
                                    memory = raz;
                                }

                                if ((CompHave + ct) % 2 == 0)                      //
                                {
                                    FirstRow[raz].BackColor = Color.LightGreen;    //
                                }
                                else SecondRow[raz].BackColor = Color.LightGreen;  //

                                if ((SG[(CompHave + ct) % 2, raz] == 0) && (ZeroOrNot == false))
                                {
                                    ZeroOrNot = true;
                                    memoryForRowNumber2 = (CompHave + ct) % 2;
                                }

                                if (flagForRowNumber == false)
                                {
                                    memoryForRowNumber = (CompHave + ct) % 2;
                                    flagForRowNumber = true;
                                }

                                ct++;
                                raz--;
                            }

                            if (ZeroOrNot == false)
                            {
                                memory = OnTheTable - 1;
                                if (memoryForRowNumber == 0)
                                    FirstRow[memory].BackColor = Color.LimeGreen;
                                else SecondRow[memory].BackColor = Color.LimeGreen;
                            }
                            else
                            {
                                if (memoryForRowNumber2 == 0)
                                    FirstRow[memory].BackColor = Color.LimeGreen;
                                else SecondRow[memory].BackColor = Color.LimeGreen;
                            }

                            for (int i = memory; i < OnTheTable; i++)
                            {
                                pictures[i].Visible = false;
                            }
                            sum1 = sum1 + (OnTheTable - memory);
                            label2.Text = Convert.ToString(sum1);

                            ForHr1 = 1;
                            timer1.Enabled = true;
                            pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.ич_гиф_vsPYD;

                            cc = 0;
                            for (int i = 0; i < 20; i++)
                            {
                                if (pictures[i].Visible == true)
                                    cc++;
                            }

                            if (cc == 0)
                            {
                                button8.Visible = true;
                                button9.Visible = true;
                                button7.Visible = true;
                                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_хотсыгрещё2;

                                if (sum1 % 2 == 0)
                                {
                                    button7.Text = name1;
                                }
                                else button7.Text = name2;

                                button52.Visible = false;

                                button5.Visible = false;
                                button6.Visible = false;
                                label2.Visible = false;
                                label3.Visible = false;
                                label4.Visible = false;
                                pictureBox2.Visible = false;
                                pictureBox23.Visible = false;

                                this.ClientSize = new System.Drawing.Size(620, 392);
                                this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                                pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка1;
                                pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка2;
                            }
                        }

                    }
                    #endregion
                }

                if (label1.Text == "2")
                {
                    #region

                    //Ход пользователя

                    for (int i = 0; i < 20; i++)
                    {
                        FirstRow[i].BackColor = Color.Ivory;
                        SecondRow[i].BackColor = Color.Ivory;
                        NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    }
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;


                    int k = 0;
                    string s = (sender as PictureBox).Name;
                    int nnum = 0;
                    bool f = false;
                    for (int i = 0; i < 20; i++)
                    {
                        if (f == false)
                            k++;
                        if (pictures[i].Name == s)
                        {
                            f = true;
                            nnum = i;
                        }

                    }

                    if (pictures[nnum].Image == images2[nnum])
                    {

                        int kc = 0;

                        for (int i = k - 1; i < 20; i++)
                        {
                            if (pictures[i].Visible == true)
                            {
                                pictures[i].Visible = false;
                                kc++;
                            }
                        }
                        sum2 = sum2 + kc;
                        label3.Text = Convert.ToString(sum2);

                        ForHr2 = 1;
                        timer2.Enabled = true;
                        pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_гиф;



                        int cc = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (pictures[i].Visible == true)
                                cc++;
                        }

                        if (cc == 0)
                        {
                            button8.Visible = true;
                            button9.Visible = true;
                            button7.Visible = true;
                            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_хотсыгрещё2;

                            if (sum1 % 2 == 0)
                            {
                                button7.Text = name1;
                            }
                            else button7.Text = name2;

                            button5.Visible = false;
                            button6.Visible = false;
                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            pictureBox2.Visible = false;
                            pictureBox23.Visible = false;

                            button52.Visible = false;

                            this.ClientSize = new System.Drawing.Size(620, 392);
                            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                            (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                            pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка1;
                            pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка2;
                        }
                        else
                        {
                            //Ход компьютера

                            cc = 0;
                            for (int i = 0; i < 20; i++)
                            {
                                if (pictures[i].Visible == true)
                                    cc++;
                            }

                            int OnTheTable = cc;
                            int RivalHave = sum2;
                            int CompHave;
                            int memory = 0;

                            if ((OnTheTable + RivalHave) % 2 == 0)
                            {
                                CompHave = 1;
                            }
                            else CompHave = 2;

                            

                            int raz = OnTheTable - 1;
                            int ct = 1;
                            bool ZeroOrNot = false;
                                                //



                            while ((raz >= 0) && (ct <= 4))
                            {
                                if (ZeroOrNot == false)
                                {
                                    memory = raz;
                                }

                                if ((SG[(CompHave + ct) % 2, raz] == 0) && (ZeroOrNot == false))
                                {
                                    ZeroOrNot = true;
                                   
                                }

                                ct++;
                                raz--;
                            }

                            if (ZeroOrNot == false)
                            {
                                memory = OnTheTable - 1;
                            }

                            for (int i = memory; i < OnTheTable; i++)
                            {
                                pictures[i].Visible = false;
                            }
                            sum1 = sum1 + (OnTheTable - memory);
                            label2.Text = Convert.ToString(sum1);

                            ForHr1 = 1;
                            timer1.Enabled = true;
                            pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.ич_гиф_vsPYD;

                            //////
                            #region

                            int cc3 = 0;
                            for (int i = 0; i < 20; i++)
                            {
                                if (pictures[i].Visible == true)
                                    cc3++;
                            }

                            int OnTheTable3 = cc3;
                            int RivalHave3 = sum1;
                            int CompHave3;

                            if ((OnTheTable3 + RivalHave3) % 2 == 0)
                            {
                                CompHave3 = 1;
                            }
                            else CompHave3 = 2;

                            if (RivalHave3 % 2 == 0)                                 //
                            {
                                FirstRow[OnTheTable3].BackColor = Color.Salmon;      //
                            }
                            else SecondRow[OnTheTable3].BackColor = Color.Salmon;    //

                            int raz3 = OnTheTable3 - 1;
                            int ct3 = 1;
                            bool ZeroOrNot3 = false;
                            int memory3 = 0;
                            int memoryForRowNumber3 = 0, memoryForRowNumber23 = 0;    //
                            bool flagForRowNumber3 = false;                          //



                            while ((raz3 >= 0) && (ct3 <= 4))
                            {
                                if (ZeroOrNot3 == false)
                                {
                                    memory3 = raz3;
                                }

                                if ((CompHave3 + ct3) % 2 == 0)                      //
                                {
                                    FirstRow[raz3].BackColor = Color.LightGreen;    //
                                }
                                else SecondRow[raz3].BackColor = Color.LightGreen;  //

                                if ((SG[(CompHave3 + ct3) % 2, raz3] == 0) && (ZeroOrNot3 == false))
                                {
                                    ZeroOrNot3 = true;
                                    memoryForRowNumber23 = (CompHave3 + ct3) % 2;
                                }

                                if (flagForRowNumber3 == false)
                                {
                                    memoryForRowNumber3 = (CompHave3 + ct3) % 2;
                                    flagForRowNumber3 = true;
                                }

                                ct3++;
                                raz3--;
                            }

                            #endregion
                            ////////

                            cc = 0;
                            for (int i = 0; i < 20; i++)
                            {
                                if (pictures[i].Visible == true)
                                    cc++;
                            }

                            if (cc == 0)
                            {
                                button8.Visible = true;
                                button9.Visible = true;
                                button7.Visible = true;
                                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_хотсыгрещё2;

                                if (sum1 % 2 == 0)
                                {
                                    button7.Text = name1;
                                }
                                else button7.Text = name2;

                                button52.Visible = false;

                                button5.Visible = false;
                                button6.Visible = false;
                                label2.Visible = false;
                                label3.Visible = false;
                                label4.Visible = false;
                                pictureBox2.Visible = false;
                                pictureBox23.Visible = false;

                                this.ClientSize = new System.Drawing.Size(620, 392);
                                this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                                pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка1;
                                pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка2;
                            }
                        }

                    }
                    #endregion
                }

               
            }
                
        }

        private void pictureBox22_MouseEnter(object sender, EventArgs e)
        {
            if ((r1 == true) || (r2 == true) || (r3 == true))
            {
                int k = 0;
                string s = (sender as PictureBox).Name;

                bool f = false;
                for (int i = 0; i < 20; i++)
                {
                    if (f == false)
                        k++;
                    if (pictures[i].Name == s)
                        f = true;

                }

                int c = 0;
                for (int i = 0; i < 20; i++)
                {
                    if (pictures[i].Visible == true)
                        c++;
                }
                

                int raz = c - temp;

                if ((k >= raz + 1) && (k <= c))
                {
                    for (int i = k - 1; i <= c - 1; i++)
                    {
                        pictures[i].Image = images2[i];
                    }
                }


            }
        }

        private void pictureBox22_MouseLeave(object sender, EventArgs e)
        {
            if ((r1 == true) || (r2 == true) || (r3 == true))
            {
                for (int i = 0; i < 20; i++)
                {
                    pictures[i].Image = images1[i];
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                FirstRow[i].Visible = true;
                SecondRow[i].Visible = true;
            }
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            for (int i = 0; i < 20; i++)
            {
                FirstRow[i].Visible = true;
                SecondRow[i].Visible = true;
            }
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фонн;

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ForHr1 = ForHr1 - 1;

            if (ForHr1 == 0)
            {
                timer1.Enabled = false;
                pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ForHr2 = ForHr2 - 1;

            if (ForHr2 == 0)
            {
                timer2.Enabled = false;
                pictureBox23.Image = global::WindowsFormsApplication1.Properties.Resources.хрюшка2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r1 = false;
            r2 = true;
            r3 = false;
            sum1 = 0;
            sum2 = 0;

            textBox3.Text = "";

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИП_введите_имя;

            textBox3.Visible = true;

            #region

            pictures.Add(pictureBox3);
            pictures.Add(pictureBox4);
            pictures.Add(pictureBox5);
            pictures.Add(pictureBox6);
            pictures.Add(pictureBox7);
            pictures.Add(pictureBox8);
            pictures.Add(pictureBox9);
            pictures.Add(pictureBox10);
            pictures.Add(pictureBox11);
            pictures.Add(pictureBox12);
            pictures.Add(pictureBox13);
            pictures.Add(pictureBox14);
            pictures.Add(pictureBox15);
            pictures.Add(pictureBox16);
            pictures.Add(pictureBox17);
            pictures.Add(pictureBox18);
            pictures.Add(pictureBox19);
            pictures.Add(pictureBox20);
            pictures.Add(pictureBox21);
            pictures.Add(pictureBox22);
            pictures.Add(pictureBox23);

            for (int i = 0; i < 20; i++)
            {
                images1.Add(global::WindowsFormsApplication1.Properties.Resources.монета1);
                images2.Add(global::WindowsFormsApplication1.Properties.Resources.монета2);
            }

            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            r1 = false;
            r2 = false;
            r3 = true;
            sum1 = 0;
            sum2 = 0;

            textBox3.Text = "";

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИП_введите_имя;

            textBox3.Visible = true;

            #region

            pictures.Add(pictureBox3);
            pictures.Add(pictureBox4);
            pictures.Add(pictureBox5);
            pictures.Add(pictureBox6);
            pictures.Add(pictureBox7);
            pictures.Add(pictureBox8);
            pictures.Add(pictureBox9);
            pictures.Add(pictureBox10);
            pictures.Add(pictureBox11);
            pictures.Add(pictureBox12);
            pictures.Add(pictureBox13);
            pictures.Add(pictureBox14);
            pictures.Add(pictureBox15);
            pictures.Add(pictureBox16);
            pictures.Add(pictureBox17);
            pictures.Add(pictureBox18);
            pictures.Add(pictureBox19);
            pictures.Add(pictureBox20);
            pictures.Add(pictureBox21);
            pictures.Add(pictureBox22);
            pictures.Add(pictureBox23);

            for (int i = 0; i < 20; i++)
            {
                images1.Add(global::WindowsFormsApplication1.Properties.Resources.монета1);
                images2.Add(global::WindowsFormsApplication1.Properties.Resources.монета2);
            }

            #endregion
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                #region

                if (countbut == 0)
                {
                    if ((r2 == true) || (r3 == true))
                    {
                        pictureBox24.Visible = true;

                        this.ClientSize = new System.Drawing.Size(775, 570);
                        this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                        (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                        //pictureBox1.Size = new System.Drawing.Size(1110, 350);
                        countbut = 1;
                    }

                }
                else
                {
                    if ((r2 == true) || (r3 == true))
                    {
                        pictureBox24.Visible = false;

                        this.ClientSize = new System.Drawing.Size(775, 392);
                        this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                        (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                        // pictureBox1.Size = new System.Drawing.Size(1110, 350);
                        countbut = 0;
                    }
                }

                #endregion
            }

            if (label1.Text == "2")
            {
                #region

                if (countbut == 0)
                {
                    if ((r2 == true) || (r3 == true))
                    {
                        pictureBox24.Visible = true;

                        this.ClientSize = new System.Drawing.Size(775, 510);
                        this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                        (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                        //pictureBox1.Size = new System.Drawing.Size(1110, 350);
                        countbut = 1;
                    }

                }
                else
                {
                    if ((r2 == true) || (r3 == true))
                    {
                        pictureBox24.Visible = false;

                        this.ClientSize = new System.Drawing.Size(775, 392);
                        this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                        (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                        // pictureBox1.Size = new System.Drawing.Size(1110, 350);
                        countbut = 0;
                    }
                }

                #endregion
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            

            int iRed = 0, iLime, jLime;
            int[,] ijGreen = new int[2, 3];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    ijGreen[i, j] = -1;

            int OnTheTable = 0;
            int RivalHave = 0;
            int CompHave;

            int raz = 0;
            int ct = 1;
            bool ZeroOrNot = false;
            int memory = 0;
            int memoryForRowNumber, memoryForRowNumber2 = 0;    //
            bool flagForRowNumber = false;                          //

            if (button49.Text == "Объяснить по шагам")
            {
                ForExplanations = 0;
                CountForTries = 0;
                COUNT = 2; jRed = 0;
            }
            


            if (ForExplanations == 0)
            {               
                for (int i = 0; i < 20; i++)
                {
                    if (FirstRow[i].BackColor == Color.Salmon)
                    {
                        iRed = 0;
                        jRed = i;
                    }
                    if (SecondRow[i].BackColor == Color.Salmon)
                    {
                        iRed = 1;
                        jRed = i;
                    }
                    if (FirstRow[i].BackColor == Color.LimeGreen)
                    {
                        iLime = 0;
                        jLime = i;
                    }
                    if (SecondRow[i].BackColor == Color.LimeGreen)
                    {
                        iLime = 1;
                        jLime = i;
                    }
                }
                int cj = 0;
                for (int i = 0; i < 20; i++)
                {
                    if (FirstRow[i].BackColor == Color.LightGreen)
                    {
                        ijGreen[0, cj] = 0;
                        ijGreen[1, cj] = i;
                        cj++;
                        COUNT++;
                    }
                    if (SecondRow[i].BackColor == Color.LightGreen)
                    {
                        ijGreen[0, cj] = 1;
                        ijGreen[1, cj] = i;
                        cj++;
                        COUNT++;
                    }
                }

                #region

               OnTheTable = jRed;
                 RivalHave = iRed;
                 
                raz = OnTheTable - 1;

                if ((OnTheTable + RivalHave) % 2 == 0)
                {
                    CompHave = 1;
                }
                else CompHave = 2;                

                

                
                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < 4; j++)
                        Tries[i, j] = -1;

               
                while ((raz >= 0) && (ct <= 4))
                {
                    if (ZeroOrNot == false)
                    {
                        memory = raz;
                    }

                    Tries[0, CountForTries] = (CompHave + ct) % 2;
                    Tries[1, CountForTries] = raz;

                    if ((SG[(CompHave + ct) % 2, raz] == 0) && (ZeroOrNot == false))
                    {
                        ZeroOrNot = true;
                        memoryForRowNumber2 = (CompHave + ct) % 2;
                    }

                    if (flagForRowNumber == false)
                    {
                        memoryForRowNumber = (CompHave + ct) % 2;
                        flagForRowNumber = true;
                    }
                    CountForTries++;
                    ct++;
                    raz--;
                }

                if (ZeroOrNot == false)
                {
                    memory = OnTheTable - 1;
                }
                

                #endregion

                for (int i = 0; i < 20; i++)
                {
                    pictures[i].Enabled = false;
                    FirstRow[i].BackColor = Color.Ivory;
                    SecondRow[i].BackColor = Color.Ivory;
                }

                button49.Text = "";
                button49.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_стрелка;
                ForExplanations++;
                richTextBox1.Visible = true;

                //Начало объяснений

                NumbersOfMass[jRed].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                if (iRed == 0)
                {
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                    FirstRow[jRed].BackColor = Color.Salmon;

                    if (jRed % 2 == 0)
                    {
                        richTextBox1.Text = richTextBox1.Text + "Красным цветом выделена ячкейка(элемент массива SG), в которой оказался компьютер. На момент хода компьютера на столе было " +
                        Convert.ToString(jRed) + " монет. У соперника (у вас) было четное количество монет. Следовательно у компьютера количество монет было НЕЧЕТНОЕ. ";
                        parity = false;
                    }
                    else
                    {
                        richTextBox1.Text = richTextBox1.Text + "Красным цветом выделена ячкейка(элемент массива SG), в которой оказался компьютер. На момент хода компьютера на столе было " +
                        Convert.ToString(jRed) + " монет. У соперника (у вас) было четное количество монет. Следовательно у компьютера количество монет было ЧЕТНОЕ. ";
                        parity = true;
                    }

                }
                else
                {
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_фон_лэйблов;
                    SecondRow[jRed].BackColor = Color.Salmon;
                    if (jRed % 2 == 0)
                    {
                        richTextBox1.Text = richTextBox1.Text + "Красным цветом выделена ячкейка(элемент массива SG), в которой оказался компьютер. На момент хода компьютера на столе было " +
                        Convert.ToString(jRed) + " монет. У соперника (у вас) было нечетное количество монет. Следовательно у компьютера количество монет было ЧЕТНОЕ. ";
                        parity = true;
                    }
                    else
                    {
                        richTextBox1.Text = richTextBox1.Text + "Красным цветом выделена ячкейка(элемент массива SG), в которой оказался компьютер. На момент хода компьютера на столе было " +
                        Convert.ToString(jRed) + " монет. У соперника (у вас) было нечетное количество монет. Следовательно у компьютера количество монет было НЕЧЕТНОЕ. ";
                        parity = false;
                    }
                }                
            }
            else if ((ForExplanations == 1) && (ForExplanations <= COUNT))
            {
                richTextBox1.Text = "";

                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                NumbersOfMass[jRed].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;

                //richTextBox1.ForeColor = Color.Red;

                NumbersOfMass[Tries[1, ForExplanations - 1]].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_светлый;
                if (Tries[0, ForExplanations - 1] == 0)
                {
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_светлый;
                    FirstRow[Tries[1, ForExplanations - 1]].BackColor = Color.LightGreen;


                    if (parity == false)
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 1 монету (на столе останется " +
                            Convert.ToString(jRed - 1) + " монет), количество монет у компьютера станет  ЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = true;

                        
                    }
                    else
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 1 монету (на столе останется " +
                            Convert.ToString(jRed - 1) + " монет), количество монет у компьютера станет  НЕЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = false;
                    }

                }
                else
                {
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_светлый;
                    SecondRow[Tries[1, ForExplanations - 1]].BackColor = Color.LightGreen;

                    if (parity == false)
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 1 монету (на столе останется " +
                            Convert.ToString(jRed - 1) + " монет), количество монет у компьютера станет  ЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = true;
                    }
                    else
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 1 монету (на столе останется " +
                            Convert.ToString(jRed - 1) + " монет), количество монет у компьютера станет  НЕЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = false;
                    }
                }

                ForExplanations++;

            }
            else if (ForExplanations == COUNT)
            {
                richTextBox1.Text = "";

                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
               // NumbersOfMass[jRed - COUNT].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                for (int i = 0; i < 20; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                   // pictures[i].Enabled = true;
                }


                int I = 0, J = 0;
                bool mb = false;

                for (int j = 0; j < 4; j++)
                {
                    if ((mb == false) && (SG[Tries[0, j], Tries[1, j]] == 0))
                    {
                        mb = true;
                        I = Tries[0, j];
                        J = Tries[1, j];
                    }
                }

                if (mb == false)
                {
                    I = Tries[0, 0];
                    J = Tries[1, 0];
                }


                /////////////
                if (I == 0)
                {
                    FirstRow[J].BackColor = Color.LimeGreen;
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_темный;
                    NumbersOfMass[J].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_темный;
                }
                else
                {
                    SecondRow[J].BackColor = Color.LimeGreen;
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_темный;
                    NumbersOfMass[J].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_темный;
                }
                /////////////

                if (SG[I, J] == 0)
                {
                    richTextBox1.Text = "Темно-зеленым цветом выделена ячейка - ход компьютера. Взяв со стола " +
                        Convert.ToString(jRed - J) + " монеты, компьютер отправляет соперника в нулевую позицию, которая " +
                        " для компьютера является выигрывающей. ";
                }
                else
                {
                    richTextBox1.Text = "Темно-зеленым цветом выделена ячейка - ход компьютера. Компьютер находится в " +
                        "проигрышной позиции, поэтому делает ход случайным образом. В данном случае компьютер берет со " +
                        "стола " + Convert.ToString(jRed - J) + " монету.";
                }

                ForExplanations++;

                button49.Image = null;
                button49.Text = "Завершить";

            }
            else if ((ForExplanations == 2) && (ForExplanations <= COUNT))
            {
                richTextBox1.Text = "";

                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                NumbersOfMass[jRed-1].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;

               

                NumbersOfMass[Tries[1, ForExplanations - 1]].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_светлый;
                if (Tries[0, ForExplanations - 1] == 0)
                {
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_светлый;
                    FirstRow[Tries[1, ForExplanations - 1]].BackColor = Color.LightGreen;


                    if (parity == false)
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 2 монеты (на столе останется " +
                            Convert.ToString(jRed - 2) + " монет), количество монет у компьютера станет  ЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = true;


                    }
                    else
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 2 монеты (на столе останется " +
                            Convert.ToString(jRed - 2) + " монет), количество монет у компьютера станет  НЕЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = false;
                    }

                }
                else
                {
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_светлый;
                    SecondRow[Tries[1, ForExplanations - 1]].BackColor = Color.LightGreen;

                    if (parity == false)
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 2 монеты (на столе останется " +
                            Convert.ToString(jRed - 2) + " монет), количество монет у компьютера станет  ЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = true;
                    }
                    else
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 2 монеты (на столе останется " +
                            Convert.ToString(jRed - 2) + " монет), количество монет у компьютера станет  НЕЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = false;
                    }
                }

                ForExplanations++;
            }
            else if ((ForExplanations == 3) && (ForExplanations <= COUNT))
            {
                richTextBox1.Text = "";

                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                NumbersOfMass[jRed - 2].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;



                NumbersOfMass[Tries[1, ForExplanations - 1]].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_светлый;
                if (Tries[0, ForExplanations - 1] == 0)
                {
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_светлый;
                    FirstRow[Tries[1, ForExplanations - 1]].BackColor = Color.LightGreen;


                    if (parity == false)
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 3 монеты (на столе останется " +
                            Convert.ToString(jRed - 3) + " монет), количество монет у компьютера станет  ЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = true;


                    }
                    else
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 3 монеты (на столе останется " +
                            Convert.ToString(jRed - 3) + " монет), количество монет у компьютера станет  НЕЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = false;
                    }

                }
                else
                {
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_светлый;
                    SecondRow[Tries[1, ForExplanations - 1]].BackColor = Color.LightGreen;

                    if (parity == false)
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 3 монеты (на столе останется " +
                            Convert.ToString(jRed - 3) + " монет), количество монет у компьютера станет  ЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = true;
                    }
                    else
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 3 монеты (на столе останется " +
                            Convert.ToString(jRed - 3) + " монет), количество монет у компьютера станет  НЕЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = false;
                    }
                }

                ForExplanations++;
            }
            else if ((ForExplanations == 4) && (ForExplanations <= COUNT))
            {
                richTextBox1.Text = "";

                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                NumbersOfMass[jRed - 3].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;



                NumbersOfMass[Tries[1, ForExplanations - 1]].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_светлый;
                if (Tries[0, ForExplanations - 1] == 0)
                {
                    label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_светлый;
                    FirstRow[Tries[1, ForExplanations - 1]].BackColor = Color.LightGreen;


                    if (parity == false)
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 4 монеты (на столе останется " +
                            Convert.ToString(jRed - 4) + " монет), количество монет у компьютера станет  ЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = true;


                    }
                    else
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 4 монеты (на столе останется " +
                            Convert.ToString(jRed - 4) + " монет), количество монет у компьютера станет  НЕЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = false;
                    }

                }
                else
                {
                    label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_зеленый_светлый;
                    SecondRow[Tries[1, ForExplanations - 1]].BackColor = Color.LightGreen;

                    if (parity == false)
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 4 монеты (на столе останется " +
                            Convert.ToString(jRed - 4) + " монет), количество монет у компьютера станет  ЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = true;
                    }
                    else
                    {
                        richTextBox1.Text = richTextBox1.Text + "Если Компьютер возьмет со стола 4 монеты (на столе останется " +
                            Convert.ToString(jRed - 4) + " монет), количество монет у компьютера станет  НЕЧЕТНЫМ. Соответствующая " +
                            " позиция выделена зеленым цветом.";
                        parity = false;
                    }
                }

                ForExplanations++;
            }
            
            else if (button49.Text == "Завершить")
            {
                label5.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                label6.Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                for (int i = 0; i < 20; i++)
                {
                    NumbersOfMass[i].Image = global::WindowsFormsApplication1.Properties.Resources.ИЧ_цвет_хрю;
                    pictures[i].Enabled = true;
                }
                richTextBox1.Text = "";
                richTextBox1.Visible = false;
                button49.Text = "Объяснить по шагам";

            }
        }




    }
}
