using System;

namespace UrunClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Hoparlör";
            urun1.UrunMarkasi = "Pioneer";
            urun1.UrunFiyati = 203.48;
            urun1.IndirimOrani = 8;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Oto Lastik";
            urun2.UrunMarkasi = "Falken";
            urun2.UrunFiyati = 400.13;
            urun2.IndirimOrani = 9;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Ekran Kartı";
            urun3.UrunMarkasi = "MSI";
            urun3.UrunFiyati = 16405.00;
            urun3.IndirimOrani = 4;

            Urun urun4 = new Urun();
            urun4.UrunAdi = "Şampuan";
            urun4.UrunMarkasi = "Sebamed";
            urun4.UrunFiyati = 56.50;
            urun4.IndirimOrani = 14;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4 };

            for (int x = 0; x < urunler.Length; x++)
            {
                Console.WriteLine(urunler[x].UrunAdi + " - " + urunler[x].UrunMarkasi + " - " + urunler[x].UrunFiyati + "TL - %" + urunler[x].IndirimOrani + " indirim!");
            }

            Console.WriteLine("--------------------------------------------");

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " - " + urun.UrunMarkasi + " - " + urun.UrunFiyati + "TL - %" + urun.IndirimOrani + " indirim!");
            }

            Console.WriteLine("--------------------------------------------");

            int i = 0;
            while (i <urunler.Length)
            {
                Console.WriteLine(urunler[i].UrunAdi + " - " + urunler[i].UrunMarkasi + " - " + urunler[i].UrunFiyati + "TL - %" + urunler[i].IndirimOrani + " indirim!");
                i++;
            }

        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public string UrunMarkasi { get; set; }
        public double UrunFiyati { get; set; }
        public int IndirimOrani { get; set; }
    }
}
