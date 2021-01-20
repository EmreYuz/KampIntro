using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager

        
    {

        int i = 1;

        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " numaralı müşteri eklendi: " + musteri.Ad + " " + musteri.soyad);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " numaralı müşteri silindi: " + musteri.Ad + " " + musteri.soyad);
        }

        public void List(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + ": " + musteri.Ad + " " + musteri.soyad);
            }
        }


    }
}
