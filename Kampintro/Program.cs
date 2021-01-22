using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarBugun = 7.45;
            double dolarDun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butun");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butun");
            }
            else
            {
                Console.WriteLine("değişmedi buton");
            }

        }
    }
}
