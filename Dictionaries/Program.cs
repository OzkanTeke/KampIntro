using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> isimler = new MyDictionary<string,int>();
            isimler.Add("Engin",35);

            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem",27);

            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }

            foreach (var id in isimler.Ids)
            {
                Console.WriteLine(id);
            }
        }
    }
}
