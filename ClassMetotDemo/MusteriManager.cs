using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Müsteri musteri)
        {

        }
        public void Delete(int yaz, List<Müsteri> musteriler)
        {
            musteriler.RemoveAt(yaz - 1);

        }

        public void Listeler(List<Müsteri> musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(" \n " + " Müşteri Id: " + musteri.Id + " \n " + " Müşteri isim : " + musteri.name
                   + " \n " + " Müşteri Soyad : " + musteri.surName);
            }
        }
    }
}