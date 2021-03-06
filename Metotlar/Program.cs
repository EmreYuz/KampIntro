﻿using System;
using System.Threading.Channels;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};

            foreach (var VARIABLE in urunler)
            {
                Console.WriteLine(VARIABLE.Adi);
                Console.WriteLine(VARIABLE.Aciklama);
                Console.WriteLine(VARIABLE.Fiyati);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("----------------------Metotlar----------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 9);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12 ,8);
        }   
    }
}
