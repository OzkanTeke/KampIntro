using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.Adi = "Harun";
            musteri1.Soyadi = "Yılmaz";
            musteri1.Yasi = 24;
            musteri1.Maas = 2450;

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "Mutlu";
            musteri2.Yasi = 21;
            musteri2.Maas = 3150;

            Musteri musteri3 = new Musteri();
            musteri3.ID = 3;
            musteri3.Adi = "Mehmet";
            musteri3.Soyadi = "Demir";
            musteri3.Yasi = 35;
            musteri3.Maas = 5760;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            foreach (Musteri x in musteriler)
            {
                musteriManager.Ekle(x);
            }

            Console.WriteLine("-----------------------------------------------");

            for (int i = 0; i < musteriler.Length; i++)
            {
                musteriManager.Listele(musteriler[i]);
            }

            Console.WriteLine("-----------------------------------------------");

            int a = 0;
            while (a < musteriler.Length)
            {
                musteriManager.Silme(musteriler[a]);
                a++;
            }
        }
    }
}
