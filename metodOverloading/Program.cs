using System;

namespace metodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar metotlar = new Metotlar();
            metotlar.Topla(2, 3, out int toplam);
            Console.WriteLine(toplam);

            // overloading
            int ifade = 999;
            metotlar.EkranaYazdir(Convert.ToString(ifade));
            metotlar.EkranaYazdir(ifade);
            metotlar.EkranaYazdir("a" + "b");
            
        }
    }

    class Metotlar
    {
        public void Topla(int a , int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir (string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1 , string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
