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
    public partial class Form13 : Form
    {

        List<PictureBox> pictures = new List<PictureBox>();
        List<Image> images1 = new List<Image>();
        List<Image> images2 = new List<Image>();
        List<Button> buttons = new List<Button>();
        List<Label> labels = new List<Label>();
        List<Image> images = new List<Image>();


        public Form13()
        {
            InitializeComponent();
        }

        bool r1 = false, r2 = false, r3 = false;
        int  rd, temp = 0, count = 0, countOfWoods = 0, countbut = 0;
        string name1 = "", name2 = "";
        bool[] fib = new bool[91];
        bool[,] mainmass = new bool[91,150];

        

        private void button1_Click(object sender, EventArgs e)
        {
            r1 = true;
            r2 = false;
          

            textBox1.Text = "";
            textBox2.Text = "";

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СБ_имена;

            textBox1.Visible = true;
            textBox2.Visible = true;

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
            pictures.Add(pictureBox35);
            pictures.Add(pictureBox36);
            pictures.Add(pictureBox37);
            pictures.Add(pictureBox38);
            pictures.Add(pictureBox39);
            pictures.Add(pictureBox40);
            pictures.Add(pictureBox41);
            pictures.Add(pictureBox42);
            pictures.Add(pictureBox43);
            pictures.Add(pictureBox44);
            pictures.Add(pictureBox45);
            pictures.Add(pictureBox46);
            pictures.Add(pictureBox47);
            pictures.Add(pictureBox48);
            pictures.Add(pictureBox49);
            pictures.Add(pictureBox50);
            pictures.Add(pictureBox51);
            pictures.Add(pictureBox52);
            pictures.Add(pictureBox53);
            pictures.Add(pictureBox54);
            pictures.Add(pictureBox55);
            pictures.Add(pictureBox56);
            pictures.Add(pictureBox57);
            pictures.Add(pictureBox58);
            pictures.Add(pictureBox59);
            pictures.Add(pictureBox60);
            pictures.Add(pictureBox61);
            pictures.Add(pictureBox62);
            pictures.Add(pictureBox63);
            pictures.Add(pictureBox64);
            pictures.Add(pictureBox65);
            pictures.Add(pictureBox66);
            pictures.Add(pictureBox67);
            pictures.Add(pictureBox68);
            pictures.Add(pictureBox69);
            pictures.Add(pictureBox70);
            pictures.Add(pictureBox71);
            pictures.Add(pictureBox72);
            pictures.Add(pictureBox73);
            pictures.Add(pictureBox74);
            pictures.Add(pictureBox75);
            pictures.Add(pictureBox76);
            pictures.Add(pictureBox77);
            pictures.Add(pictureBox78);
            pictures.Add(pictureBox79);
            pictures.Add(pictureBox80);
            pictures.Add(pictureBox81);
            pictures.Add(pictureBox82);
            pictures.Add(pictureBox83);
            pictures.Add(pictureBox84);
            pictures.Add(pictureBox85);
            pictures.Add(pictureBox86);
            pictures.Add(pictureBox87);
            pictures.Add(pictureBox88);
            pictures.Add(pictureBox89);
            pictures.Add(pictureBox90);
            pictures.Add(pictureBox91);

            for (int i = 0; i < 90; i++)
            {
                images1.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_спичка);
                images2.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_окурок);
            }

            #endregion
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (r1 == true)
            {
                #region


                int k = 0;
                string s = (sender as PictureBox).Name;

                int num = 0;
                bool f = false;
                for (int i = 0; i < 90; i++)
                {
                    if (f == false)
                        k++;
                    if (pictures[i].Name == s)
                    {
                        f = true;
                        num = i;
                    }

                }

                int skolkoVzial = 0;

                if (pictures[num].Image == images2[num])
                {
                    if (count == 1)
                    {
                        count = 0;
                        button6.BackColor = Color.Khaki;
                        button5.BackColor = Color.LightGray;
                    }
                    else
                    {
                        count = 1;
                        button5.BackColor = Color.Khaki;
                        button6.BackColor = Color.LightGray;
                    }

                    for (int i = k - 1; i < 90; i++)
                    {
                        if (pictures[i].Visible == true)
                        {
                            pictures[i].Visible = false;
                            skolkoVzial++;
                        }
                    }

                    int cc = 0;
                    for (int i = 0; i < 90; i++)
                    {
                        if (pictures[i].Visible == true)
                            cc++;
                    }

                    if (skolkoVzial * 2 >= cc)
                    {
                        temp = cc;
                        label2.Text = "Можно брать от 1 до " + Convert.ToString(temp) + " спичек";
                    }
                    else
                    {
                        temp = skolkoVzial * 2;
                        label2.Text = "Можно брать от 1 до " + Convert.ToString(temp) + " спичек";
                    }
                    countOfWoods = cc;
                    label4.Text = "Спичек на столе: " + Convert.ToString(countOfWoods);

                    if (cc == 0)
                    {
                        button8.Visible = true;
                        button9.Visible = true;
                        button7.Visible = true;
                        pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СБ_хот_сыгр_ещё;

                        if (count == 0)
                        {
                            button9.Text = name1;
                        }
                        else button9.Text = name2;

                        button5.Visible = false;
                        button6.Visible = false;
                        
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;

                        this.ClientSize = new System.Drawing.Size(590, 465);
                        this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                        (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                    }
                }
                #endregion
            }

            if ((r2 == true) || (r3 == true)) 
            {
                #region

                button101.Visible = true;

                //////
                for (int i = 0; i < 91; i++)
                {
                    labels[i].BackColor = Color.LightGray;
                }
                //////

                int k = 0;
                string s = (sender as PictureBox).Name;

                int num = 0;
                bool f = false;
                for (int i = 0; i < 90; i++)
                {
                    if (f == false)
                        k++;
                    if (pictures[i].Name == s)
                    {
                        f = true;
                        num = i;
                    }
                }

                int skolkoVzial = 0;

                if (pictures[num].Image == images2[num])
                {

                    for (int i = k - 1; i < 90; i++)
                    {
                        if (pictures[i].Visible == true)
                        {
                            pictures[i].Visible = false;
                            skolkoVzial++;
                        }
                    }

                    int cc = 0;
                    for (int i = 0; i < 90; i++)
                    {
                        if (pictures[i].Visible == true)
                            cc++;
                    }

                    if (skolkoVzial * 2 >= cc)
                    {
                        temp = cc;
                        label2.Text = "Можно брать от 1 до " + Convert.ToString(temp) + " спичек";
                    }
                    else
                    {
                        temp = skolkoVzial * 2;
                        label2.Text = "Можно брать от 1 до " + Convert.ToString(temp) + " спичек";
                    }
                    countOfWoods = cc;
                    label4.Text = "Спичек на столе: " + Convert.ToString(countOfWoods);

                    if (cc == 0)
                    {
                        button8.Visible = true;
                        button9.Visible = true;
                        button7.Visible = true;
                        pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СБ_хот_сыгр_ещё;

                        if (r2 == true)
                        {
                            button9.Text = name1;
                        }
                        else button9.Text = name2;


                        button5.Visible = false;
                        button6.Visible = false;

                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;

                        this.ClientSize = new System.Drawing.Size(590, 465);
                        this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                        (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                        button101.Visible = false;
                    }
                    else
                    {
                        //Ход комьютера

                        cc = 0;
                        for (int i = 0; i < 90; i++)
                        {
                            if (pictures[i].Visible == true)
                                cc++;
                        }

                        int numForPoisk = -1;
                        Random rand = new Random();
                        int rd2 = rand.Next(temp) + 1;


                        int compVzial = 0;

                        if (temp >= countOfWoods)
                        {
                            compVzial = temp;
                            numForPoisk = 0;
                        }
                        else
                        {


                            for (int i = 0; i < 90; i++)
                            {
                                if (mainmass[i, countOfWoods] == true)
                                {
                                    numForPoisk = i;
                                }
                            }

                            if (numForPoisk == -1)
                            {
                                compVzial = rd2; //проишрышная
                                numForPoisk = countOfWoods - compVzial;
                            }
                            else
                            {
                                if (countOfWoods - numForPoisk <= temp)
                                {
                                    compVzial = countOfWoods - numForPoisk; //выигрышная
                                }
                                else
                                {
                                    compVzial = rd2;  //проишрышная
                                    numForPoisk = countOfWoods - compVzial;
                                }
                            }

                            ////
                        }

                        if (label1.Text == "1")
                        {
                            //////
                            labels[countOfWoods].BackColor = Color.LightSeaGreen;
                            labels[numForPoisk].BackColor = Color.MediumTurquoise;
                            //////
                        }

                        for (int i = numForPoisk; i < countOfWoods; i++)
                        {
                            pictures[i].Visible = false;
                        }

                        cc = 0;
                        for (int i = 0; i < 90; i++)
                        {
                            if (pictures[i].Visible == true)
                                cc++;
                        }

                        if (compVzial * 2 >= cc)
                        {
                            temp = cc;
                            label2.Text = "Можно брать от 1 до " + Convert.ToString(temp) + " спичек";
                        }
                        else
                        {
                            temp = compVzial * 2;
                            label2.Text = "Можно брать от 1 до " + Convert.ToString(temp) + " спичек";
                        }
                        countOfWoods = cc;
                        label4.Text = "Спичек на столе: " + Convert.ToString(countOfWoods);


                        //////
                        labels[countOfWoods].BackColor = Color.LightSeaGreen;
                        labels[numForPoisk].BackColor = Color.MediumTurquoise;
                        //////

                        if (label1.Text == "2")
                        {
                            //////
                            labels[countOfWoods].BackColor = Color.LightSeaGreen;
                            //////
                        }

                        if (cc == 0)
                        {
                            button8.Visible = true;
                            button9.Visible = true;
                            button7.Visible = true;
                            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СБ_хот_сыгр_ещё;


                            if (r2 == true)
                            {
                                button9.Text = name2;
                            }
                            else button9.Text = name1;

                            button5.Visible = false;
                            button6.Visible = false;

                            label2.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;

                            this.ClientSize = new System.Drawing.Size(590, 465);
                            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                            (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                            button101.Visible = false;
                        }



                    }
                }



                #endregion
            }

        }



        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox2.Text != textBox1.Text) && (r1 == true))
            {
                #region

                button4.Visible = false;
                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СП_фон_для_игры;

                name1 = textBox1.Text;
                name2 = textBox2.Text;
                textBox1.Text = "";
                textBox1.Visible = false;
                textBox2.Text = "";
                textBox2.Visible = false;

                button5.Visible = true;
                button5.Text = name1;
                button6.Visible = true;
                button6.Text = name2;

                button5.BackColor = Color.Khaki;
                button6.BackColor = Color.LightGray;

                Random rand = new Random();
                rd = rand.Next(10) + 81;

                label4.Visible = true;
                label4.Text = "Спичек на столе: " + Convert.ToString(rd);
                label2.Visible = true;
                label2.Text = "Можно брать от 1 до " + Convert.ToString(rd - 1) + " спичек";

                temp = rd - 1;

                for (int i = 0; i < rd; i++)
                {
                    pictures[i].Visible = true;
                    pictures[i].Image = global::WindowsFormsApplication1.Properties.Resources.СБ_спичка;
                }

                label3.Visible = true;
                label3.Text = "Выбрано: 0";

                this.ClientSize = new System.Drawing.Size(910, 465);
                this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
               
                count = 1;

                #endregion
            }
            if ((textBox3.Text != "") && (r2 == true))
            {
                #region

                ////Для графики
                #region

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
                buttons.Add(button37);
                buttons.Add(button38);
                buttons.Add(button39);
                buttons.Add(button40);
                buttons.Add(button41);
                buttons.Add(button42);
                buttons.Add(button43);
                buttons.Add(button44);
                buttons.Add(button45);
                buttons.Add(button46);
                buttons.Add(button47);
                buttons.Add(button48);
                buttons.Add(button49);
                buttons.Add(button50);
                buttons.Add(button51);
                buttons.Add(button52);
                buttons.Add(button53);
                buttons.Add(button54);
                buttons.Add(button55);
                buttons.Add(button56);
                buttons.Add(button57);
                buttons.Add(button58);
                buttons.Add(button59);
                buttons.Add(button60);
                buttons.Add(button61);
                buttons.Add(button62);
                buttons.Add(button63);
                buttons.Add(button64);
                buttons.Add(button65);
                buttons.Add(button66);
                buttons.Add(button67);
                buttons.Add(button68);
                buttons.Add(button69);
                buttons.Add(button70);
                buttons.Add(button71);
                buttons.Add(button72);
                buttons.Add(button73);
                buttons.Add(button74);
                buttons.Add(button75);
                buttons.Add(button76);
                buttons.Add(button77);
                buttons.Add(button78);
                buttons.Add(button79);
                buttons.Add(button80);
                buttons.Add(button81);
                buttons.Add(button82);
                buttons.Add(button83);
                buttons.Add(button84);
                buttons.Add(button85);
                buttons.Add(button86);
                buttons.Add(button87);
                buttons.Add(button88);
                buttons.Add(button89);
                buttons.Add(button90);
                buttons.Add(button91);
                buttons.Add(button92);
                buttons.Add(button93);
                buttons.Add(button94);
                buttons.Add(button95);
                buttons.Add(button96);
                buttons.Add(button97);
                buttons.Add(button98);
                buttons.Add(button99);
                buttons.Add(button100);

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
                labels.Add(label36);
                labels.Add(label37);
                labels.Add(label38);
                labels.Add(label39);
                labels.Add(label40);
                labels.Add(label41);
                labels.Add(label42);
                labels.Add(label43);
                labels.Add(label44);
                labels.Add(label45);
                labels.Add(label46);
                labels.Add(label47);
                labels.Add(label48);
                labels.Add(label49);
                labels.Add(label50);
                labels.Add(label51);
                labels.Add(label52);
                labels.Add(label53);
                labels.Add(label54);
                labels.Add(label55);
                labels.Add(label56);
                labels.Add(label57);
                labels.Add(label58);
                labels.Add(label59);
                labels.Add(label60);
                labels.Add(label61);
                labels.Add(label62);
                labels.Add(label63);
                labels.Add(label64);
                labels.Add(label65);
                labels.Add(label66);
                labels.Add(label67);
                labels.Add(label68);
                labels.Add(label69);
                labels.Add(label70);
                labels.Add(label71);
                labels.Add(label72);
                labels.Add(label73);
                labels.Add(label74);
                labels.Add(label75);
                labels.Add(label76);
                labels.Add(label77);
                labels.Add(label78);
                labels.Add(label79);
                labels.Add(label80);
                labels.Add(label81);
                labels.Add(label82);
                labels.Add(label83);
                labels.Add(label84);
                labels.Add(label85);
                labels.Add(label86);
                labels.Add(label87);
                labels.Add(label88);
                labels.Add(label89);
                labels.Add(label90);
                labels.Add(label91);
                labels.Add(label92);
                labels.Add(label93);
                labels.Add(label94);
                labels.Add(label95);

                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_81);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_82);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_83);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_84);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_85);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_86);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_87);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_88);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_89);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_90);


                for (int i = 0; i < 91; i++)
                {
                    labels[i].Visible = false;
                    buttons[i].Visible = false;
                }

                #endregion
                                
                countbut = 0;

                button4.Visible = false;
                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СП_фон_для_игры;

                name1 = textBox3.Text;
                name2 = "Компьютер";
                textBox3.Text = "";
                textBox3.Visible = false;

                button5.Visible = true;
                button5.Text = name1;
                button6.Visible = true;
                button6.Text = name2;

                button5.BackColor = Color.Khaki;
                button6.BackColor = Color.LightGray;

                Random rand = new Random();
                rd = rand.Next(10) + 81;
                //rd = 51;

                for (int i = 0; i < 10; i++)
                {
                    if (rd == i + 81)
                    {
                        pictureBox92.Image = images[i];
                    }
                }

                label4.Visible = true;
                label4.Text = "Спичек на столе: " + Convert.ToString(rd);
                label2.Visible = true;
                label2.Text = "Можно брать от 1 до " + Convert.ToString(rd - 1) + " спичек";

                temp = rd - 1;

                for (int i = 0; i < rd; i++)
                {
                    pictures[i].Visible = true;
                    pictures[i].Image = global::WindowsFormsApplication1.Properties.Resources.СБ_спичка;
                    
                }

                for (int i = 0; i <= rd; i++)
                {
                    buttons[i].Visible = true;
                    labels[i].Visible = true;
                    labels[i].BackColor = Color.LightGray;
                }

                label3.Visible = true;
                label3.Text = "Выбрано: 0";

                this.ClientSize = new System.Drawing.Size(910, 465);
                this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                
                buttons[0].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
                for (int i = 0; i < 91; i++)
                {
                    buttons[i].Image = global::WindowsFormsApplication1.Properties.Resources.крест_1;                    
                }

                ///////заполнение всякого разного для игры компьютера

                //фибоначчи
                #region

                for (int i = 0; i < 91; i++)
                {
                    fib[i] = false;
                }

                fib[0] = true;
                fib[3] = true;
                fib[5] = true;

                int f1 = 3, f2 = 5;

                while (f1 + f2 < 91)
                {
                    fib[f1 + f2] = true;
                    for (int i = f2 + 1; i < f1 + f2; i++)
                    {
                        if (fib[i - f2] == true)
                            fib[i] = true;
                    }
                    int h = f2;
                    f2 = f1 + f2;
                    f1 = h;
                }

                

                #endregion

                ////Для графики
                for (int i = 0; i < 91; i++)
                {
                    if (fib[i] == true)
                    {
                        buttons[i].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
                    }
                }

                //работа с двумерным массивом
                #region

                for (int i = 0; i < 91; i++)
                {
                    for (int j = 0; j < 91; j++)
                    {
                        mainmass[i, j] = false;
                    }
                }
                mainmass[3, 4] = true;

                for (int i = 5; i < 91; i++)
                {
                    if (fib[i] == true)
                    {
                        int j = 1, k = 1;
                        bool flagV = false;

                        bool h1, h2;

                        while (flagV == false)
                        {
                            int CONT = 0;
                            h1 = false; h2 = false;

                            if ((i - k != -1) && (i - k - 1 != -1))
                            {
                                int y1, y2;

                                if (i - k - k * 2 < 0)
                                    y1 = 0;
                                else y1 = i - k - k * 2;

                                if (i - k - 1 - (k + 1)*2 < 0)
                                    y2 = 0;
                                else y2 = i - k - 1 - (k + 1)*2;

                                for (int i1 = y1; i1 < i; i1++)
                                {
                                    if ((fib[i1] == true) && (mainmass[i1, i - k] == true))
                                        h2 = true;
                                }

                                for (int i1 = y2; i1 < i; i1++)
                                {
                                    if ((fib[i1] == true) && (mainmass[i1, i - k - 1] == true))
                                        h1 = true;
                                }

                                if ((h1 == true) && (h2 == false))
                                {
                                    if (k * 2 >= i - k)
                                    {
                                        h2 = true;
                                    }
                                }
                                else if ((h1 == false) && (h2 == true))
                                {
                                    if ((k + 1) * 2 >= i - k - 1)
                                    {
                                        h1 = true;
                                    }
                                }
                                else if ((h1 == false) && (h2 == false))
                                {
                                    if (((k + 1) * 2 >= i - k - 1) && (i - k - 1 != 0))
                                    {
                                        h1 = true;
                                    }
                                    if ((k * 2 >= i - k) && (i - k != 0))
                                    {
                                        h2 = true;
                                    }
                                }
                            }

                            if ((h1 == true) && (h2 == true))
                            {
                                
                                    k = k + 2;
                                    mainmass[i, i + j] = true;
                                    j++;
                                
                            }
                            else
                            {
                                flagV = true;
                            }
                        }
                    }
                }
                int y = 0;

                #endregion

                if (label1.Text == "2")
                {
                    button101.Visible = true;
                    int ccc = 0;
                    for (int i = 0; i < 90; i++)
                    {
                        if (pictures[i].Visible == true)
                        {
                            ccc++;
                        }
                    }


                    //////
                    labels[ccc].BackColor = Color.LightSeaGreen;
                    //////
                }


                #endregion
            }
            if ((textBox3.Text != "") && (r3 == true))
            {
                #region

                ////Для графики
                #region

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
                buttons.Add(button37);
                buttons.Add(button38);
                buttons.Add(button39);
                buttons.Add(button40);
                buttons.Add(button41);
                buttons.Add(button42);
                buttons.Add(button43);
                buttons.Add(button44);
                buttons.Add(button45);
                buttons.Add(button46);
                buttons.Add(button47);
                buttons.Add(button48);
                buttons.Add(button49);
                buttons.Add(button50);
                buttons.Add(button51);
                buttons.Add(button52);
                buttons.Add(button53);
                buttons.Add(button54);
                buttons.Add(button55);
                buttons.Add(button56);
                buttons.Add(button57);
                buttons.Add(button58);
                buttons.Add(button59);
                buttons.Add(button60);
                buttons.Add(button61);
                buttons.Add(button62);
                buttons.Add(button63);
                buttons.Add(button64);
                buttons.Add(button65);
                buttons.Add(button66);
                buttons.Add(button67);
                buttons.Add(button68);
                buttons.Add(button69);
                buttons.Add(button70);
                buttons.Add(button71);
                buttons.Add(button72);
                buttons.Add(button73);
                buttons.Add(button74);
                buttons.Add(button75);
                buttons.Add(button76);
                buttons.Add(button77);
                buttons.Add(button78);
                buttons.Add(button79);
                buttons.Add(button80);
                buttons.Add(button81);
                buttons.Add(button82);
                buttons.Add(button83);
                buttons.Add(button84);
                buttons.Add(button85);
                buttons.Add(button86);
                buttons.Add(button87);
                buttons.Add(button88);
                buttons.Add(button89);
                buttons.Add(button90);
                buttons.Add(button91);
                buttons.Add(button92);
                buttons.Add(button93);
                buttons.Add(button94);
                buttons.Add(button95);
                buttons.Add(button96);
                buttons.Add(button97);
                buttons.Add(button98);
                buttons.Add(button99);
                buttons.Add(button100);

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
                labels.Add(label36);
                labels.Add(label37);
                labels.Add(label38);
                labels.Add(label39);
                labels.Add(label40);
                labels.Add(label41);
                labels.Add(label42);
                labels.Add(label43);
                labels.Add(label44);
                labels.Add(label45);
                labels.Add(label46);
                labels.Add(label47);
                labels.Add(label48);
                labels.Add(label49);
                labels.Add(label50);
                labels.Add(label51);
                labels.Add(label52);
                labels.Add(label53);
                labels.Add(label54);
                labels.Add(label55);
                labels.Add(label56);
                labels.Add(label57);
                labels.Add(label58);
                labels.Add(label59);
                labels.Add(label60);
                labels.Add(label61);
                labels.Add(label62);
                labels.Add(label63);
                labels.Add(label64);
                labels.Add(label65);
                labels.Add(label66);
                labels.Add(label67);
                labels.Add(label68);
                labels.Add(label69);
                labels.Add(label70);
                labels.Add(label71);
                labels.Add(label72);
                labels.Add(label73);
                labels.Add(label74);
                labels.Add(label75);
                labels.Add(label76);
                labels.Add(label77);
                labels.Add(label78);
                labels.Add(label79);
                labels.Add(label80);
                labels.Add(label81);
                labels.Add(label82);
                labels.Add(label83);
                labels.Add(label84);
                labels.Add(label85);
                labels.Add(label86);
                labels.Add(label87);
                labels.Add(label88);
                labels.Add(label89);
                labels.Add(label90);
                labels.Add(label91);
                labels.Add(label92);
                labels.Add(label93);
                labels.Add(label94);
                labels.Add(label95);

                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_81);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_82);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_83);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_84);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_85);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_86);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_87);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_88);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_89);
                images.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_макет_90);


                for (int i = 0; i < 91; i++)
                {
                    labels[i].Visible = false;
                    buttons[i].Visible = false;
                }

                #endregion


                button101.Visible = true;
                countbut = 0;

                button4.Visible = false;
                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СП_фон_для_игры;

                name2 = textBox3.Text;
                name1 = "Компьютер";
                textBox3.Text = "";
                textBox3.Visible = false;

                button5.Visible = true;
                button5.Text = name1;
                button6.Visible = true;
                button6.Text = name2;

                button6.BackColor = Color.Khaki;
                button5.BackColor = Color.LightGray;

                Random rand = new Random();
                rd = rand.Next(10) + 81;
                //rd = 51;

                for (int i = 0; i < 10; i++)
                {
                    if (rd == i + 81)
                    {
                        pictureBox92.Image = images[i];
                    }
                }
                for (int i = 0; i <= rd; i++)
                {
                    buttons[i].Visible = true;
                    labels[i].Visible = true;
                    labels[i].BackColor = Color.LightGray;
                }



                label4.Visible = true;
                label4.Text = "Спичек на столе: " + Convert.ToString(rd);
                label2.Visible = true;
                label2.Text = "Можно брать от 1 до " + Convert.ToString(rd - 1) + " спичек";

                temp = rd - 1;

                for (int i = 0; i < rd; i++)
                {
                    pictures[i].Visible = true;
                    pictures[i].Image = global::WindowsFormsApplication1.Properties.Resources.СБ_спичка;
                }

                label3.Visible = true;
                label3.Text = "Выбрано: 0";

                this.ClientSize = new System.Drawing.Size(910, 465);
                this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                ///////заполнение всякого разного для игры компьютера

                //фибоначчи
                #region

                for (int i = 0; i < 91; i++)
                {
                    fib[i] = false;
                }

                fib[0] = true;
                fib[3] = true;
                fib[5] = true;

                int f1 = 3, f2 = 5;

                while (f1 + f2 < 91)
                {
                    fib[f1 + f2] = true;
                    for (int i = f2 + 1; i < f1 + f2; i++)
                    {
                        if (fib[i - f2] == true)
                            fib[i] = true;
                    }
                    int h = f2;
                    f2 = f1 + f2;
                    f1 = h;
                }

                int b = 0;

                #endregion

                ////Для графики
                for (int i = 0; i < 91; i++)
                {
                    if (fib[i] == true)
                    {
                        buttons[i].Image = global::WindowsFormsApplication1.Properties.Resources.галка_1;
                    }
                }

                //работа с двумерным массивом
                #region

                for (int i = 0; i < 91; i++)
                {
                    for (int j = 0; j < 91; j++)
                    {
                        mainmass[i, j] = false;
                    }
                }
                mainmass[3, 4] = true;

                for (int i = 5; i < 91; i++)
                {
                    if (fib[i] == true)
                    {
                        int j = 1, k = 1;
                        bool flagV = false;

                        bool h1, h2;

                        while (flagV == false)
                        {
                            int CONT = 0;
                            h1 = false; h2 = false;

                            if ((i - k != -1) && (i - k - 1 != -1))
                            {
                                int y1, y2;

                                if (i - k - k * 2 < 0)
                                    y1 = 0;
                                else y1 = i - k - k * 2;

                                if (i - k - 1 - (k + 1) * 2 < 0)
                                    y2 = 0;
                                else y2 = i - k - 1 - (k + 1) * 2;

                                for (int i1 = y1; i1 < i; i1++)
                                {
                                    if ((fib[i1] == true) && (mainmass[i1, i - k] == true))
                                        h2 = true;
                                }

                                for (int i1 = y2; i1 < i; i1++)
                                {
                                    if ((fib[i1] == true) && (mainmass[i1, i - k - 1] == true))
                                        h1 = true;
                                }

                                if ((h1 == true) && (h2 == false))
                                {
                                    if (k * 2 >= i - k)
                                    {
                                        h2 = true;
                                    }
                                }
                                else if ((h1 == false) && (h2 == true))
                                {
                                    if ((k + 1) * 2 >= i - k - 1)
                                    {
                                        h1 = true;
                                    }
                                }
                                else if ((h1 == false) && (h2 == false))
                                {
                                    if (((k + 1) * 2 >= i - k - 1) && (i - k - 1 != 0))
                                    {
                                        h1 = true;
                                    }
                                    if ((k * 2 >= i - k) && (i - k != 0))
                                    {
                                        h2 = true;
                                    }
                                }
                            }

                            if ((h1 == true) && (h2 == true))
                            {

                                k = k + 2;
                                mainmass[i, i + j] = true;
                                j++;

                            }
                            else
                            {
                                flagV = true;
                            }
                        }
                    }
                }
                int y = 0;

                #endregion

                int cc = 0;
                for (int i = 0; i < 90; i++)
                {
                    if (pictures[i].Visible == true)
                        cc++;
                }
                countOfWoods = cc;

                int numForPoisk = -1;
                Random rand1 = new Random();
                int rd2 = rand1.Next(temp) + 1;


                int compVzial = 0;

                if (temp >= countOfWoods)
                {
                    compVzial = temp;
                    numForPoisk = 0;
                }
                else
                {


                    for (int i = 0; i < 90; i++)
                    {
                        if (mainmass[i, countOfWoods] == true)
                        {
                            numForPoisk = i;
                        }
                    }

                    if (numForPoisk == -1)
                    {
                        compVzial = rd2; //проишрышная
                        numForPoisk = countOfWoods - compVzial;
                    }
                    else
                    {
                        if (countOfWoods - numForPoisk <= temp)
                        {
                            compVzial = countOfWoods - numForPoisk; //выигрышная
                        }
                        else
                        {
                            compVzial = rd2;  //проишрышная
                            numForPoisk = countOfWoods - compVzial;
                        }
                    }

                    ////
                }

                if (label1.Text == "1")
                {                    
                    //////
                    labels[countOfWoods].BackColor = Color.LightSeaGreen;
                    labels[numForPoisk].BackColor = Color.MediumTurquoise;
                    //////
                }

                for (int i = numForPoisk; i < countOfWoods; i++)
                {
                    pictures[i].Visible = false;
                }

                cc = 0;
                for (int i = 0; i < 90; i++)
                {
                    if (pictures[i].Visible == true)
                        cc++;
                }

                if (compVzial * 2 >= cc)
                {
                    temp = cc;
                    label2.Text = "Можно брать от 1 до " + Convert.ToString(temp) + " спичек";
                }
                else
                {
                    temp = compVzial * 2;
                    label2.Text = "Можно брать от 1 до " + Convert.ToString(temp) + " спичек";
                }
                countOfWoods = cc;
                label4.Text = "Спичек на столе: " + Convert.ToString(countOfWoods);

                if (label1.Text == "2")
                {                    
                    //////
                    labels[countOfWoods].BackColor = Color.LightSeaGreen;
                    //////
                }

                #endregion
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if ((r1 == true) || (r2 == true) || (r3 == true))
            {
                #region

                int k = 0;
                string s = (sender as PictureBox).Name;

                bool f = false;
                for (int i = 0; i < 90; i++)
                {
                    if (f == false)
                        k++;
                    if (pictures[i].Name == s)
                        f = true;

                }

                int c = 0;
                for (int i = 0; i < 90; i++)
                {
                    if (pictures[i].Visible == true)
                        c++;
                }


                int raz = c - temp;
                int ccount = 0;

                if ((k >= raz + 1) && (k <= c))
                {
                    for (int i = k - 1; i <= c - 1; i++)
                    {
                        pictures[i].Image = images2[i];
                        ccount++;
                    }
                }

                label3.Text = "Выбрано: " + Convert.ToString(ccount);

                #endregion
            }
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if ((r1 == true) || (r2 == true) || (r3 == true))
            {
                for (int i = 0; i < 90; i++)
                {
                    pictures[i].Image = images1[i];
                }
            }
            label3.Text = "Выбрано: 0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
          
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СП_фон_голубой;

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r1 = false;
            r2 = true;
            r3 = false;
           

            textBox3.Text = "";

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СБ_введите_имя;

            textBox3.Visible = true;

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
            pictures.Add(pictureBox35);
            pictures.Add(pictureBox36);
            pictures.Add(pictureBox37);
            pictures.Add(pictureBox38);
            pictures.Add(pictureBox39);
            pictures.Add(pictureBox40);
            pictures.Add(pictureBox41);
            pictures.Add(pictureBox42);
            pictures.Add(pictureBox43);
            pictures.Add(pictureBox44);
            pictures.Add(pictureBox45);
            pictures.Add(pictureBox46);
            pictures.Add(pictureBox47);
            pictures.Add(pictureBox48);
            pictures.Add(pictureBox49);
            pictures.Add(pictureBox50);
            pictures.Add(pictureBox51);
            pictures.Add(pictureBox52);
            pictures.Add(pictureBox53);
            pictures.Add(pictureBox54);
            pictures.Add(pictureBox55);
            pictures.Add(pictureBox56);
            pictures.Add(pictureBox57);
            pictures.Add(pictureBox58);
            pictures.Add(pictureBox59);
            pictures.Add(pictureBox60);
            pictures.Add(pictureBox61);
            pictures.Add(pictureBox62);
            pictures.Add(pictureBox63);
            pictures.Add(pictureBox64);
            pictures.Add(pictureBox65);
            pictures.Add(pictureBox66);
            pictures.Add(pictureBox67);
            pictures.Add(pictureBox68);
            pictures.Add(pictureBox69);
            pictures.Add(pictureBox70);
            pictures.Add(pictureBox71);
            pictures.Add(pictureBox72);
            pictures.Add(pictureBox73);
            pictures.Add(pictureBox74);
            pictures.Add(pictureBox75);
            pictures.Add(pictureBox76);
            pictures.Add(pictureBox77);
            pictures.Add(pictureBox78);
            pictures.Add(pictureBox79);
            pictures.Add(pictureBox80);
            pictures.Add(pictureBox81);
            pictures.Add(pictureBox82);
            pictures.Add(pictureBox83);
            pictures.Add(pictureBox84);
            pictures.Add(pictureBox85);
            pictures.Add(pictureBox86);
            pictures.Add(pictureBox87);
            pictures.Add(pictureBox88);
            pictures.Add(pictureBox89);
            pictures.Add(pictureBox90);
            pictures.Add(pictureBox91);

            for (int i = 0; i < 90; i++)
            {
                images1.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_спичка);
                images2.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_окурок);
            }

            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            r1 = false;
            r2 = false;
            r3 = true;
            

            textBox3.Text = "";

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.СБ_введите_имя;

            textBox3.Visible = true;

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
            pictures.Add(pictureBox35);
            pictures.Add(pictureBox36);
            pictures.Add(pictureBox37);
            pictures.Add(pictureBox38);
            pictures.Add(pictureBox39);
            pictures.Add(pictureBox40);
            pictures.Add(pictureBox41);
            pictures.Add(pictureBox42);
            pictures.Add(pictureBox43);
            pictures.Add(pictureBox44);
            pictures.Add(pictureBox45);
            pictures.Add(pictureBox46);
            pictures.Add(pictureBox47);
            pictures.Add(pictureBox48);
            pictures.Add(pictureBox49);
            pictures.Add(pictureBox50);
            pictures.Add(pictureBox51);
            pictures.Add(pictureBox52);
            pictures.Add(pictureBox53);
            pictures.Add(pictureBox54);
            pictures.Add(pictureBox55);
            pictures.Add(pictureBox56);
            pictures.Add(pictureBox57);
            pictures.Add(pictureBox58);
            pictures.Add(pictureBox59);
            pictures.Add(pictureBox60);
            pictures.Add(pictureBox61);
            pictures.Add(pictureBox62);
            pictures.Add(pictureBox63);
            pictures.Add(pictureBox64);
            pictures.Add(pictureBox65);
            pictures.Add(pictureBox66);
            pictures.Add(pictureBox67);
            pictures.Add(pictureBox68);
            pictures.Add(pictureBox69);
            pictures.Add(pictureBox70);
            pictures.Add(pictureBox71);
            pictures.Add(pictureBox72);
            pictures.Add(pictureBox73);
            pictures.Add(pictureBox74);
            pictures.Add(pictureBox75);
            pictures.Add(pictureBox76);
            pictures.Add(pictureBox77);
            pictures.Add(pictureBox78);
            pictures.Add(pictureBox79);
            pictures.Add(pictureBox80);
            pictures.Add(pictureBox81);
            pictures.Add(pictureBox82);
            pictures.Add(pictureBox83);
            pictures.Add(pictureBox84);
            pictures.Add(pictureBox85);
            pictures.Add(pictureBox86);
            pictures.Add(pictureBox87);
            pictures.Add(pictureBox88);
            pictures.Add(pictureBox89);
            pictures.Add(pictureBox90);
            pictures.Add(pictureBox91);

            for (int i = 0; i < 90; i++)
            {
                images1.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_спичка);
                images2.Add(global::WindowsFormsApplication1.Properties.Resources.СБ_окурок);
            }

            #endregion
        }

        private void button101_Click(object sender, EventArgs e)
        {
            #region

            if (countbut == 0)
                {
                    if ((r2 == true) || (r3 == true))
                    {
                        pictureBox24.Visible = true;

                        this.ClientSize = new System.Drawing.Size(910, 680);
                        this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                        (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                        countbut = 1;
                    }

                }
                else
                {
                    if ((r2 == true) || (r3 == true))
                    {
                        pictureBox24.Visible = false;

                        this.ClientSize = new System.Drawing.Size(910, 465);
                        this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                        (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                        countbut = 0;
                    }
                }



            #endregion
        }

       

        
    }
}
