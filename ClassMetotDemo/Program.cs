using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Müsteri musteri1 = new Müsteri();
            musteri1.Id = "1";
            musteri1.name = "Sefa";
            musteri1.surName = "KORKMAZ";

            Müsteri musteri2 = new Müsteri();
            musteri2.Id = "2";
            musteri2.name = "Ali";
            musteri2.surName = "YILMAZ";

            Müsteri musteri3 = new Müsteri();
            musteri3.Id = "3";
            musteri3.name = "Engin";
            musteri3.surName = "DEMİROĞ";

            List<Müsteri> musteriler = new List<Müsteri>() { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            musteriManager.Listeler(musteriler);

            Console.WriteLine(" \n " + "Silinicek müşterinin Id 'sini giriniz lütfen  ?");
            int yaz = Convert.ToInt32(Console.ReadLine());

            musteriManager.Delete(yaz, musteriler);

            Console.WriteLine("\n" + yaz + " silindikten sonra yeni Liste");

            musteriManager.Listeler(musteriler);
        }
    }
}