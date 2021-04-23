using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;  //sayi1 = 30 (stack) (değer atanır)
            sayi2 = 65;
            // int, decimal, float, double, bool = değer tip
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;  //sayilar1 referans numarası = sayilar2 referans numarası (heap) (adres atanır)
            sayilar2[0] = 999;
            // array, class, interface = referans tip
            Console.WriteLine(sayilar1[0]);
        }
    }
}
