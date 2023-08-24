using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    internal class HesapMakinesi
    {
        // Field : Alan : Değişkenler
        // Property : Özellik: Private alanlara kontrollü okuma ,yazma sağlar
        // Metotlar : Nesnenin fonksiyonları 
        public void Sayilarial(string s1, string s2, out double sayi1, out double sayi2)
        {
            // Hata olurda sayi1 ve sayi 2 değer almaz ise, başlangıç değeri verelim
            sayi1 = sayi2 = 0;
            try
            {
                sayi1 = Convert.ToDouble(s1);
                sayi2 = double.Parse(s2);
            }
            catch (Exception istisna)
            {
                DialogResult result = MessageBox.Show("Girdi Yanlış Sayı Girmelisin!!", "Hata Penceresi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
        public string Gosterim(double sayi1, double sayi2, double sonuç, string islem)
        {
            string gösterilecekIfade = sayi1.ToString() +islem + sayi2.ToString() +  " = " +
                                       sonuç.ToString();
            return gösterilecekIfade;
        }
        public double Topla(double s1 ,double s2)
        {
            double sonuc = s1 + s2;
            return sonuc;
        }
        public double Cikar(double s1, double s2)
        {
            double sonuc = s1 - s2;
            return sonuc;
        }
        public double Carp(double s1, double s2)
        {
            double sonuc = s1 * s2;
            return sonuc;
        }
        public double Böl(double s1, double s2)
        {
            double sonuc = s1 / s2;
            return sonuc;
        }
    }
}