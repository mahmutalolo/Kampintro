using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri : " +musteri.Id + musteri.Adi +musteri.SoyAdi );
        }
    }
}
