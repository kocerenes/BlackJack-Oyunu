using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackOyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _temizle()
        {
            sayac = 0;
            kart1.Text = 0.ToString();
            kart2.Text = 0.ToString();
            kart3.Text = 0.ToString();
            kart4.Text = 0.ToString();
            kart5.Text = 0.ToString();
            kart6.Text = 0.ToString();
            toplamsayi.Text = 0.ToString();

            pckart1.Text = 0.ToString();
            pckart2.Text = 0.ToString();
            pckart3.Text = 0.ToString();
            pckart4.Text = 0.ToString();
            pckart5.Text = 0.ToString();
            pcToplamSayi.Text = 0.ToString();
            PcKartCek.Enabled = true;

            pictureBox1.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\bckgrnd.png";
            pictureBox2.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\bckgrnd.png";
            pictureBox3.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\bckgrnd.png";
            pictureBox4.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\bckgrnd.png";
            pictureBox5.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\bckgrnd.png";
            pictureBox6.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\bckgrnd.png";
            pictureBox7.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\bckgrnd.png";
            pictureBox8.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\bckgrnd.png";
            pictureBox9.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\bckgrnd.png";
            pictureBox10.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\bckgrnd.png";
            pictureBox11.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\bckgrnd.png";
        }

        Random random = new Random();
        int sayac;
        private void KartCek_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==1)
            {
                int a1, a2, toplam;
                a1 = random.Next(1, 11);
                a2 = random.Next(1, 11);
                toplam = a1 + a2;
                kart1.Text = a1.ToString();
                kart2.Text = a2.ToString();
                toplamsayi.Text = toplam.ToString();
            }

            if (sayac==2)
            {
                int a3, toplam;
                a3 = random.Next(1, 11);
                kart3.Text = a3.ToString();
                toplam = Convert.ToInt16(kart1.Text) + Convert.ToInt16(kart2.Text) + a3;
                toplamsayi.Text = toplam.ToString();
            }

            if (sayac==3)
            {
                int a4, toplam;
                a4 = random.Next(1, 11);
                kart4.Text = a4.ToString();
                toplam = Convert.ToInt16(kart1.Text) + Convert.ToInt16(kart2.Text) + Convert.ToInt16(kart3.Text) + a4;
                toplamsayi.Text = toplam.ToString();
            }

            if (sayac == 4)
            {
                int a5, toplam;
                a5 = random.Next(1, 11);
                kart5.Text = a5.ToString();
                toplam = Convert.ToInt16(kart1.Text) + Convert.ToInt16(kart2.Text) + Convert.ToInt16(kart3.Text)+ Convert.ToInt16(kart4.Text) + a5;
                toplamsayi.Text = toplam.ToString();
            }

            if (sayac == 5)
            {
                int a6, toplam;
                a6 = random.Next(1, 11);
                kart6.Text = a6.ToString();
                toplam = Convert.ToInt16(kart1.Text) + Convert.ToInt16(kart2.Text) + Convert.ToInt16(kart3.Text) + Convert.ToInt16(kart4.Text)+ Convert.ToInt16(kart5.Text) + a6;
                toplamsayi.Text = toplam.ToString();
            }


            // kağıt resimleri
            if (kart1.Text == "1")
            {
                pictureBox5.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_as.jpg";
            }

            if (kart1.Text == "2")
            {
                pictureBox5.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_2.png";
            }

            if (kart1.Text == "3")
            {
                pictureBox5.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_3.jpg";
            }

            if (kart1.Text == "4")
            {
                pictureBox5.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_4.png";
            }

            if (kart1.Text == "5")
            {
                pictureBox5.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_5.png";
            }

            if (kart1.Text == "6")
            {
                pictureBox5.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_6.png";
            }

            if (kart1.Text == "7")
            {
                pictureBox5.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_7.png";
            }

            if (kart1.Text == "8")
            {
                pictureBox5.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_8.png";
            }

            if (kart1.Text == "9")
            {
                pictureBox5.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_9.png";
            }

            if (kart1.Text == "10")
            {
                pictureBox5.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_10.png";
            }

            // kart2

            if (kart2.Text == "1")
            {
                pictureBox4.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_as.jpg";
            }

            if (kart2.Text == "2")
            {
                pictureBox4.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_2.png";
            }

            if (kart2.Text == "3")
            {
                pictureBox4.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_3.jpg";
            }

            if (kart2.Text == "4")
            {
                pictureBox4.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_4.png";
            }

            if (kart2.Text == "5")
            {
                pictureBox4.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_5.png";
            }

            if (kart2.Text == "6")
            {
                pictureBox4.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_6.png";
            }

            if (kart2.Text == "7")
            {
                pictureBox4.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_7.png";
            }

            if (kart2.Text == "8")
            {
                pictureBox4.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_8.png";
            }

            if (kart2.Text == "9")
            {
                pictureBox4.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_9.png";
            }

            if (kart2.Text == "10")
            {
                pictureBox4.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_10.png";
            }

            //kart3
            if (kart3.Text == "1")
            {
                pictureBox3.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_as.jpg";
            }

            if (kart3.Text == "2")
            {
                pictureBox3.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_2.png";
            }

            if (kart3.Text == "3")
            {
                pictureBox3.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_3.jpg";
            }

            if (kart3.Text == "4")
            {
                pictureBox3.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_4.png";
            }

            if (kart3.Text == "5")
            {
                pictureBox3.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_5.png";
            }

            if (kart3.Text == "6")
            {
                pictureBox3.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_6.png";
            }

            if (kart3.Text == "7")
            {
                pictureBox3.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_7.png";
            }

            if (kart3.Text == "8")
            {
                pictureBox3.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_8.png";
            }

            if (kart3.Text == "9")
            {
                pictureBox3.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_9.png";
            }

            if (kart3.Text == "10")
            {
                pictureBox3.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_10.png";
            }

            // kart4
            if (kart4.Text == "1")
            {
                pictureBox2.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_as.jpg";
            }

            if (kart4.Text == "2")
            {
                pictureBox2.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_2.png";
            }

            if (kart4.Text == "3")
            {
                pictureBox2.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_3.jpg";
            }

            if (kart4.Text == "4")
            {
                pictureBox2.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_4.png";
            }

            if (kart4.Text == "5")
            {
                pictureBox2.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_5.png";
            }

            if (kart4.Text == "6")
            {
                pictureBox2.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_6.png";
            }

            if (kart4.Text == "7")
            {
                pictureBox2.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_7.png";
            }

            if (kart4.Text == "8")
            {
                pictureBox2.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_8.png";
            }

            if (kart4.Text == "9")
            {
                pictureBox2.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_9.png";
            }

            if (kart4.Text == "10")
            {
                pictureBox2.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_10.png";
            }

            //kart5
            if (kart5.Text == "1")
            {
                pictureBox1.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_as.jpg";
            }

            if (kart5.Text == "2")
            {
                pictureBox1.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_2.png";
            }

            if (kart5.Text == "3")
            {
                pictureBox1.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_3.jpg";
            }

            if (kart5.Text == "4")
            {
                pictureBox1.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_4.png";
            }

            if (kart5.Text == "5")
            {
                pictureBox1.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_5.png";
            }

            if (kart5.Text == "6")
            {
                pictureBox1.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_6.png";
            }

            if (kart5.Text == "7")
            {
                pictureBox1.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_7.png";
            }

            if (kart5.Text == "8")
            {
                pictureBox1.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_8.png";
            }

            if (kart5.Text == "9")
            {
                pictureBox1.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_9.png";
            }

            if (kart5.Text == "10")
            {
                pictureBox1.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_10.png";
            }

            //kart6
            if (kart6.Text == "1")
            {
                pictureBox6.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_as.jpg";
            }

            if (kart6.Text == "2")
            {
                pictureBox6.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_2.png";
            }

            if (kart6.Text == "3")
            {
                pictureBox6.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_3.jpg";
            }

            if (kart6.Text == "4")
            {
                pictureBox6.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_4.png";
            }

            if (kart6.Text == "5")
            {
                pictureBox6.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_5.png";
            }

            if (kart6.Text == "6")
            {
                pictureBox6.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_6.png";
            }

            if (kart6.Text == "7")
            {
                pictureBox6.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_7.png";
            }

            if (kart6.Text == "8")
            {
                pictureBox6.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_8.png";
            }

            if (kart6.Text == "9")
            {
                pictureBox6.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_9.png";
            }

            if (kart6.Text == "10")
            {
                pictureBox6.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_10.png";
            }

        }

        private void PcKartCek_Click(object sender, EventArgs e)
        {
            int b1, b2, toplam;
            b1 = random.Next(1, 11);
            b2 = random.Next(1, 11);
            toplam = b1 + b2;
            pckart1.Text = b1.ToString();
            pckart2.Text = b2.ToString();
            pcToplamSayi.Text = toplam.ToString();

            if (b1+b2<16)
            {
                int b3;
                b3 = random.Next(1, 11);
                toplam = Convert.ToInt16(pckart1.Text) + Convert.ToInt16(pckart2.Text) + b3;
                pckart3.Text = b3.ToString();
                pcToplamSayi.Text = toplam.ToString();
            }
            if (toplam<16)
            {
                int b4;
                b4 = random.Next(1, 11);
                pckart4.Text = b4.ToString();
                toplam= Convert.ToInt16(pckart1.Text) + Convert.ToInt16(pckart2.Text) + Convert.ToInt16(pckart3.Text) + b4;
                pcToplamSayi.Text = toplam.ToString();
            }

            //pckart1
            if (pckart1.Text=="1")
            {
                pictureBox11.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_as.jpg";
            }

            if (pckart1.Text == "2")
            {
                pictureBox11.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_2.png";
            }

            if (pckart1.Text == "3")
            {
                pictureBox11.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_3.jpg";
            }

            if (pckart1.Text == "4")
            {
                pictureBox11.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_4.png";
            }

            if (pckart1.Text == "5")
            {
                pictureBox11.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_5.png";
            }

            if (pckart1.Text == "6")
            {
                pictureBox11.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_6.png";
            }

            if (pckart1.Text == "7")
            {
                pictureBox11.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_7.png";
            }

            if (pckart1.Text == "8")
            {
                pictureBox11.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_8.png";
            }

            if (pckart1.Text == "9")
            {
                pictureBox11.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_9.png";
            }

            if (pckart1.Text == "10")
            {
                pictureBox11.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_10.png";
            }

            //pckart2
            if (pckart2.Text == "1")
            {
                pictureBox10.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_as.jpg";
            }

            if (pckart2.Text == "2")
            {
                pictureBox10.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_2.png";
            }

            if (pckart2.Text == "3")
            {
                pictureBox10.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_3.jpg";
            }

            if (pckart2.Text == "4")
            {
                pictureBox10.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_4.png";
            }

            if (pckart2.Text == "5")
            {
                pictureBox10.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_5.png";
            }

            if (pckart2.Text == "6")
            {
                pictureBox10.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_6.png";
            }

            if (pckart2.Text == "7")
            {
                pictureBox10.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_7.png";
            }

            if (pckart2.Text == "8")
            {
                pictureBox10.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_8.png";
            }

            if (pckart2.Text == "9")
            {
                pictureBox10.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_9.png";
            }

            if (pckart2.Text == "10")
            {
                pictureBox10.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_10.png";
            }

            //pckart3
            if (pckart3.Text == "1")
            {
                pictureBox9.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_as.jpg";
            }

            if (pckart3.Text == "2")
            {
                pictureBox9.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_2.png";
            }

            if (pckart3.Text == "3")
            {
                pictureBox9.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_3.jpg";
            }

            if (pckart3.Text == "4")
            {
                pictureBox9.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_4.png";
            }

            if (pckart3.Text == "5")
            {
                pictureBox9.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_5.png";
            }

            if (pckart3.Text == "6")
            {
                pictureBox9.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_6.png";
            }

            if (pckart3.Text == "7")
            {
                pictureBox9.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_7.png";
            }

            if (pckart3.Text == "8")
            {
                pictureBox9.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_8.png";
            }

            if (pckart3.Text == "9")
            {
                pictureBox9.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_9.png";
            }

            if (pckart3.Text == "10")
            {
                pictureBox9.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_10.png";
            }

            //pckart4
            if (pckart4.Text == "1")
            {
                pictureBox8.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_as.jpg";
            }

            if (pckart4.Text == "2")
            {
                pictureBox8.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_2.png";
            }

            if (pckart4.Text == "3")
            {
                pictureBox8.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_3.jpg";
            }

            if (pckart4.Text == "4")
            {
                pictureBox8.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_4.png";
            }

            if (pckart4.Text == "5")
            {
                pictureBox8.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_5.png";
            }

            if (pckart4.Text == "6")
            {
                pictureBox8.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_6.png";
            }

            if (pckart4.Text == "7")
            {
                pictureBox8.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_7.png";
            }

            if (pckart4.Text == "8")
            {
                pictureBox8.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_8.png";
            }

            if (pckart4.Text == "9")
            {
                pictureBox8.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_9.png";
            }

            if (pckart4.Text == "10")
            {
                pictureBox8.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_10.png";
            }

            //pckart5
            if (pckart5.Text == "1")
            {
                pictureBox7.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_as.jpg";
            }

            if (pckart5.Text == "2")
            {
                pictureBox7.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_2.png";
            }

            if (pckart5.Text == "3")
            {
                pictureBox7.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_3.jpg";
            }

            if (pckart5.Text == "4")
            {
                pictureBox7.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_4.png";
            }

            if (pckart5.Text == "5")
            {
                pictureBox7.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_5.png";
            }

            if (pckart5.Text == "6")
            {
                pictureBox7.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_6.png";
            }

            if (pckart5.Text == "7")
            {
                pictureBox7.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_7.png";
            }

            if (pckart5.Text == "8")
            {
                pictureBox7.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_8.png";
            }

            if (pckart5.Text == "9")
            {
                pictureBox7.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_9.png";
            }

            if (pckart5.Text == "10")
            {
                pictureBox7.ImageLocation = "C:\\Users\\enes\\source\\repos\\BlackjackOyun\\BlackjackOyun\\img\\sinek_10.png";
            }

            PcKartCek.Enabled = false;
        }

        public int oyuncuPuan, pcPuan;

        private void Form1_Load(object sender, EventArgs e)
        {
            kart1.Text = "0";
            kart2.Text = "0";
            kart3.Text = "0";
            kart4.Text = "0";
            kart5.Text = "0";
            kart6.Text = "0";
            pckart1.Text = "0";
            pckart2.Text = "0";
            pckart3.Text = "0";
            pckart4.Text = "0";
            pckart5.Text = "0";

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cikis==DialogResult.Yes)
            {
                Application.Exit();
            }
            if (cikis == DialogResult.No)
            {

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (kart1.Text!="0" && pckart1.Text!="0")
            {
                
                int oyuncutoplam, pctoplam;
                oyuncutoplam = Convert.ToInt16(toplamsayi.Text);
                pctoplam = Convert.ToInt16(pcToplamSayi.Text);

                if (oyuncutoplam > pctoplam && oyuncutoplam <= 21 || oyuncutoplam < pctoplam && pctoplam > 21 && oyuncutoplam <= 21)
                {
                    oyuncuPuan = oyuncuPuan + 10;
                    oyuncuSkor.Text = oyuncuPuan.ToString();
                }

                if (pctoplam > oyuncutoplam && pctoplam <= 21 || pctoplam < oyuncutoplam && oyuncutoplam > 21 && pctoplam <= 21)
                {
                    pcPuan += 10;
                    pcSkor.Text = pcPuan.ToString();
                }

                if (pctoplam == oyuncutoplam && pctoplam <= 21 && oyuncutoplam <= 21)
                {
                    oyuncuPuan += 10;
                    pcPuan += 10;
                    oyuncuSkor.Text = oyuncuPuan.ToString();
                    pcSkor.Text = pcPuan.ToString();
                }

                if (pctoplam >= 21 && oyuncutoplam >= 21)
                {
                    MessageBox.Show("İki tarafta kazanamadı.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (oyuncuPuan == 50)
                {
                    MessageBox.Show("Tebrikler kazandınız!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    oyuncuPuan = 0;
                    pcPuan = 0;
                    oyuncuSkor.Text = 0.ToString();
                    pcSkor.Text = 0.ToString();
                }
                if (pcPuan == 50)
                {
                    MessageBox.Show("Bilgisayar kazandı!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    oyuncuPuan = 0;
                    pcPuan = 0;
                    oyuncuSkor.Text = 0.ToString();
                    pcSkor.Text = 0.ToString();
                }
            }

            if (kart1.Text!="0" && pckart1.Text=="0")
            {
                MessageBox.Show("Bilgisayar kart açmadı.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (kart1.Text == "0" && pckart1.Text != "0")
            {
                MessageBox.Show("Kart açmadın.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (kart1.Text == "0" && pckart1.Text == "0")
            {
                MessageBox.Show("Başlamadığın oyunu bitiremezsin!!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            _temizle();

        }
    }
}
