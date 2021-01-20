using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Mark";
            musteri1.soyad = "Knopfler";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Eric";
            musteri2.soyad = "Clapton";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Aretha";
            musteri3.soyad = "Franklin";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            musteriManager.List(musteriler);

            musteriManager.Delete(musteri2);

           




        }
    }
}
