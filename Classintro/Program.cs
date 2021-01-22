using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Mahmut";
            int yas = 26;

            kurs kurs1 = new kurs();
            kurs1.kursAdi = "Java";
            kurs1.Egitmeni = "lin";
            kurs1.IzlemeOrani = 6;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "python";
            kurs2.Egitmeni = "emel";
            kurs2.IzlemeOrani = 90;


            kurs kurs3 = new kurs();
            kurs3.kursAdi = "c#";
            kurs3.Egitmeni = "Mahmut";
            kurs3.IzlemeOrani = 62;

            //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.Egitmeni);

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmeni);

            }
            //Console.WriteLine("Hello World!");
        }
    }
    class kurs
    {
        public string kursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlemeOrani { get; set; }
    }
}
