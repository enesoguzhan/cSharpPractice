using System;

namespace methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 34;
            int b = 24;

            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar method = new Metotlar();
            method.EkranaYazdir(Convert.ToString(sonuc));
            int sonuc2 = method.ArttırVeTopla(ref a, ref b);
            method.EkranaYazdir(Convert.ToString(sonuc2));


        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;

            return deger1 + deger2;
        }
    }
}
