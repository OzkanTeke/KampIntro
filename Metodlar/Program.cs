using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 }; // birçok ürün için class olarak tek bir string oluşturma

            foreach (Urun urun in urunler) // birçok ürün için aynı işlemi tekrar olarak yapma
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("------------------Metodlar----------------");

            SepetManager sepetManager = new SepetManager(); // yeni sepetManager class'ını tanımlama
            sepetManager.Ekle(urun1); // class'lı ekle yöntemi ile ürün bilgilerini ayrı ayrı girmeye gerek kalmaz
            sepetManager.Ekle(urun2);
            
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10); // her bir işlem için ürünlerin özelliklerini tek tek girmek gerekir
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}
