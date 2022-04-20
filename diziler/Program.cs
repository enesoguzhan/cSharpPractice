using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };

            int[] dizi;
            dizi = new int[5];

            // Atama-Erişim
            renkler[0] = "Mavi";
            dizi[3] = 58;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngülerde Dizi Kullanımı
            // Klavyeden girilen n tane sayının ortalamasını hesaplayan program

            Console.Write("Dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayısı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;

            foreach (var item in sayiDizisi)
            {
                toplam += item;
            }

            Console.WriteLine("Ortlama: " + toplam / diziUzunlugu); ;
        }
    }
}
