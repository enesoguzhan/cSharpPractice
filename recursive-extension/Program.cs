using System;

namespace recursive_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursive

            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);

            Islemler islemler = new Islemler();
            Console.WriteLine(islemler.Expo(3, 4));

            //Extension

            string ifade = "a b c d e";
            bool sonuc = ifade.CheckSpaces();
            if (sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());

        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
                return sayi;
            return Expo(sayi, us - 1) * sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }
    }
}
