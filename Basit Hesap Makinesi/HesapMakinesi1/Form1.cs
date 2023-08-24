using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        // Field, Alan Form1 in değişkenleri, nesneleri
        // HesapMakinasu sınıfından yeni bir nesne örneği hm : 
        HesapMakinesi hm = new HesapMakinesi();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // sayı 1   sayı 2 hesapla
            //double sayi1 = Convert.ToDouble(textBox1.Text);
            //double sayi2 = double.Parse(textBox2.Text);
            double sayi1, sayi2;
            hm.Sayilarial(textBox1.Text, textBox2.Text, out sayi1, out sayi2);
            double toplam = hm.Topla(sayi1, sayi2);
            label3.Text = hm.Gosterim(sayi1, sayi2, toplam, " + ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // sayı 1 - sayı 2 hesapla
            //double sayi1 = Convert.ToDouble(textBox1.Text);
            //double sayi2 = double.Parse(textBox2.Text);
            double sayi1, sayi2;
            hm.Sayilarial(textBox1.Text, textBox2.Text, out sayi1, out sayi2);
            double fark = hm.Cikar(sayi1, sayi2);
            label3.Text = hm.Gosterim(sayi1, sayi2, fark, " - ");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // sayı 1 * sayı 2 hesapla
            //double sayi1 = Convert.ToDouble(textBox1.Text);
            //double sayi2 = double.Parse(textBox2.Text);
            double sayi1, sayi2;
            hm.Sayilarial(textBox1.Text, textBox2.Text, out sayi1, out sayi2);
            double çarpim = hm.Carp(sayi1, sayi2);
            label3.Text = hm.Gosterim(sayi1, sayi2, çarpim, " x ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // sayı 1 / sayı 2 hesapla
            //double sayi1 = Convert.ToDouble(textBox1.Text);
            //double sayi2 = double.Parse(textBox2.Text);
            double sayi1, sayi2;
            hm.Sayilarial(textBox1.Text, textBox2.Text, out sayi1, out sayi2);
            double bölüm = hm.Böl(sayi1, sayi2);
            label3.Text = hm.Gosterim(sayi1, sayi2, bölüm, " / ");
        }
    }
}