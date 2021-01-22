using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "sumeyye";
            musteri1.MusteriSoyadi = "almas";
            musteri1.CardNo = 111111;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "engin";
            musteri2.MusteriSoyadi = "demiroğ";
            musteri2.CardNo = 222222;

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("MUSTERİLER");
            musteriManager.MusteriListele(musteri1);

            Console.WriteLine("MUSTERİ EKLE");
            musteriManager.MusteriEkle(musteri1);

            Console.WriteLine("MUSTERİ SİL");
            musteriManager.MusteriSil(musteri2);

            
        }
    }
}
