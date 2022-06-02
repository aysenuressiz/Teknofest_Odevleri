using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teknofest_ödevleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }
        int a, b, tahmin, sonuc = 0;
        
        private void button4_Click(object sender, EventArgs e)
        {

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            sonuc = a - b;
            label2.Text = sonuc.ToString();
            chart1.Series["SONUÇLAR"].Points.Add(sonuc);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            sonuc = a * b;
            label2.Text = sonuc.ToString();
            chart1.Series["SONUÇLAR"].Points.Add(sonuc);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            if (b == 0)
            {
                label2.Text = "!! HATA !!";
                label2.ForeColor = Color.DarkRed;
            }
            else
            {
                sonuc = a / b;
                label2.Text = sonuc.ToString();
                label2.ForeColor = Color.Black;
            }
            chart1.Series["SONUÇLAR"].Points.Add(sonuc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label8.Text = "";
            label2.Text = "";
            label7.Text = "";
            button9.Enabled = true;
            pictureBox1.Location = new Point(1, 55);
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi, sonucf = 1;
            sayi = Convert.ToInt32(textBox1.Text);

            for( int i = 1; i <= sayi; i++)
            {
                sonucf *= i;
            }
            label2.Text = sonucf.ToString();
            label2.ForeColor = Color.Black;

            chart1.Series["SONUÇLAR"].Points.Add(sonucf);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi, sonucf = 1;
            sayi = Convert.ToInt32(textBox1.Text);

            for (int i = 1; i <= sayi; i++)
            {
                sonucf *= i;
                if (i == 4)
                    sonucf = sonucf / 4;
            }
            label2.Text = sonucf.ToString();
            label2.ForeColor = Color.Black;
            chart1.Series["SONUÇLAR"].Points.Add(sonucf);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label7.Text = "Lütfen tahmin ettiğiniz sayıyı aşağıdaki kutucuğa yazınınz.";

            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            Random rastgele = new Random();
            tahmin = rastgele.Next(a, b);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y + 2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 100;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button9_Click(object sender, EventArgs e)
        {


            if (textBox3.Text == "")
            {
                label8.Text = "Lütfen bir sayı giriniz.";
            }
            else
            {
                int girilenSayi = int.Parse(textBox3.Text);

                if (girilenSayi < tahmin)
                {
                    label8.Text = "Daha BÜYÜK bir tahmin giriniz.";
                   
                }
                else if (girilenSayi > tahmin)
                {
                    label8.Text = "Daha KÜÇÜK bir tahmin giriniz.";
                    
                }
                else
                {
                    label8.Text = "TEBRİKLER. KAZANDINIZ!!!";
                    button9.Enabled = false;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            sonuc = a + b;
            label2.Text = sonuc.ToString();
            chart1.Series["SONUÇLAR"].Points.Add(sonuc);
        }
    }
}
