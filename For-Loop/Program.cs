using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen sayı kadar tek olan sayıları ekrana yazdırır.
            Console.WriteLine("Bir sayı giriniz.");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);

            }


            // 1 ile 1000 arasıdaki tek ve çift sayıların toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i;
                else
                    ciftToplam += i;
            }

            Console.WriteLine("Tek Toplam :" + tekToplam);
            Console.WriteLine("Çift Toplam :" + ciftToplam);

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
