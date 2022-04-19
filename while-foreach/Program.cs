using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 den başlayarak girilen sayı dahil ortalama hesaplayıp ekrana yazdırma.

            Console.WriteLine("Bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 0;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);


            // a dan z ye  kadar tüm harfleri yazdır.

            char charcter = 'a';
            while (charcter <= 'z')
            {
                Console.WriteLine(charcter);
                charcter++;
            }

            // Foreach

            string[] arabalar = { "Tofaş", "Ford", "Toyota" };

            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
