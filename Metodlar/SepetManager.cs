using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager // sepete eklemek için iki farklı yol oluşturma
    {
        public void Ekle(Urun urun) // ürünü class olarak sepete ekleme
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) // ürün bilgilerini tek tek alarak sepete ekleme
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
