using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]{
                "a","b","c","d","e" };
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]); 
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
 