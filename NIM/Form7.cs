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
    public partial class Form7 : Form
    {
        List<PictureBox> pictures = new List<PictureBox>();
        List<Image> images1 = new List<Image>();
        List<Image> images2 = new List<Image>();
        List<PictureBox> fires = new List<PictureBox>();
        List<Image> ForFires1 = new List<Image>();
        List<Image> ForFires2 = new List<Image>();
        List<Button> sgmass = new List<Button>();
        List<PictureBox> visual2 = new List<PictureBox>();
        List<PictureBox> visual3 = new List<PictureBox>();
        List<PictureBox> visual4 = new List<PictureBox>();



        string name1, name2, For3part;
        bool r1 = false, r2 = false, r3 = false;
        int count = 1, temp, countbut, rd, countH1;
        int[] SG = new int[34];
        bool[] HelpForMass = new bool[6];

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //label2.Parent = pictureBox35;
            //label2.BackColor = Color.Transparent;
            //label2.Text = "123";
            //label2.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            textBox1.Visible = true;
            textBox3.Visible = true;
            button4.Visible = true;

            r1 = true;
            r2 = false;
            r3 = false;

            #region

            pictures.Add(pictureBox2);
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
            pictures.Add(pictureBox24);
            pictures.Add(pictureBox25);
            pictures.Add(pictureBox26);
            pictures.Add(pictureBox27);
            pictures.Add(pictureBox28);
            pictures.Add(pictureBox29);
            pictures.Add(pictureBox30);
            pictures.Add(pictureBox31);
            pictures.Add(pictureBox32);
            pictures.Add(pictureBox33);
            pictures.Add(pictureBox34);

            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С1);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С2);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С3);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С4);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С5);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С6);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С7);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С8);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С9);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С10);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С11);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С12);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С13);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С14);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С15);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С16);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С17);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С18);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С19);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С20);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С21);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С22);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С23);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С24);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С25);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С26);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С27);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С28);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С29);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С30);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С31);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С32);
            images1.Add(global::WindowsFormsApplication1.Properties.Resources.С33);

            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ1);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ2);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ3);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ4);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ5);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ6);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ7);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ8);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ9);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ10);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ11);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ12);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ13);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ14);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ15);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ16);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ17);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ18);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ19);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ20);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ21);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ22);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ23);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ24);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ25);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ26);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ27);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ28);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ29);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ30);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ31);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ32);
            images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ33);

            #endregion

            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБ_имена_ч_ч;
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            if ((textBox3.Text != "") && (textBox1.Text != "") && (textBox1.Text != textBox3.Text))
            {
                if (r1 == true)
                {
                    #region
                    button5.BackColor = Color.WhiteSmoke;
                    button6.BackColor = Color.WhiteSmoke;

                    textBox1.Visible = false;
                    textBox3.Visible = false;
                    button4.Visible = false;

                    name1 = textBox3.Text;
                    name2 = textBox1.Text;

                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБоснова;

                    Random rand = new Random();
                    rd = rand.Next(23) + 11;

                    //rd = 33;
                    //сколько спичек всего
                    #region

                    for (int i = 0; i < 33; i++)
                    {
                        if (i < rd)
                        {
                            pictures[i].Visible = true;
                            pictures[i].Image = images1[i];
                        }
                    }

                    #endregion

                    button5.Visible = true;
                    button5.Text = name1;

                    button6.Visible = true;
                    button6.Text = name2;

                    button7.Visible = true;

                    Random rand1 = new Random();
                    
                    temp = rand1.Next(4) + 2;

                    string ss = Convert.ToString(temp);
                    button7.Text = "Можно брать от 1 до " + ss + " спичек";

                    button5.BackColor = Color.PaleGreen;
                    #endregion
                }

            }
            if (textBox2.Text != "")
            {
                if (r2 == true)
                {
                    if (label2.Text == "1")
                    {
                        #region
                        for (int i = 0; i < 34; i++)
                        {
                            fires[i].Image = ForFires2[i];
                            fires[i].Visible = false;
                            sgmass[i].Text = "";
                            sgmass[i].BackColor = Color.Gainsboro;
                        }

                        button5.BackColor = Color.PaleGreen;
                        button6.BackColor = Color.WhiteSmoke;

                        button11.Visible = true;
                        countbut = 0;

                        textBox2.Visible = false;
                        button4.Visible = false;

                        name1 = textBox2.Text;
                        name2 = "Компьютер";

                        pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБоснова;

                        Random rand = new Random();
                        rd = rand.Next(23) + 11;

                        for (int i = 0; i <= rd; i++)
                        {
                            fires[i].Visible = true;
                        }

                        //rd = 7;
                        //сколько спичек всего
                        #region

                        for (int i = 0; i < 33; i++)
                        {
                            if (i < rd)
                            {
                                pictures[i].Visible = true;
                                pictures[i].Image = images1[i];
                            }
                        }

                        #endregion

                        button5.Visible = true;
                        button5.Text = name1;

                        button6.Visible = true;
                        button6.Text = name2;

                        button7.Visible = true;

                        Random rand1 = new Random();

                        temp = rand1.Next(4) + 2;
                        //temp = 5;


                        string ss = Convert.ToString(temp);
                        button7.Text = "Можно брать от 1 до " + ss + " спичек";

                        button5.BackColor = Color.PaleGreen;

                        //Заполнение массива
                        #region



                        SG[0] = temp + 1;

                        for (int i = 1; i <= temp + 1; i++)
                        {
                            SG[i] = i-1;
                        }


                        for (int i = temp + 2; i <= rd; i++)
                        {
                            for (int j = 0; j <= temp; j++)
                                HelpForMass[j] = false;

                            for (int j = 1; j <= temp; j++)
                            {
                                HelpForMass[SG[i - j]] = true;
                            }

                            for (int j = temp; j >= 0; j--)
                            {
                                if (HelpForMass[j] == false)
                                    SG[i] = j;
                            }
                        }

                        #endregion
                        #endregion
                    }

                    if (label2.Text == "2")
                    {
                        #region

                        for (int i = 0; i < 34; i++)
                        {
                            fires[i].Image = ForFires2[i];
                            fires[i].Visible = false;
                            sgmass[i].Text = "";
                            sgmass[i].BackColor = Color.Gainsboro;
                        }

                        button5.BackColor = Color.PaleGreen;
                        button6.BackColor = Color.WhiteSmoke;

                        button11.Visible = true;
                        countbut = 0;

                        textBox2.Visible = false;
                        button4.Visible = false;

                        name1 = textBox2.Text;
                        name2 = "Компьютер";

                        pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБоснова;

                        Random rand = new Random();
                        rd = rand.Next(23) + 11;

                        for (int i = 0; i <= rd; i++)
                        {
                            fires[i].Visible = true;
                        }

                        //rd = 33;
                        //сколько спичек всего
                        #region

                        for (int i = 0; i < 33; i++)
                        {
                            if (i < rd)
                            {
                                pictures[i].Visible = true;
                                pictures[i].Image = images1[i];
                            }
                        }

                        #endregion

                        button5.Visible = true;
                        button5.Text = name1;

                        button6.Visible = true;
                        button6.Text = name2;

                        button7.Visible = true;

                        Random rand1 = new Random();

                        temp = rand1.Next(4) + 2;

                        string ss = Convert.ToString(temp);
                        button7.Text = "Можно брать от 1 до " + ss + " спичек";

                        button5.BackColor = Color.PaleGreen;

                        //Заполнение массива
                        #region



                        SG[0] = temp + 1;

                        for (int i = 1; i <= temp + 1; i++)
                        {
                            SG[i] = i - 1;
                        }


                        for (int i = temp + 2; i <= rd; i++)
                        {
                            for (int j = 0; j <= temp; j++)
                                HelpForMass[j] = false;

                            for (int j = 1; j <= temp; j++)
                            {
                                HelpForMass[SG[i - j]] = true;
                            }

                            for (int j = temp; j >= 0; j--)
                            {
                                if (HelpForMass[j] == false)
                                    SG[i] = j;
                            }
                        }

                        #endregion

                        for (int i = 0; i <= rd; i++)
                        {
                            sgmass[i].Text = Convert.ToString(SG[i]);
                        }

                        int cc = 0;
                        for (int i = 0; i < 33; i++)
                        {
                            if (pictures[i].Visible == true)
                                cc++;
                        }

                        sgmass[cc].BackColor = Color.DeepSkyBlue;


                        for (int i = cc - 1; i > cc - 1 - temp; i--)
                        {
                            fires[i].Image = ForFires1[i];
                        }
                        

                        #endregion
                    }

                }
                if (r3 == true)
                {
                    if (label2.Text == "1")
                    {
                        #region
                        for (int i = 0; i < 34; i++)
                        {
                            fires[i].Image = ForFires2[i];
                            fires[i].Visible = false;
                            sgmass[i].Text = "";
                            sgmass[i].BackColor = Color.Gainsboro;
                        }

                        button6.BackColor = Color.PaleGreen;
                        button5.BackColor = Color.WhiteSmoke;

                        button11.Visible = true;
                        countbut = 0;

                        textBox2.Visible = false;
                        button4.Visible = false;

                        name2 = textBox2.Text;
                        name1 = "Компьютер";

                        pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБоснова;

                        Random rand = new Random();
                        rd = rand.Next(23) + 11;

                        for (int i = 0; i <= rd; i++)
                        {
                            fires[i].Visible = true;
                        }

                        //rd = 33;
                        //сколько спичек всего
                        #region

                        for (int i = 0; i < 33; i++)
                        {
                            if (i < rd)
                            {
                                pictures[i].Visible = true;
                                pictures[i].Image = images1[i];
                            }
                        }

                        #endregion

                        button5.Visible = true;
                        button5.Text = name1;

                        button6.Visible = true;
                        button6.Text = name2;

                        button7.Visible = true;

                        Random rand1 = new Random();

                        temp = rand1.Next(4) + 2;

                        string ss = Convert.ToString(temp);
                        button7.Text = "Можно брать от 1 до " + ss + " спичек";

                        //Заполнение массива
                        #region



                        SG[0] = temp + 1;

                        for (int i = 1; i <= temp + 1; i++)
                        {
                            SG[i] = i - 1;
                        }


                        for (int i = temp + 2; i <= rd; i++)
                        {
                            for (int j = 0; j <= temp; j++)
                                HelpForMass[j] = false;

                            for (int j = 1; j <= temp; j++)
                            {
                                HelpForMass[SG[i - j]] = true;
                            }

                            for (int j = temp; j >= 0; j--)
                            {
                                if (HelpForMass[j] == false)
                                    SG[i] = j;
                            }
                        }

                        #endregion

                        for (int i = 0; i <= rd; i++)
                        {
                            sgmass[i].Text = Convert.ToString(SG[i]);
                        }

                        int cc = 0;
                        for (int i = 0; i < 33; i++)
                        {
                            if (pictures[i].Visible == true)
                                cc++;
                        }

                        sgmass[cc].BackColor = Color.Salmon;

                        if (SG[cc] == 0)
                        {
                            pictures[cc - 1].Visible = false;
                            sgmass[cc - 1].BackColor = Color.LightGreen;

                            for (int i = cc - 1; i > cc - 1 - temp; i--)
                            {
                                fires[i].Image = ForFires1[i];
                            }
                        }
                        else
                        {
                            int num = -1;
                            for (int i = 1; i <= temp; i++)
                            {
                                if ((cc - i >= 0) && (SG[cc - i] == 0))
                                {
                                    num = i;
                                    sgmass[cc - i].BackColor = Color.LightGreen;
                                }
                            }
                            if (cc - 1 - temp >= 0)
                            {
                                for (int i = cc - 1; i > cc - 1 - temp; i--)
                                {
                                    fires[i].Image = ForFires1[i];
                                }
                            }

                            for (int i = cc - 1; i > cc - 1 - num; i--)
                            {
                                pictures[i].Visible = false;

                            }
                        }
                        #endregion
                    }

                    if (label2.Text == "2")
                    {
                        #region
                        for (int i = 0; i < 34; i++)
                        {
                            fires[i].Image = ForFires2[i];
                            fires[i].Visible = false;
                            sgmass[i].Text = "";
                            sgmass[i].BackColor = Color.Gainsboro;
                        }

                        button6.BackColor = Color.PaleGreen;
                        button5.BackColor = Color.WhiteSmoke;

                        button11.Visible = true;
                        countbut = 0;

                        textBox2.Visible = false;
                        button4.Visible = false;

                        name2 = textBox2.Text;
                        name1 = "Компьютер";

                        pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБоснова;

                        Random rand = new Random();
                        rd = rand.Next(23) + 11;

                        for (int i = 0; i <= rd; i++)
                        {
                            fires[i].Visible = true;
                        }

                        //rd = 33;
                        //сколько спичек всего
                        #region

                        for (int i = 0; i < 33; i++)
                        {
                            if (i < rd)
                            {
                                pictures[i].Visible = true;
                                pictures[i].Image = images1[i];
                            }
                        }

                        #endregion

                        button5.Visible = true;
                        button5.Text = name1;

                        button6.Visible = true;
                        button6.Text = name2;

                        button7.Visible = true;

                        Random rand1 = new Random();

                        temp = rand1.Next(4) + 2;

                        string ss = Convert.ToString(temp);
                        button7.Text = "Можно брать от 1 до " + ss + " спичек";

                        //Заполнение массива
                        #region



                        SG[0] = temp + 1;

                        for (int i = 1; i <= temp + 1; i++)
                        {
                            SG[i] = i - 1;
                        }


                        for (int i = temp + 2; i <= rd; i++)
                        {
                            for (int j = 0; j <= temp; j++)
                                HelpForMass[j] = false;

                            for (int j = 1; j <= temp; j++)
                            {
                                HelpForMass[SG[i - j]] = true;
                            }

                            for (int j = temp; j >= 0; j--)
                            {
                                if (HelpForMass[j] == false)
                                    SG[i] = j;
                            }
                        }

                        #endregion

                        for (int i = 0; i <= rd; i++)
                        {
                            sgmass[i].Text = Convert.ToString(SG[i]);
                        }

                        int cc = 0;
                        for (int i = 0; i < 33; i++)
                        {
                            if (pictures[i].Visible == true)
                                cc++;
                        }

                        

                        if (SG[cc] == 0)
                        {
                            pictures[cc - 1].Visible = false;
                        }
                        else
                        {
                            int num = -1;
                            for (int i = 1; i <= temp; i++)
                            {
                                if ((cc - i >= 0) && (SG[cc - i] == 0))
                                {
                                    num = i;
                                }
                            }
                            

                            for (int i = cc - 1; i > cc - 1 - num; i--)
                            {
                                pictures[i].Visible = false;

                            }
                        }

                        for (int i = 0; i <= rd; i++)
                        {
                            sgmass[i].Text = Convert.ToString(SG[i]);
                        }

                        int c = 0;
                        for (int i = 0; i < 33; i++)
                        {
                            if (pictures[i].Visible == true)
                                c++;
                        }

                        sgmass[c].BackColor = Color.DeepSkyBlue;


                        for (int i = c - 1; i > c - 1 - temp; i--)
                        {
                            fires[i].Image = ForFires1[i];
                        }

                        #endregion
                    }
                }
                if (label2.Text == "3")
                {
                    #region

                    #region

                    pictures.Add(pictureBox2);
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
                    pictures.Add(pictureBox24);
                    pictures.Add(pictureBox25);
                    pictures.Add(pictureBox26);
                    pictures.Add(pictureBox27);
                    pictures.Add(pictureBox28);
                    pictures.Add(pictureBox29);
                    pictures.Add(pictureBox30);
                    pictures.Add(pictureBox31);
                    pictures.Add(pictureBox32);
                    pictures.Add(pictureBox33);
                    pictures.Add(pictureBox34);

                    fires.Add(pictureBox36);
                    fires.Add(pictureBox37);
                    fires.Add(pictureBox38);
                    fires.Add(pictureBox39);
                    fires.Add(pictureBox40);
                    fires.Add(pictureBox41);
                    fires.Add(pictureBox42);
                    fires.Add(pictureBox43);
                    fires.Add(pictureBox44);
                    fires.Add(pictureBox45);
                    fires.Add(pictureBox46);
                    fires.Add(pictureBox47);
                    fires.Add(pictureBox48);
                    fires.Add(pictureBox49);
                    fires.Add(pictureBox50);
                    fires.Add(pictureBox51);
                    fires.Add(pictureBox52);
                    fires.Add(pictureBox53);
                    fires.Add(pictureBox54);
                    fires.Add(pictureBox55);
                    fires.Add(pictureBox56);
                    fires.Add(pictureBox57);
                    fires.Add(pictureBox58);
                    fires.Add(pictureBox59);
                    fires.Add(pictureBox60);
                    fires.Add(pictureBox61);
                    fires.Add(pictureBox62);
                    fires.Add(pictureBox63);
                    fires.Add(pictureBox64);
                    fires.Add(pictureBox65);
                    fires.Add(pictureBox66);
                    fires.Add(pictureBox67);
                    fires.Add(pictureBox68);
                    fires.Add(pictureBox69);

                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С1);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С2);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С3);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С4);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С5);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С6);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С7);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С8);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С9);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С10);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С11);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С12);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С13);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С14);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С15);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С16);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С17);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С18);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С19);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С20);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С21);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С22);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С23);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С24);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С25);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С26);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С27);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С28);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С29);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С30);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С31);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С32);
                    images1.Add(global::WindowsFormsApplication1.Properties.Resources.С33);

                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ1);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ2);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ3);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ4);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ5);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ6);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ7);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ8);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ9);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ10);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ11);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ12);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ13);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ14);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ15);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ16);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ17);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ18);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ19);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ20);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ21);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ22);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ23);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ24);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ25);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ26);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ27);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ28);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ29);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ30);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ31);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ32);
                    images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ33);

                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_0_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_1_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_2_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_3_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_4_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_5_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_6_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_7_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_8_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_9_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_10_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_11_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_12_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_13_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_14_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_15_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_16_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_17_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_18_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_19_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_20_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_21_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_22_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_23_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_24_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_25_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_26_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_27_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_28_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_29_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_30_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_31_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_32_вид1);
                    ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_33_вид1);

                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_0_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_1_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_2_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_3_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_4_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_5_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_6_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_7_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_8_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_9_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_10_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_11_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_12_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_13_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_14_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_15_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_16_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_17_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_18_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_19_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_20_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_21_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_22_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_23_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_24_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_25_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_26_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_27_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_28_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_29_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_30_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_31_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_32_вид2);
                    ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_33_вид2);

                    sgmass.Add(button12);
                    sgmass.Add(button13);
                    sgmass.Add(button14);
                    sgmass.Add(button15);
                    sgmass.Add(button16);
                    sgmass.Add(button17);
                    sgmass.Add(button18);
                    sgmass.Add(button19);
                    sgmass.Add(button20);
                    sgmass.Add(button21);
                    sgmass.Add(button22);
                    sgmass.Add(button23);
                    sgmass.Add(button24);
                    sgmass.Add(button25);
                    sgmass.Add(button26);
                    sgmass.Add(button27);
                    sgmass.Add(button28);
                    sgmass.Add(button29);
                    sgmass.Add(button30);
                    sgmass.Add(button31);
                    sgmass.Add(button32);
                    sgmass.Add(button33);
                    sgmass.Add(button34);
                    sgmass.Add(button35);
                    sgmass.Add(button36);
                    sgmass.Add(button37);
                    sgmass.Add(button38);
                    sgmass.Add(button39);
                    sgmass.Add(button40);
                    sgmass.Add(button41);
                    sgmass.Add(button42);
                    sgmass.Add(button43);
                    sgmass.Add(button44);
                    sgmass.Add(button45);

                    #endregion

                    countH1 = -1;

                    button46.Visible = true;
                    button47.Visible = true;

                    for (int i = 0; i < 34; i++)
                    {
                        fires[i].Image = ForFires2[i];
                        fires[i].Visible = false;
                        sgmass[i].Text = "";
                        sgmass[i].BackColor = Color.Gainsboro;
                        sgmass[i].Enabled = false;
                        if (i < 33)
                        {
                            pictures[i].Enabled = false;
                        }
                    }


                    for (int i = 16; i < 34; i++)
                    {
                        this.sgmass[i].Location = new Point(this.sgmass[i].Location.X, 562);
                        this.fires[i].Location = new Point(this.fires[i].Location.X, 538);
                    }


                    For3part = "";
                    

                    button5.BackColor = Color.PaleGreen;
                    button6.BackColor = Color.WhiteSmoke;
                                        
                    textBox2.Visible = false;
                    button4.Visible = false;

                    name1 = textBox2.Text;
                    name2 = "Компьютер";

                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБоснова;

                    Random rand = new Random();
                    rd = rand.Next(23) + 11;

                    for (int i = 0; i <= rd; i++)
                    {
                        fires[i].Visible = true;
                        sgmass[i].Enabled = true;
                    }
                    sgmass[0].Enabled = false;
                    
                    //rd = 33;
                    //сколько спичек всего
                    #region

                    for (int i = 0; i < 33; i++)
                    {
                        if (i < rd)
                        {
                            pictures[i].Visible = true;
                            pictures[i].Image = images1[i];
                        }
                    }

                    #endregion

                    button5.Visible = true;
                    button5.Text = name1;

                    button6.Visible = true;
                    button6.Text = name2;

                    button7.Visible = true;

                    Random rand1 = new Random();

                    temp = rand1.Next(3) + 2;
                    //temp = 4;

                    if (temp == 2)
                    {
                        visual2.Add(pictureBox70);
                        visual2.Add(pictureBox71);
                        visual2.Add(pictureBox72);
                        visual2.Add(pictureBox73);
                        visual2.Add(pictureBox74);
                        visual2.Add(pictureBox75);
                        visual2.Add(pictureBox76);
                    }
                    if (temp == 3)
                    {
                        visual3.Add(pictureBox70);
                        visual3.Add(pictureBox71);
                        visual3.Add(pictureBox77);
                        visual3.Add(pictureBox78);
                        visual3.Add(pictureBox79);
                        visual3.Add(pictureBox80);
                        visual3.Add(pictureBox81);
                        visual3.Add(pictureBox82);
                        visual3.Add(pictureBox83);
                        visual3.Add(pictureBox84);
                    }
                    if (temp == 4)
                    {
                        visual4.Add(pictureBox70);
                        visual4.Add(pictureBox71);
                        visual4.Add(pictureBox77);
                        visual4.Add(pictureBox85);
                        visual4.Add(pictureBox86);
                        visual4.Add(pictureBox87);
                        visual4.Add(pictureBox88);
                        visual4.Add(pictureBox89);
                        visual4.Add(pictureBox90);
                        visual4.Add(pictureBox91);
                        visual4.Add(pictureBox92);
                        visual4.Add(pictureBox93);
                        visual4.Add(pictureBox94);
                    }


                    sgmass[0].Text = Convert.ToString(temp + 1);
                    sgmass[0].BackColor = Color.PaleGreen;

                    string ss = Convert.ToString(temp);
                    button7.Text = "Можно брать от 1 до " + ss + " спичек";

                    button5.BackColor = Color.PaleGreen;

                    //Заполнение массива
                    #region



                    SG[0] = temp + 1;

                    for (int i = 1; i <= temp + 1; i++)
                    {
                        SG[i] = i - 1;
                    }


                    for (int i = temp + 2; i <= rd; i++)
                    {
                        for (int j = 0; j <= temp; j++)
                            HelpForMass[j] = false;

                        for (int j = 1; j <= temp; j++)
                        {
                            HelpForMass[SG[i - j]] = true;
                        }

                        for (int j = temp; j >= 0; j--)
                        {
                            if (HelpForMass[j] == false)
                                SG[i] = j;
                        }
                    }

                    #endregion

                    this.ClientSize = new System.Drawing.Size(698, 602);

                    #endregion

                }
            }

        }

        private void pictureBox34_MouseEnter(object sender, EventArgs e)
        {
            if ((r1 == true) || (r2 == true) || (r3 == true) || (label2.Text == "3"))
            {
                int k = 0;
                string s = (sender as PictureBox).Name;

                bool f = false;
                for (int i = 0; i < 33; i++)
                {
                    if (f == false)
                        k++;
                    if (pictures[i].Name == s)
                        f = true;
                       
                }

                int c = 0;
                for (int i = 0; i < 33; i++)
                {
                    if (pictures[i].Visible == true)
                        c++;
                }

                int raz = c - temp;

                if ((k >= raz + 1) && (k <= c))
                {
                    for (int i = k-1; i <= c-1; i++)
                    {
                        pictures[i].Image = images2[i];
                    }
                }

                
            }
        }

        private void pictureBox34_MouseLeave(object sender, EventArgs e)
        {
            if ((r1 == true) || (r2 == true) || (r3 == true) || (label2.Text == "3"))
            {
                for (int i = 0; i < 33; i++)
                {
                    pictures[i].Image = images1[i];
                }
            }
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            if (r1 == true)
            {
                #region
                

                int k = 0;
                string s = (sender as PictureBox).Name;

                int num = 0;
                bool f = false;
                for (int i = 0; i < 33; i++)
                {
                    if (f == false)
                        k++;
                    if (pictures[i].Name == s)
                    {
                        f = true;
                        num = i;
                    }

                }

                if (pictures[num].Image == images2[num])
                {
                    if (count == 1)
                    {
                        count = 0;
                        button6.BackColor = Color.PaleGreen;
                        button5.BackColor = Color.WhiteSmoke;
                    }
                    else
                    {
                        count = 1;
                        button5.BackColor = Color.PaleGreen;
                        button6.BackColor = Color.WhiteSmoke;
                    }

                    for (int i = k - 1; i < 33; i++)
                    {

                        pictures[i].Visible = false;
                    }

                    int cc = 0;
                    for (int i = 0; i < 33; i++)
                    {
                        if (pictures[i].Visible == true)
                            cc++;
                    }

                    if (cc == 0)
                    {
                        button8.Visible = true;
                        button9.Visible = true;
                        button10.Visible = true;
                        pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБХотСыгрЕщё;

                        if (count == 0)
                        {
                            button8.Text = name2;
                        }
                        else button8.Text = name1;

                        button5.Visible = false;
                        button6.Visible = false;
                        button7.Visible = false;

                    }
                }
                #endregion

            }

            if ((r2 == true) || (r3 == true) || (label2.Text == "3"))
            {
                if (label2.Text == "1")
                {
                    #region

                    //Ход пользователя

                    int k = 0;
                    string s = (sender as PictureBox).Name;
                    int nnum = 0;
                    bool f = false;
                    for (int i = 0; i < 33; i++)
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

                        for (int i = k - 1; i < 33; i++)
                        {
                            pictures[i].Visible = false;
                        }

                        int cc = 0;
                        for (int i = 0; i < 33; i++)
                        {
                            if (pictures[i].Visible == true)
                                cc++;
                        }

                        if (cc == 0)
                        {
                            button8.Visible = true;
                            button9.Visible = true;
                            button10.Visible = true;
                            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБХотСыгрЕщё;

                            if (r2 == true)
                            {
                                button8.Text = name2;
                            }
                            else button8.Text = name1;

                            button11.Visible = false;

                            button5.Visible = false;
                            button6.Visible = false;
                            button7.Visible = false;

                            this.ClientSize = new System.Drawing.Size(698, 430);
                            countbut = 0;
                        }
                        else
                        {
                            for (int i = 0; i < 34; i++)
                            {
                                sgmass[i].BackColor = Color.Gainsboro;
                                fires[i].Image = ForFires2[i];
                            }

                            //Ход комьютера

                            for (int i = 0; i <= rd; i++)
                            {
                                sgmass[i].Text = Convert.ToString(SG[i]);
                            }

                            cc = 0;
                            for (int i = 0; i < 33; i++)
                            {
                                if (pictures[i].Visible == true)
                                    cc++;
                            }

                            sgmass[cc].BackColor = Color.Salmon;


                            bool nw = false;

                            if (cc == 1)
                            {
                                nw = true;
                                pictures[0].Visible = false;
                            }

                            if (nw == false)
                            {

                                if (SG[cc] == 0)
                                {
                                    pictures[cc - 1].Visible = false;
                                    sgmass[cc - 1].BackColor = Color.LightGreen;

                                    for (int i = cc - 1; i > cc - 1 - temp; i--)
                                    {
                                        fires[i].Image = ForFires1[i];
                                    }
                                }
                                else
                                {
                                    int num = -1;
                                    for (int i = 1; i <= temp; i++)
                                    {
                                        if ((cc - i >= 0) && (SG[cc - i] == 0))
                                        {
                                            num = i;
                                            sgmass[cc - i].BackColor = Color.LightGreen;
                                        }
                                    }
                                    if (cc - 1 - temp >= 0)
                                    {
                                        for (int i = cc - 1; i > cc - 1 - temp; i--)
                                        {
                                            fires[i].Image = ForFires1[i];
                                        }
                                    }
                                    else
                                    {
                                        for (int i = cc - 1; i >= 0; i--)
                                        {
                                            fires[i].Image = ForFires1[i];
                                        }
                                    }

                                    for (int i = cc - 1; i > cc - 1 - num; i--)
                                    {
                                        pictures[i].Visible = false;

                                    }
                                }
                            }

                            if ((pictures[0].Visible == false) || (nw == true))
                            {
                                button8.Visible = true;
                                button9.Visible = true;
                                button10.Visible = true;
                                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБХотСыгрЕщё;

                                if (r2 == true)
                                {
                                    button8.Text = name1;
                                }
                                else button8.Text = name2;

                                button11.Visible = false;

                                button5.Visible = false;
                                button6.Visible = false;
                                button7.Visible = false;

                                this.ClientSize = new System.Drawing.Size(698, 430);
                                countbut = 0;
                            }

                        }
                    }
                    #endregion
                }

                if ((label2.Text == "2") || (label2.Text == "3"))
                {
                    #region

                    //Ход пользователя

                    int k = 0;
                    string s = (sender as PictureBox).Name;
                    int nnum = 0;
                    bool f = false;
                    for (int i = 0; i < 33; i++)
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


                        for (int i = k - 1; i < 33; i++)
                        {
                            pictures[i].Visible = false;
                        }

                        for (int i = 0; i < 34; i++)
                        {
                            sgmass[i].BackColor = Color.Gainsboro;
                            fires[i].Image = ForFires2[i];
                        }

                        for (int i = 0; i <= rd; i++)
                        {
                            sgmass[i].Text = Convert.ToString(SG[i]);
                        }

                        int cc = 0;
                        for (int i = 0; i < 33; i++)
                        {
                            if (pictures[i].Visible == true)
                                cc++;
                        }

                        if (cc == 0)
                        {
                           
                                button8.Visible = true;
                                button9.Visible = true;
                                button10.Visible = true;
                                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБХотСыгрЕщё;

                            
                            if ((r2 == true) || (label2.Text == "3"))
                            {
                                button8.Text = name2;
                            }
                            else button8.Text = name1;

                            button11.Visible = false;

                            button5.Visible = false;
                            button6.Visible = false;
                            button7.Visible = false;

                            this.ClientSize = new System.Drawing.Size(698, 430);
                            countbut = 0;
                        }
                        else
                        {
                            for (int i = 0; i < 34; i++)
                            {
                                sgmass[i].BackColor = Color.Gainsboro;
                                fires[i].Image = ForFires2[i];
                            }

                            //Ход комьютера

                            for (int i = 0; i <= rd; i++)
                            {
                                sgmass[i].Text = Convert.ToString(SG[i]);
                            }

                            int c = 0;
                            for (int i = 0; i < 33; i++)
                            {
                                if (pictures[i].Visible == true)
                                    c++;
                            }


                            bool nw = false;

                            if (cc == 1)
                            {
                                nw = true;
                                pictures[0].Visible = false;
                            }

                            if (nw == false)
                            {

                                if (SG[c] == 0)
                                {
                                    pictures[c - 1].Visible = false;
                                }
                                else
                                {
                                    int num = -1;
                                    for (int i = 1; i <= temp; i++)
                                    {
                                        if ((c - i >= 0) && (SG[c - i] == 0))
                                        {
                                            num = i;
                                        }
                                    }

                                    for (int i = c - 1; i > c - 1 - num; i--)
                                    {
                                        pictures[i].Visible = false;
                                    }
                                }
                            }

                            for (int i = 0; i <= rd; i++)
                            {
                                sgmass[i].Text = Convert.ToString(SG[i]);
                            }

                            c = 0;
                            for (int i = 0; i < 33; i++)
                            {
                                if (pictures[i].Visible == true)
                                    c++;
                            }

                            sgmass[c].BackColor = Color.DeepSkyBlue;

                            if (label2.Text == "2")
                            {

                                if (c - 1 - temp >= 0)
                                {
                                    for (int i = c - 1; i > c - 1 - temp; i--)
                                    {
                                        fires[i].Image = ForFires1[i];
                                    }
                                }
                                else
                                {
                                    for (int i = cc - 1; i >= 0; i--)
                                    {
                                        fires[i].Image = ForFires1[i];
                                    }
                                }
                            }

                            if (pictures[0].Visible == false)
                            {
                                
                                    button8.Visible = true;
                                    button9.Visible = true;
                                    button10.Visible = true;


                                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБХотСыгрЕщё;

                                
                                if ((r2 == true) || (label2.Text == "3"))
                                {
                                    button8.Text = name1;
                                }
                                else button8.Text = name2;

                                button11.Visible = false;

                                button5.Visible = false;
                                button6.Visible = false;
                                button7.Visible = false;

                                this.ClientSize = new System.Drawing.Size(698, 430);
                                countbut = 0;
                            }

                        }
                    }
                    #endregion
                }
            }

           
                        
        }


       private void button9_Click(object sender, EventArgs e)
       {
           if (label2.Text == "3")
           {
               pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБ_имя_ч_л_к_ч;
               textBox2.Visible = true;
               button4.Visible = true;
               button8.Visible = false;
               button9.Visible = false;
               button10.Visible = false;
               textBox2.Text = "";

           }
           else
           {

               textBox1.Text = "";
               textBox3.Text = "";


               button1.Visible = true;
               button2.Visible = true;
               button3.Visible = true;

               button8.Visible = false;
               button9.Visible = false;
               button10.Visible = false;

               pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБоснова;
           }
       }

       private void button10_Click(object sender, EventArgs e)
       {
           this.Close();
       }

       private void button2_Click(object sender, EventArgs e)
       {
           textBox2.Text = "";

           button1.Visible = false;
           button2.Visible = false;
           button3.Visible = false;

           textBox2.Visible = true;
           button4.Visible = true;

           r1 = false;
           r2 = true;
           r3 = false;

           #region

           pictures.Add(pictureBox2);
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
           pictures.Add(pictureBox24);
           pictures.Add(pictureBox25);
           pictures.Add(pictureBox26);
           pictures.Add(pictureBox27);
           pictures.Add(pictureBox28);
           pictures.Add(pictureBox29);
           pictures.Add(pictureBox30);
           pictures.Add(pictureBox31);
           pictures.Add(pictureBox32);
           pictures.Add(pictureBox33);
           pictures.Add(pictureBox34);

           fires.Add(pictureBox36);
           fires.Add(pictureBox37);
           fires.Add(pictureBox38);
           fires.Add(pictureBox39);
           fires.Add(pictureBox40);
           fires.Add(pictureBox41);
           fires.Add(pictureBox42);
           fires.Add(pictureBox43);
           fires.Add(pictureBox44);
           fires.Add(pictureBox45);
           fires.Add(pictureBox46);
           fires.Add(pictureBox47);
           fires.Add(pictureBox48);
           fires.Add(pictureBox49);
           fires.Add(pictureBox50);
           fires.Add(pictureBox51);
           fires.Add(pictureBox52);
           fires.Add(pictureBox53);
           fires.Add(pictureBox54);
           fires.Add(pictureBox55);
           fires.Add(pictureBox56);
           fires.Add(pictureBox57);
           fires.Add(pictureBox58);
           fires.Add(pictureBox59);
           fires.Add(pictureBox60);
           fires.Add(pictureBox61);
           fires.Add(pictureBox62);
           fires.Add(pictureBox63);
           fires.Add(pictureBox64);
           fires.Add(pictureBox65);
           fires.Add(pictureBox66);
           fires.Add(pictureBox67);
           fires.Add(pictureBox68);
           fires.Add(pictureBox69);

           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С1);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С2);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С3);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С4);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С5);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С6);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С7);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С8);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С9);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С10);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С11);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С12);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С13);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С14);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С15);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С16);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С17);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С18);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С19);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С20);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С21);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С22);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С23);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С24);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С25);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С26);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С27);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С28);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С29);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С30);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С31);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С32);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С33);

           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ1);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ2);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ3);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ4);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ5);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ6);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ7);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ8);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ9);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ10);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ11);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ12);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ13);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ14);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ15);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ16);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ17);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ18);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ19);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ20);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ21);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ22);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ23);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ24);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ25);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ26);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ27);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ28);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ29);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ30);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ31);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ32);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ33);

           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_0_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_1_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_2_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_3_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_4_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_5_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_6_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_7_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_8_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_9_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_10_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_11_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_12_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_13_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_14_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_15_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_16_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_17_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_18_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_19_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_20_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_21_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_22_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_23_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_24_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_25_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_26_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_27_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_28_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_29_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_30_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_31_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_32_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_33_вид1);

           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_0_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_1_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_2_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_3_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_4_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_5_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_6_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_7_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_8_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_9_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_10_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_11_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_12_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_13_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_14_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_15_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_16_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_17_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_18_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_19_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_20_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_21_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_22_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_23_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_24_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_25_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_26_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_27_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_28_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_29_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_30_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_31_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_32_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_33_вид2);

           sgmass.Add(button12);
           sgmass.Add(button13);
           sgmass.Add(button14);
           sgmass.Add(button15);
           sgmass.Add(button16);
           sgmass.Add(button17);
           sgmass.Add(button18);
           sgmass.Add(button19);
           sgmass.Add(button20);
           sgmass.Add(button21);
           sgmass.Add(button22);
           sgmass.Add(button23);
           sgmass.Add(button24);
           sgmass.Add(button25);
           sgmass.Add(button26);
           sgmass.Add(button27);
           sgmass.Add(button28);
           sgmass.Add(button29);
           sgmass.Add(button30);
           sgmass.Add(button31);
           sgmass.Add(button32);
           sgmass.Add(button33);
           sgmass.Add(button34);
           sgmass.Add(button35);
           sgmass.Add(button36);
           sgmass.Add(button37);
           sgmass.Add(button38);
           sgmass.Add(button39);
           sgmass.Add(button40);
           sgmass.Add(button41);
           sgmass.Add(button42);
           sgmass.Add(button43);
           sgmass.Add(button44);
           sgmass.Add(button45);

           #endregion

           pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБ_имя_ч_л_к_ч;
       }

       private void textBox2_TextChanged(object sender, EventArgs e)
       {

       }

       private void button3_Click(object sender, EventArgs e)
       {
           textBox2.Text = "";

           button1.Visible = false;
           button2.Visible = false;
           button3.Visible = false;

           textBox2.Visible = true;
           button4.Visible = true;

           r1 = false;
           r2 = false;
           r3 = true;

           #region

           pictures.Add(pictureBox2);
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
           pictures.Add(pictureBox24);
           pictures.Add(pictureBox25);
           pictures.Add(pictureBox26);
           pictures.Add(pictureBox27);
           pictures.Add(pictureBox28);
           pictures.Add(pictureBox29);
           pictures.Add(pictureBox30);
           pictures.Add(pictureBox31);
           pictures.Add(pictureBox32);
           pictures.Add(pictureBox33);
           pictures.Add(pictureBox34);

           fires.Add(pictureBox36);
           fires.Add(pictureBox37);
           fires.Add(pictureBox38);
           fires.Add(pictureBox39);
           fires.Add(pictureBox40);
           fires.Add(pictureBox41);
           fires.Add(pictureBox42);
           fires.Add(pictureBox43);
           fires.Add(pictureBox44);
           fires.Add(pictureBox45);
           fires.Add(pictureBox46);
           fires.Add(pictureBox47);
           fires.Add(pictureBox48);
           fires.Add(pictureBox49);
           fires.Add(pictureBox50);
           fires.Add(pictureBox51);
           fires.Add(pictureBox52);
           fires.Add(pictureBox53);
           fires.Add(pictureBox54);
           fires.Add(pictureBox55);
           fires.Add(pictureBox56);
           fires.Add(pictureBox57);
           fires.Add(pictureBox58);
           fires.Add(pictureBox59);
           fires.Add(pictureBox60);
           fires.Add(pictureBox61);
           fires.Add(pictureBox62);
           fires.Add(pictureBox63);
           fires.Add(pictureBox64);
           fires.Add(pictureBox65);
           fires.Add(pictureBox66);
           fires.Add(pictureBox67);
           fires.Add(pictureBox68);
           fires.Add(pictureBox69);

           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С1);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С2);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С3);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С4);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С5);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С6);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С7);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С8);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С9);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С10);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С11);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С12);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С13);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С14);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С15);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С16);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С17);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С18);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С19);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С20);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С21);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С22);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С23);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С24);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С25);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С26);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С27);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С28);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С29);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С30);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С31);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С32);
           images1.Add(global::WindowsFormsApplication1.Properties.Resources.С33);

           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ1);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ2);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ3);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ4);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ5);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ6);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ7);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ8);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ9);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ10);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ11);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ12);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ13);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ14);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ15);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ16);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ17);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ18);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ19);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ20);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ21);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ22);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ23);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ24);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ25);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ26);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ27);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ28);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ29);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ30);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ31);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ32);
           images2.Add(global::WindowsFormsApplication1.Properties.Resources.СГ33);

           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_0_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_1_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_2_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_3_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_4_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_5_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_6_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_7_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_8_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_9_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_10_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_11_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_12_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_13_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_14_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_15_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_16_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_17_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_18_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_19_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_20_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_21_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_22_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_23_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_24_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_25_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_26_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_27_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_28_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_29_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_30_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_31_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_32_вид1);
           ForFires1.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_33_вид1);

           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_0_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_1_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_2_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_3_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_4_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_5_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_6_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_7_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_8_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_9_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_10_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_11_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_12_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_13_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_14_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_15_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_16_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_17_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_18_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_19_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_20_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_21_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_22_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_23_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_24_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_25_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_26_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_27_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_28_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_29_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_30_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_31_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_32_вид2);
           ForFires2.Add(global::WindowsFormsApplication1.Properties.Resources.ИБ_цифры_33_вид2);

           sgmass.Add(button12);
           sgmass.Add(button13);
           sgmass.Add(button14);
           sgmass.Add(button15);
           sgmass.Add(button16);
           sgmass.Add(button17);
           sgmass.Add(button18);
           sgmass.Add(button19);
           sgmass.Add(button20);
           sgmass.Add(button21);
           sgmass.Add(button22);
           sgmass.Add(button23);
           sgmass.Add(button24);
           sgmass.Add(button25);
           sgmass.Add(button26);
           sgmass.Add(button27);
           sgmass.Add(button28);
           sgmass.Add(button29);
           sgmass.Add(button30);
           sgmass.Add(button31);
           sgmass.Add(button32);
           sgmass.Add(button33);
           sgmass.Add(button34);
           sgmass.Add(button35);
           sgmass.Add(button36);
           sgmass.Add(button37);
           sgmass.Add(button38);
           sgmass.Add(button39);
           sgmass.Add(button40);
           sgmass.Add(button41);
           sgmass.Add(button42);
           sgmass.Add(button43);
           sgmass.Add(button44);
           sgmass.Add(button45);

           #endregion

           pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИБ_имя_ч_л_к_ч;
       }

       private void button11_Click(object sender, EventArgs e)
       {
           if (countbut == 0)
           {
               this.ClientSize = new System.Drawing.Size(698, 562);
               countbut = 1;
           }
           else
           {
               this.ClientSize = new System.Drawing.Size(698, 430);
               countbut = 0;
           }
       }

       private void button18_Click(object sender, EventArgs e)
       {

       }

       private void button19_Click(object sender, EventArgs e)
       {

       }

       private void button21_Click(object sender, EventArgs e)
       {

       }

       private void button24_Click(object sender, EventArgs e)
       {

       }

       private void button25_Click(object sender, EventArgs e)
       {

       }

       private void button26_Click(object sender, EventArgs e)
       {

       }

       private void button27_Click(object sender, EventArgs e)
       {

       }

       private void pictureBox35_Click(object sender, EventArgs e)
       {

       }

       private void button29_Click(object sender, EventArgs e)
       {

       }

       private void button32_Click(object sender, EventArgs e)
       {

       }

       private void button39_Click(object sender, EventArgs e)
       {

       }

       private void pictureBox1_Click(object sender, EventArgs e)
       {

       }

       private void pictureBox44_Click(object sender, EventArgs e)
       {

       }

       private void pictureBox48_Click(object sender, EventArgs e)
       {

       }

       private void pictureBox63_Click(object sender, EventArgs e)
       {

       }

       private void pictureBox36_Click(object sender, EventArgs e)
       {

       }

       private void button47_Click(object sender, EventArgs e)
       {

       }

       private void button12_Click(object sender, EventArgs e)
       {
           if (label2.Text == "3")
           {
               string s = (sender as Button).Name;

               if (temp == 2)
               {
                   #region
                   int k = 0;
                   int nnum = 0;
                   bool f = false;
                   for (int i = 0; i < 33; i++)
                   {
                       if (f == false)
                           k++;
                       if (sgmass[i].Name == s)
                       {
                           f = true;
                           nnum = i;
                       }

                   }

                   label3.Text = Convert.ToString(nnum);

                   if (nnum <= 15)
                   {

                       if (nnum == 1)
                       {
                           visual2[0].Visible = true;
                           visual2[1].Visible = false;
                           visual2[2].Visible = false;
                           visual2[3].Visible = false;
                           visual2[4].Visible = false;
                           visual2[5].Visible = false;
                           visual2[6].Visible = false;
                       }
                       else
                       {
                           visual2[0].Visible = false;
                           visual2[2].Visible = false;
                           visual2[3].Visible = false;
                           visual2[4].Visible = false;
                           visual2[5].Visible = false;
                           visual2[1].Visible = true;
                           visual2[6].Visible = false;
                           this.visual2[1].Location = new Point(86 + (nnum - 2) * 38, this.visual2[1].Location.Y);
                       }
                   }
                   else if (nnum == 16)
                   {
                       visual2[0].Visible = false;
                       visual2[1].Visible = false;
                       visual2[2].Visible = true;
                       visual2[3].Visible = true;
                       visual2[4].Visible = false;
                       visual2[5].Visible = false;
                       visual2[6].Visible = false;
                   }
                   else if (nnum == 17)
                   {
                       visual2[0].Visible = false;
                       visual2[1].Visible = false;
                       visual2[2].Visible = false;
                       visual2[3].Visible = false;
                       visual2[4].Visible = true;
                       visual2[5].Visible = true;
                       visual2[6].Visible = false;
                   }
                   else
                   {
                       visual2[0].Visible = false;
                       visual2[2].Visible = false;
                       visual2[3].Visible = false;
                       visual2[4].Visible = false;
                       visual2[5].Visible = false;
                       visual2[1].Visible = false;
                       visual2[6].Visible = true;
                       this.visual2[6].Location = new Point(19 + (nnum - 18) * 38, this.visual2[6].Location.Y);
                   }

                   #endregion
               }

               if (temp == 3)
               {
                   #region
                   int k = 0;
                   int nnum = 0;
                   bool f = false;
                   for (int i = 0; i < 33; i++)
                   {
                       if (f == false)
                           k++;
                       if (sgmass[i].Name == s)
                       {
                           f = true;
                           nnum = i;
                       }

                   }

                   label3.Text = Convert.ToString(nnum);

                   if (nnum <= 15)
                   {

                       if (nnum == 1)
                       {
                           visual3[0].Visible = true;
                           visual3[1].Visible = false;
                           visual3[2].Visible = false;
                           visual3[3].Visible = false;
                           visual3[4].Visible = false;
                           visual3[5].Visible = false;
                           visual3[6].Visible = false;
                           visual3[7].Visible = false;
                           visual3[8].Visible = false;
                           visual3[9].Visible = false;
                       }
                       else if (nnum == 2)
                       {
                           visual3[0].Visible = false;
                           visual3[1].Visible = true;
                           visual3[2].Visible = false;
                           visual3[3].Visible = false;
                           visual3[4].Visible = false;
                           visual3[5].Visible = false;
                           visual3[6].Visible = false;
                           visual3[7].Visible = false;
                           visual3[8].Visible = false;
                           visual3[9].Visible = false;
                       }
                       else
                       {
                           visual3[0].Visible = false;
                           visual3[1].Visible = false;
                           visual3[2].Visible = true;
                           visual3[3].Visible = false;
                           visual3[4].Visible = false;
                           visual3[5].Visible = false;
                           visual3[6].Visible = false;
                           visual3[7].Visible = false;
                           visual3[8].Visible = false;
                           visual3[9].Visible = false;
                           this.visual3[2].Location = new Point(92 + (nnum - 3) * 38, this.visual3[2].Location.Y);
                       }
                   }
                   else if (nnum == 16)
                   {
                       visual3[0].Visible = false;
                       visual3[1].Visible = false;
                       visual3[2].Visible = false;
                       visual3[3].Visible = true;
                       visual3[4].Visible = true;
                       visual3[5].Visible = false;
                       visual3[6].Visible = false;
                       visual3[7].Visible = false;
                       visual3[8].Visible = false;
                       visual3[9].Visible = false;
                   }
                   else if (nnum == 17)
                   {
                       visual3[0].Visible = false;
                       visual3[1].Visible = false;
                       visual3[2].Visible = false;
                       visual3[3].Visible = false;
                       visual3[4].Visible = false;
                       visual3[5].Visible = true;
                       visual3[6].Visible = true;
                       visual3[7].Visible = false;
                       visual3[8].Visible = false;
                       visual3[9].Visible = false;
                   }
                   else if (nnum == 18)
                   {
                       visual3[0].Visible = false;
                       visual3[1].Visible = false;
                       visual3[2].Visible = false;
                       visual3[3].Visible = false;
                       visual3[4].Visible = false;
                       visual3[5].Visible = false;
                       visual3[6].Visible = false;
                       visual3[7].Visible = true;
                       visual3[8].Visible = true;
                       visual3[9].Visible = false;
                   }
                   else
                   {
                       visual3[0].Visible = false;
                       visual3[1].Visible = false;
                       visual3[2].Visible = false;
                       visual3[3].Visible = false;
                       visual3[4].Visible = false;
                       visual3[5].Visible = false;
                       visual3[6].Visible = false;
                       visual3[7].Visible = false;
                       visual3[8].Visible = false;
                       visual3[9].Visible = true;
                       this.visual3[9].Location = new Point(30 + (nnum - 19) * 38, this.visual3[9].Location.Y);
                   }

                   #endregion
               }

               if (temp == 4)
               {
                   #region

                   int k = 0;
                   int nnum = 0;
                   bool f = false;
                   for (int i = 0; i < 33; i++)
                   {
                       if (f == false)
                           k++;
                       if (sgmass[i].Name == s)
                       {
                           f = true;
                           nnum = i;
                       }

                   }

                   label3.Text = Convert.ToString(nnum);

                   if (nnum <= 15)
                   {

                       if (nnum == 1)
                       {
                           visual4[0].Visible = true;
                           visual4[1].Visible = false;
                           visual4[2].Visible = false;
                           visual4[3].Visible = false;
                           visual4[4].Visible = false;
                           visual4[5].Visible = false;
                           visual4[6].Visible = false;
                           visual4[7].Visible = false;
                           visual4[8].Visible = false;
                           visual4[9].Visible = false;
                           visual4[10].Visible = false;
                           visual4[11].Visible = false;
                           visual4[12].Visible = false;
                       }
                       else if (nnum == 2)
                       {
                           visual4[0].Visible = false;
                           visual4[1].Visible = true;
                           visual4[2].Visible = false;
                           visual4[3].Visible = false;
                           visual4[4].Visible = false;
                           visual4[5].Visible = false;
                           visual4[6].Visible = false;
                           visual4[7].Visible = false;
                           visual4[8].Visible = false;
                           visual4[9].Visible = false;
                           visual4[10].Visible = false;
                           visual4[11].Visible = false;
                           visual4[12].Visible = false;
                       }
                       else if (nnum == 3)
                       {
                           visual4[0].Visible = false;
                           visual4[1].Visible = false;
                           visual4[2].Visible = true;
                           visual4[3].Visible = false;
                           visual4[4].Visible = false;
                           visual4[5].Visible = false;
                           visual4[6].Visible = false;
                           visual4[7].Visible = false;
                           visual4[8].Visible = false;
                           visual4[9].Visible = false;
                           visual4[10].Visible = false;
                           visual4[11].Visible = false;
                           visual4[12].Visible = false;
                       }
                       else
                       {
                           visual4[0].Visible = false;
                           visual4[1].Visible = false;
                           visual4[2].Visible = false;
                           visual4[3].Visible = true;
                           visual4[4].Visible = false;
                           visual4[5].Visible = false;
                           visual4[6].Visible = false;
                           visual4[7].Visible = false;
                           visual4[8].Visible = false;
                           visual4[9].Visible = false;
                           visual4[10].Visible = false;
                           visual4[11].Visible = false;
                           visual4[12].Visible = false;
                           this.visual4[3].Location = new Point(97 + (nnum - 4) * 38, this.visual4[3].Location.Y);
                       }
                   }
                   else if (nnum == 16)
                   {
                       visual4[0].Visible = false;
                       visual4[1].Visible = false;
                       visual4[2].Visible = false;
                       visual4[3].Visible = false;
                       visual4[4].Visible = true;
                       visual4[5].Visible = true;
                       visual4[6].Visible = false;
                       visual4[7].Visible = false;
                       visual4[8].Visible = false;
                       visual4[9].Visible = false;
                       visual4[10].Visible = false;
                       visual4[11].Visible = false;
                       visual4[12].Visible = false;
                   }
                   else if (nnum == 17)
                   {
                       visual4[0].Visible = false;
                       visual4[1].Visible = false;
                       visual4[2].Visible = false;
                       visual4[3].Visible = false;
                       visual4[4].Visible = false;
                       visual4[5].Visible = false;
                       visual4[6].Visible = true;
                       visual4[7].Visible = true;
                       visual4[8].Visible = false;
                       visual4[9].Visible = false;
                       visual4[10].Visible = false;
                       visual4[11].Visible = false;
                       visual4[12].Visible = false;
                   }
                   else if (nnum == 18)
                   {
                       visual4[0].Visible = false;
                       visual4[1].Visible = false;
                       visual4[2].Visible = false;
                       visual4[3].Visible = false;
                       visual4[4].Visible = false;
                       visual4[5].Visible = false;
                       visual4[6].Visible = false;
                       visual4[7].Visible = false;
                       visual4[8].Visible = true;
                       visual4[9].Visible = true;
                       visual4[10].Visible = false;
                       visual4[11].Visible = false;
                       visual4[12].Visible = false;
                   }
                   else if (nnum == 19)
                   {
                       visual4[0].Visible = false;
                       visual4[1].Visible = false;
                       visual4[2].Visible = false;
                       visual4[3].Visible = false;
                       visual4[4].Visible = false;
                       visual4[5].Visible = false;
                       visual4[6].Visible = false;
                       visual4[7].Visible = false;
                       visual4[8].Visible = false;
                       visual4[9].Visible = false;
                       visual4[10].Visible = true;
                       visual4[11].Visible = true;
                       visual4[12].Visible = false;
                   }
                   else
                   {
                       visual4[0].Visible = false;
                       visual4[1].Visible = false;
                       visual4[2].Visible = false;
                       visual4[3].Visible = false;
                       visual4[4].Visible = false;
                       visual4[5].Visible = false;
                       visual4[6].Visible = false;
                       visual4[7].Visible = false;
                       visual4[8].Visible = false;
                       visual4[9].Visible = false;
                       visual4[10].Visible = false;
                       visual4[11].Visible = false;
                       visual4[12].Visible = true;
                       this.visual4[12].Location = new Point(29 + (nnum - 20) * 38, this.visual4[12].Location.Y);
                   }

                   #endregion
               }

               if (For3part == s)
               {
                   if (countH1 < temp)
                   {
                       countH1++;
                       Button clickedButton = (Button)sender;
                       clickedButton.Text = Convert.ToString(countH1);

                   }
                   else
                   {
                       countH1 = 0;
                       Button clickedButton = (Button)sender;
                       clickedButton.Text = Convert.ToString(countH1);
                   }
               }
               else
               {
                   For3part = s;
                   countH1 = -1;

                   if (countH1 < temp)
                   {
                       countH1++;
                       Button clickedButton = (Button)sender;
                       clickedButton.Text = Convert.ToString(countH1);

                   }
                   else
                   {
                       countH1 = 0;
                       Button clickedButton = (Button)sender;
                       clickedButton.Text = Convert.ToString(countH1);
                   }
               }
           }
       }

       private void button46_Click(object sender, EventArgs e)
       {
           int cont = 0;
           for (int i = 0; i <= rd; i++)
           {
               if (sgmass[i].Text == Convert.ToString(SG[i]))
               {
                   sgmass[i].BackColor = Color.LightGreen;
                   cont++;
               }
               else
               {
                   sgmass[i].BackColor = Color.Salmon;
               }
           }

           if (cont == rd + 1)
           {
               button46.Visible = false;
               button47.Visible = false;
               for (int i = 0; i <= rd; i++)
               {
                   sgmass[i].BackColor = Color.Gainsboro;
               }
               for (int i = 0; i < rd; i++)
               {
                   pictures[i].Enabled = true;
               }

               int c = 0;
               for (int i = 0; i < 33; i++)
               {
                   if (pictures[i].Visible == true)
                       c++;
               }

               if (temp == 2)
               {
                   visual2[0].Visible = false;
                   visual2[1].Visible = false;
                   visual2[2].Visible = false;
                   visual2[3].Visible = false;
                   visual2[4].Visible = false;
                   visual2[5].Visible = false;
                   visual2[6].Visible = false;
               }
               if (temp == 3)
               {
                   visual3[0].Visible = false;
                   visual3[1].Visible = false;
                   visual3[2].Visible = false;
                   visual3[3].Visible = false;
                   visual3[4].Visible = false;
                   visual3[5].Visible = false;
                   visual3[6].Visible = false;
                   visual3[7].Visible = false;
                   visual3[8].Visible = false;
                   visual3[9].Visible = false;
               }
               if (temp == 4)
               {
                   for (int i = 0; i < 13; i++)
                   {
                       visual4[i].Visible = false;
                   }
               }

               sgmass[c].BackColor = Color.DeepSkyBlue;

               //if (c - 1 - temp >= 0)
               //{
               //    for (int i = c - 1; i > c - 1 - temp; i--)
               //    {
               //        fires[i].Image = ForFires1[i];
               //    }
               //}

           }

       }

       private void pictureBox69_Click(object sender, EventArgs e)
       {

       }

       private void pictureBox85_Click(object sender, EventArgs e)
       {

       }

       private void pictureBox86_Click(object sender, EventArgs e)
       {

       }
    }
}
