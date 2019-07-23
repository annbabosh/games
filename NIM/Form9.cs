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
    public partial class Form9 : Form
    {
        List<PictureBox> pictures = new List<PictureBox>();
        List<PictureBox> helppictures = new List<PictureBox>();
        List<PictureBox> helppictures2 = new List<PictureBox>();
        List<Image> imagesBig = new List<Image>();
        List<Image> imagesSmall = new List<Image>();
        List<Image> imagesSmall22 = new List<Image>();
        List<PictureBox> pictures2 = new List<PictureBox>();
        List<Image> imagesBig2 = new List<Image>();
        List<Image> imagesSmall2 = new List<Image>();
        List<Button> buttonsBlue = new List<Button>();
        List<Button> buttonsRed = new List<Button>();

        bool r1 = false, r2 = false, r3 = false, impotant = false;
        string name1, name2;
        int rd, globcount, countbut = 0;
        int[] SG = new int[29];
        int[] kuchki = new int[15];

        public Form9()
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

            //string s;
            //s = Convert.ToString(sum);
            //int k = 1;
            //sum = 0;
            //for (int i = s.Length; i >= 0; i--)
            //{
            //    sum = sum + Convert.ToInt32(s[i]) * k;
            //    k = k * 2;
            //}

            return sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            globcount = 1;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            textBox1.Visible = true;
            textBox2.Visible = true;
            button4.Visible = true;

            r1 = true;
            r2 = false;
            r3 = false;

            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_имена_ч_ч_;

            #region

            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_1);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_2);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_3);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_4);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_5);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_6);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_7);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_8);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_9);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_10);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_11);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_12);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_13);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_14);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_15);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_16);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_17);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_18);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_19);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_20);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_21);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_22);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_23);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_24);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_25);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_26);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_27);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_28);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_29);

            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_1);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_2);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_3);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_4);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_5);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_6);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_7);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_8);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_9);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_10);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_11);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_12);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_13);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_14);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_15);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_16);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_17);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_18);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_19);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_20);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_21);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_22);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_23);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_24);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_25);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_26);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_27);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_28);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_29);

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

            #endregion
            #region

            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_1);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_2);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_3);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_4);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_5);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_6);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_7);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_8);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_9);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_10);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_11);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_12);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_13);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_14);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_15);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_16);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_17);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_18);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_19);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_20);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_21);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_22);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_23);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_24);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_25);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_26);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_27);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_28);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_29);

            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_1);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_2);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_3);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_4);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_5);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_6);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_7);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_8);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_9);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_10);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_11);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_12);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_13);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_14);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_15);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_16);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_17);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_18);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_19);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_20);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_21);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_22);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_23);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_24);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_25);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_26);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_27);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_28);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_29);

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

            pictures2.Add(pictureBox32);
            pictures2.Add(pictureBox33);
            pictures2.Add(pictureBox34);
            pictures2.Add(pictureBox35);
            pictures2.Add(pictureBox36);
            pictures2.Add(pictureBox37);
            pictures2.Add(pictureBox38);
            pictures2.Add(pictureBox39);
            pictures2.Add(pictureBox40);
            pictures2.Add(pictureBox41);
            pictures2.Add(pictureBox42);
            pictures2.Add(pictureBox43);
            pictures2.Add(pictureBox44);
            pictures2.Add(pictureBox45);
            pictures2.Add(pictureBox46);
            pictures2.Add(pictureBox47);
            pictures2.Add(pictureBox48);
            pictures2.Add(pictureBox49);
            pictures2.Add(pictureBox50);
            pictures2.Add(pictureBox51);
            pictures2.Add(pictureBox52);
            pictures2.Add(pictureBox53);
            pictures2.Add(pictureBox54);
            pictures2.Add(pictureBox55);
            pictures2.Add(pictureBox56);
            pictures2.Add(pictureBox57);
            pictures2.Add(pictureBox58);
            pictures2.Add(pictureBox59);
            pictures2.Add(pictureBox60);

            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_1);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_2);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_3);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_4);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_5);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_6);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_7);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_8);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_9);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_10);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_11);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_12);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_13);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_14);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_15);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_16);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_17);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_18);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_19);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_20);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_21);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_22);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_23);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_24);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_25);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_26);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_27);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_28);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_29);

            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_1);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_2);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_3);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_4);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_5);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_6);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_7);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_8);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_9);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_10);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_11);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_12);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_13);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_14);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_15);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_16);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_17);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_18);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_19);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_20);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_21);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_22);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_23);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_24);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_25);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_26);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_27);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_28);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_29);

            buttonsBlue.Add(button11);
            buttonsBlue.Add(button12);
            buttonsBlue.Add(button13);
            buttonsBlue.Add(button14);
            buttonsBlue.Add(button15);
            buttonsBlue.Add(button16);
            buttonsBlue.Add(button17);
            buttonsBlue.Add(button18);
            buttonsBlue.Add(button19);
            buttonsBlue.Add(button20);
            buttonsBlue.Add(button21);
            buttonsBlue.Add(button22);
            buttonsBlue.Add(button23);
            buttonsBlue.Add(button24);
            buttonsBlue.Add(button25);

            buttonsRed.Add(button28);
            buttonsRed.Add(button29);
            buttonsRed.Add(button30);
            buttonsRed.Add(button31);
            buttonsRed.Add(button32);
            buttonsRed.Add(button33);
            buttonsRed.Add(button34);
            buttonsRed.Add(button35);
            buttonsRed.Add(button36);
            buttonsRed.Add(button37);
            buttonsRed.Add(button38);
            buttonsRed.Add(button39);
            buttonsRed.Add(button40);
            buttonsRed.Add(button41);
            buttonsRed.Add(button42);


            #endregion

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text != "") && (textBox1.Text != "") && (textBox1.Text != textBox2.Text))
            {
                if (r1 == true)
                {
                    #region

                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_главный_фон;
                    button4.Visible = false;
                    textBox2.Visible = false;
                    textBox1.Visible = false;

                    name1 = textBox1.Text;
                    name2 = textBox2.Text;

                    button7.Visible = true;
                    button8.Visible = true;
                    button7.Text = name1;
                    button8.Text = name2;

                    Random rand = new Random();
                    rd = rand.Next(10) + 20;

                    button7.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_чей_ход;

                    //rd = 29;
                    //сколько карандашей всего                    

                    for (int i = 0; i < 30; i++)
                    {
                        if (i < rd)
                        {
                            pictures[i].Visible = true;
                            pictures[i].Image = imagesBig[i];
                        }
                    }

                    this.ClientSize = new System.Drawing.Size(1110, 350);
                    this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                    (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                    impotant = true;
                    
                    #endregion
                }
            }

            if (textBox3.Text != "")
            {
                if (r2 == true)
                {
                    #region

                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_главный_фон;
                    button4.Visible = false;
                    textBox3.Visible = false;
                    //textBox1.Visible = false;
                    button9.Visible = true;

                    name1 = textBox3.Text;
                    name2 = "Компьютер";

                    button7.Visible = true;
                    button8.Visible = true;
                    button7.Text = name1;
                    button8.Text = name2;

                    Random rand = new Random();
                    rd = rand.Next(10) + 20;

                    button7.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_чей_ход;

                    //rd = 8;
                    //сколько карандашей всего                    

                    for (int i = 0; i < 30; i++)
                    {
                        if (i < rd)
                        {
                            pictures[i].Visible = true;
                            pictures[i].Image = imagesBig[i];
                        }
                    }

                    this.ClientSize = new System.Drawing.Size(1110, 350);
                    this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                    (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
                    pictureBox1.Size = new System.Drawing.Size(1110, 350);

                    impotant = true;

                    //числа Спрага - Грюнди
                    #region

                    SG[0] = 0;
                    SG[1] = 1;
                    SG[2] = 2;
                    int ii = 3;
                    bool flag = false;
                    while ((ii < 29) && (flag == false)) 
                    {
                        int right = 0, left = 0;
                        bool[] fl = new bool[30];
                        int[] forsum = new int[2];
                        for (int i = 0; i < 30; i++)
                        {
                            fl[i] = false;
                        }

                        for (int j = 1; j <= ii; j++)
                        {
                            right = j - 1;
                            left = ii - j;
                            forsum[0] = SG[right];
                            forsum[1] = SG[left];
                            fl[NimSum(forsum)] = true;
                        }

                        for (int j = 2; j <= ii; j++)
                        {
                            right = j - 2;
                            left = ii - j;
                            forsum[0] = SG[right];
                            forsum[1] = SG[left];
                            fl[NimSum(forsum)] = true;
                        }

                        for (int i = 19; i >= 0; i--)
                        {
                            if (fl[i] == false)
                            {
                                SG[ii] = i;
                            }
                        }
                        ii++;
                    }

                    #endregion

                    for (int i = 0; i < 15; i++)
                    {
                        kuchki[i] = 0;
                    }
                    kuchki[0] = rd;


                    /////Вспомогалочка

                    for (int i = 0; i < 29; i++)
                    {
                        pictures2[i].Image = imagesBig2[i];
                        pictures2[i].Visible = true;
                    }

                    for (int i = 0; i < 29; i++)
                    {
                        //pictures2[i].Image = imagesBig2[i];
                        pictures2[i].Visible = false;
                    }
                    for (int i = 0; i < 15; i++)
                    {
                        buttonsBlue[i].Visible = true;
                        buttonsBlue[i].Width = 85;
                    }
                    for (int i = 0; i < 15; i++)
                    {
                        buttonsBlue[i].Visible = false;
                    }

                    button26.Visible = false;

                    for (int i = 0; i < 15; i++)
                    {
                        buttonsRed[i].Visible = false;
                        buttonsRed[i].Width = 85;
                    }
                    
                    button27.Visible = false;

                    #endregion
                }

                if (r3 == true)
                {
                    #region

                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_главный_фон;
                    button4.Visible = false;
                    textBox3.Visible = false;
                    //textBox1.Visible = false;

                    name2 = textBox3.Text;
                    name1 = "Компьютер";

                    button9.Visible = true;

                    button7.Visible = true;
                    button8.Visible = true;
                    button7.Text = name1;
                    button8.Text = name2;

                    Random rand = new Random();
                    rd = rand.Next(10) + 20;

                    button7.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_для_имен;
                    button8.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_чей_ход;

                    //rd = 9;
                    //сколько карандашей всего                    

                    for (int i = 0; i < 30; i++)
                    {
                        if (i < rd)
                        {
                            pictures[i].Visible = true;
                            pictures[i].Image = imagesBig[i];
                        }
                    }

                    this.ClientSize = new System.Drawing.Size(1110, 350);
                    this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                    (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                    pictureBox1.Size = new System.Drawing.Size(1110, 350);

                    impotant = true;

                    //числа Спрага - Грюнди
                    #region

                    SG[0] = 0;
                    SG[1] = 1;
                    SG[2] = 2;
                    int ii = 3;
                    bool flag = false;
                    while ((ii < 29) && (flag == false))
                    {
                        int right = 0, left = 0;
                        bool[] fl = new bool[30];
                        int[] forsum = new int[2];
                        for (int i = 0; i < 30; i++)
                        {
                            fl[i] = false;
                        }

                        for (int j = 1; j <= ii; j++)
                        {
                            right = j - 1;
                            left = ii - j;
                            forsum[0] = SG[right];
                            forsum[1] = SG[left];
                            fl[NimSum(forsum)] = true;
                        }

                        for (int j = 2; j <= ii; j++)
                        {
                            right = j - 2;
                            left = ii - j;
                            forsum[0] = SG[right];
                            forsum[1] = SG[left];
                            fl[NimSum(forsum)] = true;
                        }

                        for (int i = 19; i >= 0; i--)
                        {
                            if (fl[i] == false)
                            {
                                SG[ii] = i;
                            }
                        }
                        ii++;
                    }

                    #endregion

                    //for (int i = 0; i < 15; i++)
                    //{
                    //    kuchki[i] = 0;
                    //}
                    //kuchki[0] = rd;


                    /////Вспомогалочка

                    countbut = 0;

                    for (int i = 0; i < 29; i++)
                    {
                        pictures2[i].Image = imagesBig2[i];
                        pictures2[i].Visible = true;
                    }

                    for (int i = 0; i < 29; i++)
                    {
                        //pictures2[i].Image = imagesBig2[i];
                        pictures2[i].Visible = false;
                    }
                    for (int i = 0; i < 15; i++)
                    {
                        buttonsBlue[i].Visible = true;
                        buttonsBlue[i].Width = 85;
                    }
                    for (int i = 0; i < 15; i++)
                    {
                        buttonsBlue[i].Visible = false;
                    }

                    button26.Visible = false;

                    for (int i = 0; i < 15; i++)
                    {
                        buttonsRed[i].Visible = false;
                        buttonsRed[i].Width = 85;
                    }

                    button27.Visible = false;


                    

                    Bitmap bmp = new Bitmap(global::WindowsFormsApplication1.Properties.Resources.ИК_доп_фон22);
                    Graphics g = Graphics.FromImage(bmp);
                    Graphics g2 = Graphics.FromImage(bmp);
                    Pen p2 = new Pen(Color.Red);
                    Pen p = new Pen(Color.Blue);
                    pictureBox31.Image = bmp;
                    p.Width = 4;
                    p2.Width = 4;

                    button26.Visible = true;
                    button27.Visible = true;


                    int c1 = 0;
                    ii = 0;
                    int num = 0;
                    bool flag1 = false;
                    while (ii < 29)
                    {
                        if (pictures[ii].Visible == true)
                        {
                            c1++;
                            flag1 = true;
                            pictures2[ii].Visible = true;
                            pictures2[ii].Image = imagesBig2[ii];
                        }
                        else
                        {
                            if (flag1 == true)
                            {
                                kuchki[num] = c1;
                                flag1 = false;
                                num++;
                            }
                            c1 = 0;
                        }
                        ii++;
                    }

                    for (int i = 0; i < num; i++)
                    {
                        buttonsBlue[i].Text = "SG[" + Convert.ToString(kuchki[i]) + "] = " + Convert.ToString(SG[kuchki[i]]);
                    }

                    int[] myhelp1 = new int[15];
                    for (int i = 0; i < num; i++)
                    {
                        myhelp1[i] = SG[kuchki[i]];
                    }

                    button26.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp1));
                    

                    int c2 = 0;
                    int ii2 = 0;
                    int kap = 0;
                    bool flag2 = false;

                    while (ii2 <= 29)
                    {
                        if ((ii2 < 29) && (pictures[ii2].Visible == true))
                        {
                            c2++;
                            flag2 = true;
                        }
                        else
                        {
                            if (flag2 == true)
                            {
                                g.DrawLine(p, pictures[ii2 - 1].Location.X + 40, 92, pictures[ii2 - 1].Location.X + 40, 80);
                                g.DrawLine(p, pictures[ii2 - 1].Location.X + 40, 80, pictures[ii2 - c2].Location.X - 5, 80);
                                g.DrawLine(p, pictures[ii2 - c2].Location.X - 5, 80, pictures[ii2 - c2].Location.X - 5, 92);
                                buttonsBlue[kap].Visible = true;
                                buttonsBlue[kap].Location = new Point(pictures[ii2 - c2].Location.X - 5, 393);

                                kap++;
                                flag2 = false;
                            }
                            c2 = 0;
                        }
                        ii2++;
                    }

                    ///Ход компьютера
                    ///////////////////////////////////////

                    if (rd % 2 == 1)
                    {
                        pictures[rd / 2].Visible = false;
                        pictures2[rd / 2].Visible = true;
                        pictures2[rd / 2].Image = imagesSmall2[rd / 2];

                    }
                    else
                    {
                        pictures[(rd / 2) - 1].Visible = false;
                        pictures[(rd / 2)].Visible = false;
                        pictures2[(rd / 2) - 1].Visible = true;
                        pictures2[(rd / 2) - 1].Image = imagesSmall2[(rd / 2) - 1];
                        pictures2[rd / 2].Visible = true;
                        pictures2[rd / 2].Image = imagesSmall2[rd / 2];
                    }

                    int[] myhelp2 = new int[15];
                    int[] myhelp3 = new int[15];


                    c1 = 0;
                    ii = 0;
                    num = 0;
                    flag1 = false;
                    while (ii < 29)
                    {
                        if (pictures[ii].Visible == true)
                        {
                            c1++;
                            flag1 = true;
                            pictures2[ii].Visible = true;
                            pictures2[ii].Image = imagesBig2[ii];
                        }
                        else
                        {
                            if (flag1 == true)
                            {
                                myhelp2[num] = c1;
                                flag1 = false;
                                num++;
                            }
                            c1 = 0;
                        }
                        ii++;
                    }

                    for (int i = 0; i < num; i++)
                    {
                        buttonsRed[i].Text = "SG[" + Convert.ToString(myhelp2[i]) + "] = " + Convert.ToString(SG[myhelp2[i]]);
                        myhelp3[i] = SG[myhelp2[i]];
                    }
                    button27.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp3));

                    c2 = 0;
                    ii2 = 0;
                    flag2 = false;
                    kap = 0;
                    while (ii2 <= 29)
                    {
                        if ((ii2 < 29) && (pictures[ii2].Visible == true))
                        {
                            c2++;
                            flag2 = true;
                        }
                        else
                        {
                            if (flag2 == true)
                            {
                                g.DrawLine(p2, pictures[ii2 - 1].Location.X + 40, 274, pictures[ii2 - 1].Location.X + 40, 286);
                                g.DrawLine(p2, pictures[ii2 - 1].Location.X + 40, 286, pictures[ii2 - c2].Location.X - 5, 286);
                                g.DrawLine(p2, pictures[ii2 - c2].Location.X - 5, 286, pictures[ii2 - c2].Location.X - 5, 274);
                                buttonsRed[kap].Visible = true;
                                buttonsRed[kap].Location = new Point(pictures[ii2 - c2].Location.X - 5, 640);

                                kap++;
                                flag2 = false;
                            }
                            c2 = 0;
                        }
                        ii2++;
                    }

                    if (label1.Text == "2")
                    {
                        for (int i = 0; i < 29; i++)
                        {
                            pictures2[i].Image = imagesBig2[i];
                        }
                        for (int i = 0; i < 29; i++)
                        {
                            if (pictures[i].Visible == false)
                            {
                                pictures2[i].Visible = false;
                            }
                        }
                    }


                    #endregion
                }
            }

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if ((r1 == true) || (r2 == true) || (r3 == true) || (label1.Text == "3"))
            {

                if (label1.Text == "2")
                {
                    button26.Visible = true;
                    button27.Visible = true;
                    for (int i = 0; i < 15; i++)
                    {
                        
                    }
                }

                int k = 0;
                string s = (sender as PictureBox).Name;

                bool f = false;
                for (int i = 0; i < 29; i++)
                {
                    if (f == false)
                        k++;
                    if (pictures[i].Name == s)
                        f = true;

                }

                if (pictures[k - 1].Visible == true)
                {
                    int c1 = 0;
                    for (int i = 0; i < 29; i++)
                    {
                        if ((pictures[i].Visible == true) && (pictures[i].Image == imagesSmall[i]))
                        {
                            c1++;
                        }
                    }

                    if (c1 == 2)
                    {
                        for (int i = 0; i <29; i++)
                        {
                            if (pictures[i].Visible == true)
                            {
                                pictures[i].Image = imagesBig[i];
                            }
                        }

                        pictures[k - 1].Image = imagesSmall[k - 1];

                        if (label1.Text == "2")
                        {
                            for (int i = 0; i < 29; i++)
                            {
                                if (pictures[i].Visible == true)
                                {
                                    pictures2[i].Visible = true;

                                }
                                pictures2[i].Image = imagesBig2[i];
                            }

                            #region 

                            pictures2[k - 1].Image = imagesSmall2[k - 1];

                            Bitmap bmp = new Bitmap(global::WindowsFormsApplication1.Properties.Resources.ИК_доп_фон22);
                            Graphics g = Graphics.FromImage(bmp);
                            Graphics g2 = Graphics.FromImage(bmp);
                            Pen p2 = new Pen(Color.Red);
                            Pen p = new Pen(Color.Blue);
                            pictureBox31.Image = bmp;
                            p.Width = 4;
                            p2.Width = 4;

                            button26.Visible = true;
                            button27.Visible = true;

                            int cc1 = 0;
                            int ii = 0;
                            int num = 0;
                            bool flag1 = false;
                            while (ii < 29)
                            {
                                if (pictures[ii].Visible == true)
                                {
                                    cc1++;
                                    flag1 = true;
                                }
                                else
                                {
                                    if (flag1 == true)
                                    {
                                        kuchki[num] = cc1;
                                        flag1 = false;
                                        num++;
                                    }
                                    cc1 = 0;
                                }
                                ii++;
                            }

                            for (int i = 0; i < num; i++)
                            {
                                buttonsBlue[i].Text = "SG[" + Convert.ToString(kuchki[i]) + "] = " + Convert.ToString(SG[kuchki[i]]);
                            }

                            int[] myhelp1 = new int[15];
                            for (int i = 0; i < num; i++)
                            {
                                myhelp1[i] = SG[kuchki[i]];
                            }

                            button26.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp1));


                            int c2 = 0;
                            int ii2 = 0;
                            int kap = 0;
                            bool flag2 = false;

                            while (ii2 <= 29)
                            {
                                if ((ii2 < 29) && (pictures[ii2].Visible == true))
                                {
                                    c2++;
                                    flag2 = true;
                                }
                                else
                                {
                                    if (flag2 == true)
                                    {
                                        g.DrawLine(p, pictures[ii2 - 1].Location.X + 40, 92, pictures[ii2 - 1].Location.X + 40, 80);
                                        g.DrawLine(p, pictures[ii2 - 1].Location.X + 40, 80, pictures[ii2 - c2].Location.X - 5, 80);
                                        g.DrawLine(p, pictures[ii2 - c2].Location.X - 5, 80, pictures[ii2 - c2].Location.X - 5, 92);
                                        buttonsBlue[kap].Visible = true;
                                        buttonsBlue[kap].Location = new Point(pictures[ii2 - c2].Location.X - 5, 393);

                                        kap++;
                                        flag2 = false;
                                    }
                                    c2 = 0;
                                }
                                ii2++;
                            }

                            ////////////////////////////////////

                            int[] myhelp2 = new int[15];
                            int[] myhelp3 = new int[15];


                            c1 = 0;
                            ii = 0;
                            num = 0;
                            flag1 = false;
                            while (ii < 29)
                            {
                                if ((pictures2[ii].Image == imagesBig2[ii]) && (pictures2[ii].Visible == true))
                                {
                                    c1++;
                                    flag1 = true;
                                }
                                else
                                {
                                    if (flag1 == true)
                                    {
                                        myhelp2[num] = c1;
                                        flag1 = false;
                                        num++;
                                    }
                                    c1 = 0;
                                }
                                ii++;
                            }

                            for (int i = 0; i < num; i++)
                            {
                                buttonsRed[i].Text = "SG[" + Convert.ToString(myhelp2[i]) + "] = " + Convert.ToString(SG[myhelp2[i]]);
                                myhelp3[i] = SG[myhelp2[i]];
                            }
                            button27.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp3));

                            c2 = 0;
                            ii2 = 0;
                            flag2 = false;
                            kap = 0;
                            while (ii2 <= 29)
                            {
                                if ((ii2 < 29) && (pictures2[ii2].Image == imagesBig2[ii2]) && (pictures2[ii2].Visible == true))
                                {
                                    c2++;
                                    flag2 = true;
                                }
                                else
                                {
                                    if (flag2 == true)
                                    {
                                        g.DrawLine(p2, pictures[ii2 - 1].Location.X + 40, 274, pictures[ii2 - 1].Location.X + 40, 286);
                                        g.DrawLine(p2, pictures[ii2 - 1].Location.X + 40, 286, pictures[ii2 - c2].Location.X - 5, 286);
                                        g.DrawLine(p2, pictures[ii2 - c2].Location.X - 5, 286, pictures[ii2 - c2].Location.X - 5, 274);
                                        buttonsRed[kap].Visible = true;
                                        buttonsRed[kap].Location = new Point(pictures[ii2 - c2].Location.X - 5, 640);

                                        kap++;
                                        flag2 = false;
                                    }
                                    c2 = 0;
                                }
                                ii2++;
                            }

                            #endregion
                        }

                    }
                    else if (c1 == 1)
                    {
                        int numOfOne = 0;
                        for (int i = 0; i < 29; i++)
                        {
                            if ((pictures[i].Visible == true) && (pictures[i].Image == imagesSmall[i]))
                            {
                                numOfOne = i;
                            }
                        }

                        if ((k - 1 == numOfOne - 1) || (k - 1 == numOfOne + 1))
                        {
                            pictures[k - 1].Image = imagesSmall[k - 1];

                            if (label1.Text == "2")
                            {
                                for (int i = 0; i < 29; i++)
                                {
                                    if (pictures[i].Visible == true)
                                    {
                                        pictures2[i].Visible = true;

                                    }
                                   // pictures2[i].Image = imagesBig2[i];
                                }

                                #region

                                pictures2[k - 1].Image = imagesSmall2[k - 1];

                                Bitmap bmp = new Bitmap(global::WindowsFormsApplication1.Properties.Resources.ИК_доп_фон22);
                                Graphics g = Graphics.FromImage(bmp);
                                Graphics g2 = Graphics.FromImage(bmp);
                                Pen p2 = new Pen(Color.Red);
                                Pen p = new Pen(Color.Blue);
                                pictureBox31.Image = bmp;
                                p.Width = 4;
                                p2.Width = 4;

                                button26.Visible = true;
                                button27.Visible = true;

                                int cc1 = 0;
                                int ii = 0;
                                int num = 0;
                                bool flag1 = false;
                                while (ii < 29)
                                {
                                    if (pictures[ii].Visible == true)
                                    {
                                        cc1++;
                                        flag1 = true;
                                    }
                                    else
                                    {
                                        if (flag1 == true)
                                        {
                                            kuchki[num] = cc1;
                                            flag1 = false;
                                            num++;
                                        }
                                        cc1 = 0;
                                    }
                                    ii++;
                                }

                                for (int i = 0; i < num; i++)
                                {
                                    buttonsBlue[i].Text = "SG[" + Convert.ToString(kuchki[i]) + "] = " + Convert.ToString(SG[kuchki[i]]);
                                }

                                int[] myhelp1 = new int[15];
                                for (int i = 0; i < num; i++)
                                {
                                    myhelp1[i] = SG[kuchki[i]];
                                }

                                button26.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp1));


                                int c2 = 0;
                                int ii2 = 0;
                                int kap = 0;
                                bool flag2 = false;

                                while (ii2 <= 29)
                                {
                                    if ((ii2 < 29) && (pictures[ii2].Visible == true))
                                    {
                                        c2++;
                                        flag2 = true;
                                    }
                                    else
                                    {
                                        if (flag2 == true)
                                        {
                                            g.DrawLine(p, pictures[ii2 - 1].Location.X + 40, 92, pictures[ii2 - 1].Location.X + 40, 80);
                                            g.DrawLine(p, pictures[ii2 - 1].Location.X + 40, 80, pictures[ii2 - c2].Location.X - 5, 80);
                                            g.DrawLine(p, pictures[ii2 - c2].Location.X - 5, 80, pictures[ii2 - c2].Location.X - 5, 92);
                                            buttonsBlue[kap].Visible = true;
                                            buttonsBlue[kap].Location = new Point(pictures[ii2 - c2].Location.X - 5, 393);

                                            kap++;
                                            flag2 = false;
                                        }
                                        c2 = 0;
                                    }
                                    ii2++;
                                }

                                ////////////////////////////////////

                                int[] myhelp2 = new int[15];
                                int[] myhelp3 = new int[15];


                                c1 = 0;
                                ii = 0;
                                num = 0;
                                flag1 = false;
                                while (ii < 29)
                                {
                                    if ((pictures2[ii].Image == imagesBig2[ii]) && (pictures2[ii].Visible == true))
                                    {
                                        c1++;
                                        flag1 = true;
                                    }
                                    else
                                    {
                                        if (flag1 == true)
                                        {
                                            myhelp2[num] = c1;
                                            flag1 = false;
                                            num++;
                                        }
                                        c1 = 0;
                                    }
                                    ii++;
                                }

                                for (int i = 0; i < num; i++)
                                {
                                    buttonsRed[i].Text = "SG[" + Convert.ToString(myhelp2[i]) + "] = " + Convert.ToString(SG[myhelp2[i]]);
                                    myhelp3[i] = SG[myhelp2[i]];
                                }
                                button27.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp3));

                                c2 = 0;
                                ii2 = 0;
                                flag2 = false;
                                kap = 0;
                                while (ii2 <= 29)
                                {
                                    if ((ii2 < 29) && (pictures2[ii2].Image == imagesBig2[ii2]) && (pictures2[ii2].Visible == true))
                                    {
                                        c2++;
                                        flag2 = true;
                                    }
                                    else
                                    {
                                        if (flag2 == true)
                                        {
                                            g.DrawLine(p2, pictures[ii2 - 1].Location.X + 40, 274, pictures[ii2 - 1].Location.X + 40, 286);
                                            g.DrawLine(p2, pictures[ii2 - 1].Location.X + 40, 286, pictures[ii2 - c2].Location.X - 5, 286);
                                            g.DrawLine(p2, pictures[ii2 - c2].Location.X - 5, 286, pictures[ii2 - c2].Location.X - 5, 274);
                                            buttonsRed[kap].Visible = true;
                                            buttonsRed[kap].Location = new Point(pictures[ii2 - c2].Location.X - 5, 640);

                                            kap++;
                                            flag2 = false;
                                        }
                                        c2 = 0;
                                    }
                                    ii2++;
                                }

                                #endregion
                            }

                        }
                        else
                        {
                            for (int i = 0; i < 29; i++)
                            {
                                pictures[i].Image = imagesBig[i];
                            }
                            pictures[k - 1].Image = imagesSmall[k - 1];

                            if (label1.Text == "2")
                            {
                                for (int i = 0; i < 29; i++)
                                {
                                    if (pictures[i].Visible == true)
                                    {
                                        pictures2[i].Visible = true;

                                    }
                                    pictures2[i].Image = imagesBig2[i];
                                }

                                #region

                                pictures2[k - 1].Image = imagesSmall2[k - 1];

                                Bitmap bmp = new Bitmap(global::WindowsFormsApplication1.Properties.Resources.ИК_доп_фон22);
                                Graphics g = Graphics.FromImage(bmp);
                                Graphics g2 = Graphics.FromImage(bmp);
                                Pen p2 = new Pen(Color.Red);
                                Pen p = new Pen(Color.Blue);
                                pictureBox31.Image = bmp;
                                p.Width = 4;
                                p2.Width = 4;

                                button26.Visible = true;
                                button27.Visible = true;

                                int cc1 = 0;
                                int ii = 0;
                                int num = 0;
                                bool flag1 = false;
                                while (ii < 29)
                                {
                                    if (pictures[ii].Visible == true)
                                    {
                                        cc1++;
                                        flag1 = true;
                                    }
                                    else
                                    {
                                        if (flag1 == true)
                                        {
                                            kuchki[num] = cc1;
                                            flag1 = false;
                                            num++;
                                        }
                                        cc1 = 0;
                                    }
                                    ii++;
                                }

                                for (int i = 0; i < num; i++)
                                {
                                    buttonsBlue[i].Text = "SG[" + Convert.ToString(kuchki[i]) + "] = " + Convert.ToString(SG[kuchki[i]]);
                                }

                                int[] myhelp1 = new int[15];
                                for (int i = 0; i < num; i++)
                                {
                                    myhelp1[i] = SG[kuchki[i]];
                                }

                                button26.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp1));


                                int c2 = 0;
                                int ii2 = 0;
                                int kap = 0;
                                bool flag2 = false;

                                while (ii2 <= 29)
                                {
                                    if ((ii2 < 29) && (pictures[ii2].Visible == true))
                                    {
                                        c2++;
                                        flag2 = true;
                                    }
                                    else
                                    {
                                        if (flag2 == true)
                                        {
                                            g.DrawLine(p, pictures[ii2 - 1].Location.X + 40, 92, pictures[ii2 - 1].Location.X + 40, 80);
                                            g.DrawLine(p, pictures[ii2 - 1].Location.X + 40, 80, pictures[ii2 - c2].Location.X - 5, 80);
                                            g.DrawLine(p, pictures[ii2 - c2].Location.X - 5, 80, pictures[ii2 - c2].Location.X - 5, 92);
                                            buttonsBlue[kap].Visible = true;
                                            buttonsBlue[kap].Location = new Point(pictures[ii2 - c2].Location.X - 5, 393);

                                            kap++;
                                            flag2 = false;
                                        }
                                        c2 = 0;
                                    }
                                    ii2++;
                                }

                                ////////////////////////////////////

                                int[] myhelp2 = new int[15];
                                int[] myhelp3 = new int[15];


                                c1 = 0;
                                ii = 0;
                                num = 0;
                                flag1 = false;
                                while (ii < 29)
                                {
                                    if ((pictures2[ii].Image == imagesBig2[ii]) && (pictures2[ii].Visible == true))
                                    {
                                        c1++;
                                        flag1 = true;
                                    }
                                    else
                                    {
                                        if (flag1 == true)
                                        {
                                            myhelp2[num] = c1;
                                            flag1 = false;
                                            num++;
                                        }
                                        c1 = 0;
                                    }
                                    ii++;
                                }

                                for (int i = 0; i < num; i++)
                                {
                                    buttonsRed[i].Text = "SG[" + Convert.ToString(myhelp2[i]) + "] = " + Convert.ToString(SG[myhelp2[i]]);
                                    myhelp3[i] = SG[myhelp2[i]];
                                }
                                button27.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp3));

                                c2 = 0;
                                ii2 = 0;
                                flag2 = false;
                                kap = 0;
                                while (ii2 <= 29)
                                {
                                    if ((ii2 < 29) && (pictures2[ii2].Image == imagesBig2[ii2]) && (pictures2[ii2].Visible == true))
                                    {
                                        c2++;
                                        flag2 = true;
                                    }
                                    else
                                    {
                                        if (flag2 == true)
                                        {
                                            g.DrawLine(p2, pictures[ii2 - 1].Location.X + 40, 274, pictures[ii2 - 1].Location.X + 40, 286);
                                            g.DrawLine(p2, pictures[ii2 - 1].Location.X + 40, 286, pictures[ii2 - c2].Location.X - 5, 286);
                                            g.DrawLine(p2, pictures[ii2 - c2].Location.X - 5, 286, pictures[ii2 - c2].Location.X - 5, 274);
                                            buttonsRed[kap].Visible = true;
                                            buttonsRed[kap].Location = new Point(pictures[ii2 - c2].Location.X - 5, 640);

                                            kap++;
                                            flag2 = false;
                                        }
                                        c2 = 0;
                                    }
                                    ii2++;
                                }

                                #endregion
                            }
                        }

                    }
                    else if (c1 == 0)
                    {
                        pictures[k - 1].Image = imagesSmall[k - 1];

                        if (label1.Text == "2")
                        {
                            for (int i = 0; i < 29; i++)
                            {
                                if (pictures[i].Visible == true)
                                {
                                    pictures2[i].Visible = true;

                                }
                                pictures2[i].Image = imagesBig2[i];
                            }

                            #region

                            pictures2[k - 1].Image = imagesSmall2[k - 1];

                            Bitmap bmp = new Bitmap(global::WindowsFormsApplication1.Properties.Resources.ИК_доп_фон22);
                            Graphics g = Graphics.FromImage(bmp);
                            Graphics g2 = Graphics.FromImage(bmp);
                            Pen p2 = new Pen(Color.Red);
                            Pen p = new Pen(Color.Blue);
                            pictureBox31.Image = bmp;
                            p.Width = 4;
                            p2.Width = 4;

                            button26.Visible = true;
                            button27.Visible = true;

                            int cc1 = 0;
                            int ii = 0;
                            int num = 0;
                            bool flag1 = false;
                            while (ii < 29)
                            {
                                if (pictures[ii].Visible == true)
                                {
                                    cc1++;
                                    flag1 = true;
                                }
                                else
                                {
                                    if (flag1 == true)
                                    {
                                        kuchki[num] = cc1;
                                        flag1 = false;
                                        num++;
                                    }
                                    cc1 = 0;
                                }
                                ii++;
                            }

                            for (int i = 0; i < num; i++)
                            {
                                buttonsBlue[i].Text = "SG[" + Convert.ToString(kuchki[i]) + "] = " + Convert.ToString(SG[kuchki[i]]);
                            }

                            int[] myhelp1 = new int[15];
                            for (int i = 0; i < num; i++)
                            {
                                myhelp1[i] = SG[kuchki[i]];
                            }

                            button26.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp1));


                            int c2 = 0;
                            int ii2 = 0;
                            int kap = 0;
                            bool flag2 = false;

                            while (ii2 <= 29)
                            {
                                if ((ii2 < 29) && (pictures[ii2].Visible == true))
                                {
                                    c2++;
                                    flag2 = true;
                                }
                                else
                                {
                                    if (flag2 == true)
                                    {
                                        g.DrawLine(p, pictures[ii2 - 1].Location.X + 40, 92, pictures[ii2 - 1].Location.X + 40, 80);
                                        g.DrawLine(p, pictures[ii2 - 1].Location.X + 40, 80, pictures[ii2 - c2].Location.X - 5, 80);
                                        g.DrawLine(p, pictures[ii2 - c2].Location.X - 5, 80, pictures[ii2 - c2].Location.X - 5, 92);
                                        buttonsBlue[kap].Visible = true;
                                        buttonsBlue[kap].Location = new Point(pictures[ii2 - c2].Location.X - 5, 393);

                                        kap++;
                                        flag2 = false;
                                    }
                                    c2 = 0;
                                }
                                ii2++;
                            }

                            ////////////////////////////////////

                            int[] myhelp2 = new int[15];
                            int[] myhelp3 = new int[15];


                            c1 = 0;
                            ii = 0;
                            num = 0;
                            flag1 = false;
                            while (ii < 29)
                            {
                                if ((pictures2[ii].Image == imagesBig2[ii]) && (pictures2[ii].Visible == true))
                                {
                                    c1++;
                                    flag1 = true;
                                }
                                else
                                {
                                    if (flag1 == true)
                                    {
                                        myhelp2[num] = c1;
                                        flag1 = false;
                                        num++;
                                    }
                                    c1 = 0;
                                }
                                ii++;
                            }

                            for (int i = 0; i < num; i++)
                            {
                                buttonsRed[i].Text = "SG[" + Convert.ToString(myhelp2[i]) + "] = " + Convert.ToString(SG[myhelp2[i]]);
                                myhelp3[i] = SG[myhelp2[i]];
                            }
                            button27.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp3));

                            c2 = 0;
                            ii2 = 0;
                            flag2 = false;
                            kap = 0;
                            while (ii2 <= 29)
                            {
                                if ((ii2 < 29) && (pictures2[ii2].Image == imagesBig2[ii2]) && (pictures2[ii2].Visible == true))
                                {
                                    c2++;
                                    flag2 = true;
                                }
                                else
                                {
                                    if (flag2 == true)
                                    {
                                        g.DrawLine(p2, pictures[ii2 - 1].Location.X + 40, 274, pictures[ii2 - 1].Location.X + 40, 286);
                                        g.DrawLine(p2, pictures[ii2 - 1].Location.X + 40, 286, pictures[ii2 - c2].Location.X - 5, 286);
                                        g.DrawLine(p2, pictures[ii2 - c2].Location.X - 5, 286, pictures[ii2 - c2].Location.X - 5, 274);
                                        buttonsRed[kap].Visible = true;
                                        buttonsRed[kap].Location = new Point(pictures[ii2 - c2].Location.X - 5, 640);

                                        kap++;
                                        flag2 = false;
                                    }
                                    c2 = 0;
                                }
                                ii2++;
                            }

                            #endregion
                        }
                    }
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (r1 == true)
            {
                #region

                int k = 0;
                string s = (sender as PictureBox).Name;

                int c1 = 0;
                for (int i = 0; i < 29; i++)
                {
                    if ((pictures[i].Visible == true) && (pictures[i].Image == imagesSmall[i]))
                    {
                        pictures[i].Visible = false;
                    }
                }

                for (int i = 0; i < 29; i++)
                {
                    if (pictures[i].Visible == true)
                    {
                        c1++;
                    }
                }

                if (c1 == 0)
                {
                    button10.Visible = true;
                    button7.Visible = false;
                    button8.Visible = false;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_хотите_сыграть_еще;
                    button5.Visible = true;
                    button6.Visible = true;

                    this.ClientSize = new System.Drawing.Size(560, 440);
                    this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                    (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                    if (globcount % 2 == 1)
                    {
                        button10.Text = name1;
                    }
                    else
                    {
                        button10.Text = name2;
                    }
                }
                else
                {
                    globcount++;
                    if (globcount % 2 == 1)
                    {
                        button7.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_чей_ход;
                        button8.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_для_имен;
                    }
                    else
                    {
                        button8.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_чей_ход;
                        button7.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_для_имен;
                    }
                }

                
                #endregion
            }

            if (r2 == true) 
            {
                #region
                if ((label1.Text == "1") || (label1.Text == "2"))
                {

                    for (int i = 0; i < 29; i++)
                    {
                        pictures2[i].Visible = false;
                    }

                    for (int i = 0; i < 15; i++)
                    {
                        buttonsBlue[i].Visible = false;
                    }
                    button26.Visible = true;
                    for (int i = 0; i < 15; i++)
                    {
                        buttonsRed[i].Visible = false;
                    }
                    button27.Visible = true;
                }

                if (label1.Text == "2")
                {
                    for (int i = 0; i < 29; i++)
                    {
                        pictures2[i].Image = imagesBig2[i];
                    }
                }

                string s = (sender as PictureBox).Name;
                helppictures.Clear();

                //Ход человека
                //////////////////////////////////////////

                for (int i = 0; i < 29; i++)
                {
                    if ((pictures[i].Visible == true) && (pictures[i].Image == imagesSmall[i]))
                    {
                        pictures[i].Visible = false;
                    }
                }

                int ccon = 0;
                for (int i = 0; i < 29; i++)
                {
                    if (pictures[i].Visible == true) 
                    {
                        ccon++;
                    }
                }

                if (ccon == 0)
                {
                    button10.Visible = true;
                    button7.Visible = false;
                    button8.Visible = false;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_хотите_сыграть_еще;
                    button5.Visible = true;
                    button6.Visible = true;

                    this.ClientSize = new System.Drawing.Size(560, 440);
                    this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                    (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
                    pictureBox1.Size = new System.Drawing.Size(560, 440);
                    pictureBox31.Visible = false;


                    button10.Text = name1;
                    button9.Visible = false;

                    for (int i = 0; i < 15; i++)
                    {
                        buttonsBlue[i].Visible = false;
                    }

                    button26.Visible = false;
                    button27.Visible = false;
                    button7.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_для_имен;
                    button8.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_для_имен;

                }
                else
                {
                        Bitmap bmp = new Bitmap(global::WindowsFormsApplication1.Properties.Resources.ИК_доп_фон22);
                        Graphics g = Graphics.FromImage(bmp);
                        Graphics g2 = Graphics.FromImage(bmp);
                        Pen p2 = new Pen(Color.Red);
                        Pen p = new Pen(Color.Blue);
                        pictureBox31.Image = bmp;
                        p.Width = 4;
                        p2.Width = 4;
                    
                    

                    //Расчеты для хода компьютера
                    //////////////////////////////////////////

                    int c1 = 0;
                    int ii = 0;
                    int num = 0;
                    bool flag1 = false;
                    while (ii < 29)
                    {
                        if (pictures[ii].Visible == true)
                        {
                            c1++;
                            flag1 = true;
                            pictures2[ii].Visible = true;
                            pictures2[ii].Image = imagesBig2[ii];
                        }
                        else
                        {
                            if (flag1 == true)
                            {
                                kuchki[num] = c1;
                                flag1 = false;
                                num++;
                            }
                            c1 = 0;
                        }
                        ii++;
                    }

                    if (label1.Text == "1")
                    {
                        for (int i = 0; i < num; i++)
                        {
                            buttonsBlue[i].Text = "SG[" + Convert.ToString(kuchki[i]) + "] = " + Convert.ToString(SG[kuchki[i]]);
                        }

                        int[] myhelp1 = new int[15];
                        for (int i = 0; i < num; i++)
                        {
                            myhelp1[i] = SG[kuchki[i]];
                        }

                        button26.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp1));

                    }
                    #region

                    ii = 0;
                    int dlina = 0;
                    bool flag = false;
                    bool[] stress = new bool[30];
                    int[] result = new int[15];
                    for (int i = 0; i < 15; i++)
                    {
                        result[i] = 0;
                    }
                    while ((ii < num) && (flag == false))
                    {
                        int right = 0, left = 0;
                        bool[] fl = new bool[30];
                        int res = 0;
                        int[] forsum = new int[15];
                        for (int i = 0; i < 30; i++)
                        {
                            fl[i] = false;
                            if (i < 15)
                                forsum[i] = 0;
                        }

                        for (int j = 1; j <= kuchki[ii]; j++)
                        {
                            right = j - 1;
                            left = kuchki[ii] - j;
                            forsum[0] = SG[right];
                            forsum[1] = SG[left];
                            int ll = 2;
                            for (int l = 0; l < num; l++)
                            {
                                if (l != ii)
                                {
                                    forsum[ll] = SG[kuchki[l]];
                                    ll++;
                                }
                            }
                            //fl[NimSum(forsum)] = true;
                            res = NimSum(forsum);
                            if (res == 0)
                            {
                                for (int i = 0; i < kuchki[ii]; i++)
                                {
                                    stress[i] = false;
                                }
                                for (int i = 0; i < right; i++)
                                {
                                    stress[i] = true;
                                }
                                for (int i = kuchki[ii] - 1; i > kuchki[ii] - 1 - left; i--)
                                {
                                    stress[i] = true;
                                }
                                dlina = kuchki[ii];

                                flag = true;
                                int jj = 0;
                                while (jj < ii)
                                {
                                    result[jj] = kuchki[jj];
                                    jj++;
                                }
                                result[ii] = right;
                                result[ii + 1] = left;
                                jj = ii + 2;
                                while (jj < num + 1)
                                {
                                    result[jj] = kuchki[jj - 1];
                                    jj++;
                                }

                            }

                        }

                        for (int j = 2; j <= kuchki[ii]; j++)
                        {
                            right = j - 2;
                            left = kuchki[ii] - j;
                            forsum[0] = SG[right];
                            forsum[1] = SG[left];
                            int ll = 2;
                            for (int l = 0; l < num; l++)
                            {
                                if (l != ii)
                                {
                                    forsum[ll] = SG[kuchki[l]];
                                    ll++;
                                }
                            }
                            res = NimSum(forsum);

                            if (res == 0)
                            {
                                for (int i = 0; i < kuchki[ii]; i++)
                                {
                                    stress[i] = false;
                                }
                                for (int i = 0; i < right; i++)
                                {
                                    stress[i] = true;
                                }
                                for (int i = kuchki[ii] - 1; i > kuchki[ii] - 1 - left; i--)
                                {
                                    stress[i] = true;
                                }
                                dlina = kuchki[ii];

                                flag = true;
                                int jj = 0;
                                while (jj < ii)
                                {
                                    result[jj] = kuchki[jj];
                                    jj++;
                                }
                                result[ii] = right;
                                result[ii + 1] = left;
                                jj = ii + 2;
                                while (jj < num + 1)
                                {
                                    result[jj] = kuchki[jj - 1];
                                    jj++;
                                }

                            }
                        }

                        ii++;
                    }

                    #endregion

                    if (label1.Text == "1")
                    {
                        int c2 = 0;
                        int ii2 = 0;
                        int kap = 0;
                        bool flag2 = false;

                        while (ii2 <= 29)
                        {
                            if ((ii2 < 29) && (pictures[ii2].Visible == true))
                            {
                                c2++;
                                flag2 = true;
                            }
                            else
                            {
                                if (flag2 == true)
                                {
                                    g.DrawLine(p, pictures[ii2 - 1].Location.X + 40, 92, pictures[ii2 - 1].Location.X + 40, 80);
                                    g.DrawLine(p, pictures[ii2 - 1].Location.X + 40, 80, pictures[ii2 - c2].Location.X - 5, 80);
                                    g.DrawLine(p, pictures[ii2 - c2].Location.X - 5, 80, pictures[ii2 - c2].Location.X - 5, 92);
                                    buttonsBlue[kap].Visible = true;
                                    buttonsBlue[kap].Location = new Point(pictures[ii2 - c2].Location.X - 5, 393);

                                    kap++;
                                    flag2 = false;
                                }
                                c2 = 0;
                            }
                            ii2++;
                        }

                    }

                    
                    

                    //button27.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp2));

                    //Ход компьютера
                    //////////////////////////////////////////

                    if (flag == true)
                    {
                        int c2 = 0;
                        int ii2 = 0;
                        int num2 = 0;
                        bool flag2 = false;
                        while (ii2 < 29)
                        {
                            if (pictures[ii2].Visible == true)
                            {
                                c2++;
                                flag2 = true;
                            }
                            else
                            {
                                if (flag2 == true)
                                {
                                    if (result[num2] != c2)
                                    {
                                        int kk = dlina - 1;
                                        for (int i = ii2 - 1; i >= ii2 - dlina; i--)
                                        {
                                            if (stress[kk] == false)
                                            {
                                                pictures[i].Visible = false;
                                                pictures2[i].Image = imagesSmall2[i];
                                            }
                                            kk--;
                                        }
                                        num2 = num2 + 2;
                                    }
                                    else num2++;

                                    flag2 = false;

                                }
                                c2 = 0;
                            }
                            ii2++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 29; i++)
                        {
                            if (pictures[i].Visible == true)
                            {
                                helppictures.Add(pictures[i]);
                                //helppictures2.Add(pictures2[i]);
                                //imagesSmall22.Add(imagesSmall2[i]);
                            }
                        }

                        Random rand = new Random();
                        int temp = rand.Next(helppictures.Count);
                        helppictures[temp].Visible = false;
                        //helppictures2[temp].Image = imagesSmall22[temp];
                        for (int i = 0; i < 29; i++)
                        {
                            if ((pictures[i].Visible == false) && (pictures2[i].Visible == true))
                            {
                                pictures2[i].Image = imagesSmall2[i];
                            }
                        }

                    }
                    if (label1.Text == "1")
                    {
                        int[] myhelp2 = new int[15];
                        int[] myhelp3 = new int[15];


                        c1 = 0;
                        ii = 0;
                        num = 0;
                        flag1 = false;
                        while (ii < 29)
                        {
                            if (pictures[ii].Visible == true)
                            {
                                c1++;
                                flag1 = true;
                                pictures2[ii].Visible = true;
                                pictures2[ii].Image = imagesBig2[ii];
                            }
                            else
                            {
                                if (flag1 == true)
                                {
                                    myhelp2[num] = c1;
                                    flag1 = false;
                                    num++;
                                }
                                c1 = 0;
                            }
                            ii++;
                        }

                        for (int i = 0; i < num; i++)
                        {
                            buttonsRed[i].Text = "SG[" + Convert.ToString(myhelp2[i]) + "] = " + Convert.ToString(SG[myhelp2[i]]);
                            myhelp3[i] = SG[myhelp2[i]];
                        }
                        button27.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp3));

                        int c2 = 0;
                        int ii2 = 0;
                        bool flag2 = false;
                        int kap = 0;
                        while (ii2 <= 29)
                        {
                            if ((ii2 < 29) && (pictures[ii2].Visible == true))
                            {
                                c2++;
                                flag2 = true;
                            }
                            else
                            {
                                if (flag2 == true)
                                {
                                    g.DrawLine(p2, pictures[ii2 - 1].Location.X + 40, 274, pictures[ii2 - 1].Location.X + 40, 286);
                                    g.DrawLine(p2, pictures[ii2 - 1].Location.X + 40, 286, pictures[ii2 - c2].Location.X - 5, 286);
                                    g.DrawLine(p2, pictures[ii2 - c2].Location.X - 5, 286, pictures[ii2 - c2].Location.X - 5, 274);
                                    buttonsRed[kap].Visible = true;
                                    buttonsRed[kap].Location = new Point(pictures[ii2 - c2].Location.X - 5, 640);

                                    kap++;
                                    flag2 = false;
                                }
                                c2 = 0;
                            }
                            ii2++;
                        }
                    }

                    ccon = 0;
                    for (int i = 0; i < 29; i++)
                    {
                        if (pictures[i].Visible == true)
                        {
                            ccon++;
                        }
                    }

                    if (label1.Text == "2")
                    {
                        for (int i = 0; i < 29; i++)
                        {
                            pictures2[i].Image = imagesBig2[i];
                        }
                        for (int i = 0; i < 29; i++)
                        {
                            if (pictures[i].Visible == false)
                            {
                                pictures2[i].Visible = false;
                            }
                        }
                    }

                    if (ccon == 0)
                    {
                        button10.Visible = true;
                        button7.Visible = false;
                        button8.Visible = false;
                        pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_хотите_сыграть_еще;
                        button5.Visible = true;
                        button6.Visible = true;

                        this.ClientSize = new System.Drawing.Size(560, 440);
                        this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                        (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
                        pictureBox1.Size = new System.Drawing.Size(560, 440);

                        button9.Visible = false;

                        button10.Text = name2;

                        pictureBox31.Visible = false;

                        for (int i = 0; i < 15; i++)
                        {
                            buttonsBlue[i].Visible = false;
                        }

                        button7.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_для_имен;
                        button8.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_для_имен;

                        button26.Visible = false;
                        button27.Visible = false;
                    }
                }
                #endregion
            }

            if (r3 == true)
            {
                #region
                if ((label1.Text == "1") || (label1.Text == "2"))
                {
                    for (int i = 0; i < 29; i++)
                    {
                        pictures2[i].Visible = false;
                    }

                    for (int i = 0; i < 15; i++)
                    {
                        buttonsBlue[i].Visible = false;
                    }
                    button26.Visible = true;
                    for (int i = 0; i < 15; i++)
                    {
                        buttonsRed[i].Visible = false;
                    }
                    button27.Visible = true;
                }

                string s = (sender as PictureBox).Name;
                helppictures.Clear();

                //Ход человека
                //////////////////////////////////////////

                for (int i = 0; i < 29; i++)
                {
                    if ((pictures[i].Visible == true) && (pictures[i].Image == imagesSmall[i]))
                    {
                        pictures[i].Visible = false;
                    }
                }

                int ccon = 0;
                for (int i = 0; i < 29; i++)
                {
                    if (pictures[i].Visible == true) 
                    {
                        ccon++;
                    }
                }

                if (ccon == 0)
                {
                    button10.Visible = true;
                    button7.Visible = false;
                    button8.Visible = false;
                    pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_хотите_сыграть_еще;
                    button5.Visible = true;
                    button6.Visible = true;

                    this.ClientSize = new System.Drawing.Size(560, 440);
                    this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                    (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                    button10.Text = name2;

                    button9.Visible = false;

                    button10.Text = name2;

                    pictureBox31.Visible = false;

                    for (int i = 0; i < 15; i++)
                    {
                        buttonsBlue[i].Visible = false;
                    }
                    button7.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_для_имен;
                    button8.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_для_имен;
                    button26.Visible = false;
                    button27.Visible = false;


                }
                /////Ход Компьютера
                ///////////////////////////////////
                else
                {


                    Bitmap bmp = new Bitmap(global::WindowsFormsApplication1.Properties.Resources.ИК_доп_фон22);
                    Graphics g = Graphics.FromImage(bmp);
                    Graphics g2 = Graphics.FromImage(bmp);
                    Pen p2 = new Pen(Color.Red);
                    Pen p = new Pen(Color.Blue);
                    pictureBox31.Image = bmp;
                    p.Width = 4;
                    p2.Width = 4;



                    //Расчеты для хода компьютера
                    //////////////////////////////////////////

                    int c1 = 0;
                    int ii = 0;
                    int num = 0;
                    bool flag1 = false;
                    while (ii < 29)
                    {
                        if (pictures[ii].Visible == true)
                        {
                            c1++;
                            flag1 = true;
                            pictures2[ii].Visible = true;
                            pictures2[ii].Image = imagesBig2[ii];
                        }
                        else
                        {
                            if (flag1 == true)
                            {
                                kuchki[num] = c1;
                                flag1 = false;
                                num++;
                            }
                            c1 = 0;
                        }
                        ii++;
                    }

                    if (label1.Text == "1")
                    {

                        for (int i = 0; i < num; i++)
                        {
                            buttonsBlue[i].Text = "SG[" + Convert.ToString(kuchki[i]) + "] = " + Convert.ToString(SG[kuchki[i]]);
                        }

                        int[] myhelp1 = new int[15];
                        for (int i = 0; i < num; i++)
                        {
                            myhelp1[i] = SG[kuchki[i]];
                        }

                        button26.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp1));



                        int c2 = 0;
                        int ii2 = 0;
                        int kap = 0;
                        bool flag2 = false;

                        while (ii2 <= 29)
                        {
                            if ((ii2 < 29) && (pictures[ii2].Visible == true))
                            {
                                c2++;
                                flag2 = true;
                            }
                            else
                            {
                                if (flag2 == true)
                                {
                                    g.DrawLine(p, pictures[ii2 - 1].Location.X + 40, 92, pictures[ii2 - 1].Location.X + 40, 80);
                                    g.DrawLine(p, pictures[ii2 - 1].Location.X + 40, 80, pictures[ii2 - c2].Location.X - 5, 80);
                                    g.DrawLine(p, pictures[ii2 - c2].Location.X - 5, 80, pictures[ii2 - c2].Location.X - 5, 92);
                                    buttonsBlue[kap].Visible = true;
                                    buttonsBlue[kap].Location = new Point(pictures[ii2 - c2].Location.X - 5, 393);

                                    kap++;
                                    flag2 = false;
                                }
                                c2 = 0;
                            }
                            ii2++;
                        }

                    }

                    if (rd % 2 == 1)
                    {
                        for (int i = 0, j = rd - 1; i < j; i++, j--)
                        {
                            if ((pictures[i].Visible == true) && (pictures[j].Visible == false))
                            {
                                pictures[i].Visible = false;
                                pictures2[i].Image = imagesSmall2[i];
                            }
                            else
                            if ((pictures[i].Visible == false) && (pictures[j].Visible == true))
                            {
                                pictures[j].Visible = false;
                                pictures2[j].Image = imagesSmall2[j];
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0, j = rd - 1; i < j; i++, j--)
                        {
                            if ((pictures[i].Visible == true) && (pictures[j].Visible == false))
                            {
                                pictures[i].Visible = false;
                                pictures2[i].Image = imagesSmall2[i];
                            }
                            else
                                if ((pictures[i].Visible == false) && (pictures[j].Visible == true))
                                {
                                    pictures[j].Visible = false;
                                    pictures2[j].Image = imagesSmall2[j];
                                }
                        }
                    }

                    if (label1.Text == "1")
                    {
                        int[] myhelp2 = new int[15];
                        int[] myhelp3 = new int[15];


                        c1 = 0;
                        ii = 0;
                        num = 0;
                        flag1 = false;
                        while (ii < 29)
                        {
                            if (pictures[ii].Visible == true)
                            {
                                c1++;
                                flag1 = true;
                                pictures2[ii].Visible = true;
                                pictures2[ii].Image = imagesBig2[ii];
                            }
                            else
                            {
                                if (flag1 == true)
                                {
                                    myhelp2[num] = c1;
                                    flag1 = false;
                                    num++;
                                }
                                c1 = 0;
                            }
                            ii++;
                        }

                        for (int i = 0; i < num; i++)
                        {
                            buttonsRed[i].Text = "SG[" + Convert.ToString(myhelp2[i]) + "] = " + Convert.ToString(SG[myhelp2[i]]);
                            myhelp3[i] = SG[myhelp2[i]];
                        }
                        button27.Text = "Ним сумма = " + Convert.ToString(NimSum(myhelp3));

                        int c2 = 0;
                        int ii2 = 0;
                        bool flag2 = false;
                        int kap = 0;
                        while (ii2 <= 29)
                        {
                            if ((ii2 < 29) && (pictures[ii2].Visible == true))
                            {
                                c2++;
                                flag2 = true;
                            }
                            else
                            {
                                if (flag2 == true)
                                {
                                    g.DrawLine(p2, pictures[ii2 - 1].Location.X + 40, 274, pictures[ii2 - 1].Location.X + 40, 286);
                                    g.DrawLine(p2, pictures[ii2 - 1].Location.X + 40, 286, pictures[ii2 - c2].Location.X - 5, 286);
                                    g.DrawLine(p2, pictures[ii2 - c2].Location.X - 5, 286, pictures[ii2 - c2].Location.X - 5, 274);
                                    buttonsRed[kap].Visible = true;
                                    buttonsRed[kap].Location = new Point(pictures[ii2 - c2].Location.X - 5, 640);

                                    kap++;
                                    flag2 = false;
                                }
                                c2 = 0;
                            }
                            ii2++;
                        }
                    }
                    ccon = 0;
                    for (int i = 0; i < 29; i++)
                    {
                        if (pictures[i].Visible == true)
                        {
                            ccon++;
                        }
                    }

                    if (label1.Text == "2")
                    {
                        for (int i = 0; i < 29; i++)
                        {
                            pictures2[i].Image = imagesBig2[i];
                        }
                        for (int i = 0; i < 29; i++)
                        {
                            if (pictures[i].Visible == false)
                            {
                                pictures2[i].Visible = false;
                            }
                        }
                    }

                    if (ccon == 0)
                    {
                        button10.Visible = true;
                        button7.Visible = false;
                        button8.Visible = false;
                        pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_хотите_сыграть_еще;
                        button5.Visible = true;
                        button6.Visible = true;

                        this.ClientSize = new System.Drawing.Size(560, 440);
                        this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                        (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
                        button9.Visible = false;
                        pictureBox1.Size = new System.Drawing.Size(560, 440);


                        button10.Text = name1;

                        button9.Visible = false;

                        button10.Text = name1;

                        pictureBox31.Visible = false;

                        for (int i = 0; i < 15; i++)
                        {
                            buttonsBlue[i].Visible = false;
                        }

                        button26.Visible = false;
                        button27.Visible = false;

                        button7.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_для_имен;
                        button8.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_для_имен;
                    }

                }

                #endregion
            }

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //label1.Text = Convert.ToString(Cursor.Position.Y);
        }

        private void Form9_CursorChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox31_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }

        private void Form9_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (impotant == true)
            {
                if (countbut == 0)
                {
                    if ((Cursor.Position.X < 258) || (Cursor.Position.X > 1340) || (Cursor.Position.Y < 400) || (Cursor.Position.Y > 600))
                    {
                        for (int i = 0; i < 29; i++)
                        {
                            if (pictures[i].Visible == true)
                            {
                                pictures[i].Image = imagesBig[i];
                            }
                        }
                    }
                }
                else
                {
                    if ((Cursor.Position.X < 258) || (Cursor.Position.X > 1340) || (Cursor.Position.Y < 237) || (Cursor.Position.Y > 435))
                    {
                        for (int i = 0; i < 29; i++)
                        {
                            if (pictures[i].Visible == true)
                            {
                                pictures[i].Image = imagesBig[i];
                            }
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "3")
            {
                

            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";


                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;

                button5.Visible = false;
                button6.Visible = false;
                button10.Visible = false;

                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_главный_фон;

                countbut = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";


            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            textBox3.Visible = true;
            button4.Visible = true;

            r1 = false;
            r2 = true;
            r3 = false;

            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_имена_ч_к_к_ч_;

            #region

            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_1);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_2);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_3);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_4);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_5);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_6);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_7);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_8);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_9);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_10);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_11);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_12);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_13);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_14);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_15);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_16);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_17);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_18);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_19);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_20);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_21);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_22);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_23);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_24);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_25);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_26);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_27);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_28);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_29);

            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_1);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_2);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_3);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_4);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_5);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_6);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_7);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_8);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_9);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_10);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_11);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_12);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_13);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_14);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_15);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_16);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_17);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_18);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_19);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_20);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_21);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_22);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_23);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_24);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_25);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_26);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_27);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_28);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_29);

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

            pictures2.Add(pictureBox32);
            pictures2.Add(pictureBox33);
            pictures2.Add(pictureBox34);
            pictures2.Add(pictureBox35);
            pictures2.Add(pictureBox36);
            pictures2.Add(pictureBox37);
            pictures2.Add(pictureBox38);
            pictures2.Add(pictureBox39);
            pictures2.Add(pictureBox40);
            pictures2.Add(pictureBox41);
            pictures2.Add(pictureBox42);
            pictures2.Add(pictureBox43);
            pictures2.Add(pictureBox44);
            pictures2.Add(pictureBox45);
            pictures2.Add(pictureBox46);
            pictures2.Add(pictureBox47);
            pictures2.Add(pictureBox48);
            pictures2.Add(pictureBox49);
            pictures2.Add(pictureBox50);
            pictures2.Add(pictureBox51);
            pictures2.Add(pictureBox52);
            pictures2.Add(pictureBox53);
            pictures2.Add(pictureBox54);
            pictures2.Add(pictureBox55);
            pictures2.Add(pictureBox56);
            pictures2.Add(pictureBox57);
            pictures2.Add(pictureBox58);
            pictures2.Add(pictureBox59);
            pictures2.Add(pictureBox60);

            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_1);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_2);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_3);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_4);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_5);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_6);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_7);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_8);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_9);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_10);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_11);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_12);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_13);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_14);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_15);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_16);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_17);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_18);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_19);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_20);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_21);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_22);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_23);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_24);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_25);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_26);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_27);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_28);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_29);

            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_1);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_2);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_3);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_4);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_5);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_6);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_7);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_8);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_9);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_10);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_11);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_12);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_13);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_14);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_15);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_16);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_17);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_18);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_19);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_20);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_21);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_22);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_23);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_24);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_25);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_26);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_27);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_28);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_29);

            buttonsBlue.Add(button11);
            buttonsBlue.Add(button12);
            buttonsBlue.Add(button13);
            buttonsBlue.Add(button14);
            buttonsBlue.Add(button15);
            buttonsBlue.Add(button16);
            buttonsBlue.Add(button17);
            buttonsBlue.Add(button18);
            buttonsBlue.Add(button19);
            buttonsBlue.Add(button20);
            buttonsBlue.Add(button21);
            buttonsBlue.Add(button22);
            buttonsBlue.Add(button23);
            buttonsBlue.Add(button24);
            buttonsBlue.Add(button25);

            buttonsRed.Add(button28);
            buttonsRed.Add(button29);
            buttonsRed.Add(button30);
            buttonsRed.Add(button31);
            buttonsRed.Add(button32);
            buttonsRed.Add(button33);
            buttonsRed.Add(button34);
            buttonsRed.Add(button35);
            buttonsRed.Add(button36);
            buttonsRed.Add(button37);
            buttonsRed.Add(button38);
            buttonsRed.Add(button39);
            buttonsRed.Add(button40);
            buttonsRed.Add(button41);
            buttonsRed.Add(button42);


            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";


            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            textBox3.Visible = true;
            button4.Visible = true;

            r1 = false;
            r2 = false;
            r3 = true;

            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.ИК_имена_ч_к_к_ч_;


            #region

            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_1);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_2);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_3);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_4);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_5);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_6);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_7);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_8);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_9);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_10);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_11);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_12);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_13);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_14);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_15);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_16);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_17);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_18);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_19);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_20);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_21);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_22);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_23);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_24);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_25);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_26);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_27);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_28);
            imagesBig.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип1_29);

            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_1);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_2);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_3);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_4);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_5);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_6);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_7);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_8);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_9);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_10);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_11);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_12);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_13);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_14);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_15);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_16);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_17);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_18);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_19);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_20);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_21);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_22);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_23);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_24);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_25);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_26);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_27);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_28);
            imagesSmall.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип2_29);

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

            pictures2.Add(pictureBox32);
            pictures2.Add(pictureBox33);
            pictures2.Add(pictureBox34);
            pictures2.Add(pictureBox35);
            pictures2.Add(pictureBox36);
            pictures2.Add(pictureBox37);
            pictures2.Add(pictureBox38);
            pictures2.Add(pictureBox39);
            pictures2.Add(pictureBox40);
            pictures2.Add(pictureBox41);
            pictures2.Add(pictureBox42);
            pictures2.Add(pictureBox43);
            pictures2.Add(pictureBox44);
            pictures2.Add(pictureBox45);
            pictures2.Add(pictureBox46);
            pictures2.Add(pictureBox47);
            pictures2.Add(pictureBox48);
            pictures2.Add(pictureBox49);
            pictures2.Add(pictureBox50);
            pictures2.Add(pictureBox51);
            pictures2.Add(pictureBox52);
            pictures2.Add(pictureBox53);
            pictures2.Add(pictureBox54);
            pictures2.Add(pictureBox55);
            pictures2.Add(pictureBox56);
            pictures2.Add(pictureBox57);
            pictures2.Add(pictureBox58);
            pictures2.Add(pictureBox59);
            pictures2.Add(pictureBox60);

            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_1);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_2);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_3);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_4);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_5);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_6);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_7);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_8);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_9);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_10);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_11);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_12);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_13);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_14);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_15);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_16);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_17);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_18);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_19);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_20);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_21);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_22);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_23);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_24);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_25);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_26);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_27);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_28);
            imagesBig2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип3_29);

            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_1);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_2);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_3);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_4);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_5);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_6);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_7);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_8);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_9);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_10);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_11);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_12);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_13);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_14);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_15);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_16);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_17);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_18);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_19);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_20);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_21);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_22);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_23);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_24);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_25);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_26);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_27);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_28);
            imagesSmall2.Add(global::WindowsFormsApplication1.Properties.Resources.ИК_карандаш_тип5_29);

            buttonsBlue.Add(button11);
            buttonsBlue.Add(button12);
            buttonsBlue.Add(button13);
            buttonsBlue.Add(button14);
            buttonsBlue.Add(button15);
            buttonsBlue.Add(button16);
            buttonsBlue.Add(button17);
            buttonsBlue.Add(button18);
            buttonsBlue.Add(button19);
            buttonsBlue.Add(button20);
            buttonsBlue.Add(button21);
            buttonsBlue.Add(button22);
            buttonsBlue.Add(button23);
            buttonsBlue.Add(button24);
            buttonsBlue.Add(button25);

            buttonsRed.Add(button28);
            buttonsRed.Add(button29);
            buttonsRed.Add(button30);
            buttonsRed.Add(button31);
            buttonsRed.Add(button32);
            buttonsRed.Add(button33);
            buttonsRed.Add(button34);
            buttonsRed.Add(button35);
            buttonsRed.Add(button36);
            buttonsRed.Add(button37);
            buttonsRed.Add(button38);
            buttonsRed.Add(button39);
            buttonsRed.Add(button40);
            buttonsRed.Add(button41);
            buttonsRed.Add(button42);


            #endregion
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (countbut == 0)
            {
                if ((r2 == true) || (r3 == true))
                {
                    pictureBox31.Visible = true;

                    this.ClientSize = new System.Drawing.Size(1110, 685);
                    this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                    (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                    pictureBox1.Size = new System.Drawing.Size(1110, 350);
                    countbut = 1;
                }

            }
            else
            {
                if ((r2 == true) || (r3 == true))
                {
                    pictureBox31.Visible = true;

                    this.ClientSize = new System.Drawing.Size(1110, 350);
                    this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                    (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

                    pictureBox1.Size = new System.Drawing.Size(1110, 350);
                    countbut = 0;
                }
            }


            
        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        
    }
}
