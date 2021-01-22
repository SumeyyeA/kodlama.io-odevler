using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            
            Console.WriteLine("musteri basariyla eklendi.");
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            Console.WriteLine(musteri.CardNo);
            Console.WriteLine("---------------");

        }

        public void MusteriListele(Musteri musteri)
        {
            Musteri[] musteris = new Musteri[] {musteri };

            foreach (Musteri item in musteris)
            {
                Console.WriteLine("musteriler listeleniyor");
                Console.WriteLine(musteri.MusteriAdi+" "+musteri.MusteriSoyadi);
                Console.WriteLine(musteri.CardNo);
                Console.WriteLine("---------------");
            }

        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("musteri silindi:");
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            Console.WriteLine(musteri.CardNo);
            Console.WriteLine("---------------");

        }
    }
}
