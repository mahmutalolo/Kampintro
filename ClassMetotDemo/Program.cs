using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mahmut";
            musteri1.SoyAdi = "ALOLO";
            musteri1.Id = 23;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Engin";
            musteri2.SoyAdi = "DEMİROĞ";
            musteri2.Id = 45;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2};
            foreach (var x in musteriler)
            {
               
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.SoyAdi);
                Console.WriteLine(x.Id);

            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            
        }
    }
}
