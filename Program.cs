using System;

namespace _3.gun
{
    class Program
    {
        static void Main(string[] args)
        {
            urun urun1 = new urun();
            urun1.urunAdi = "klavye";
            urun1.urunFiyati = 200;
            urun1.urunAciklamasi = "pc için";

            urun urun2 = new urun();
            urun2.urunAdi = "fare";
            urun2.urunFiyati = 100;
            urun2.urunAciklamasi = "kablosuz";

            urun[] urunler = new urun[] {urun1,urun2 };

            foreach (urun urun in urunler)
            {
                Console.WriteLine(urun.urunAdi);
                Console.WriteLine(urun.urunFiyati);
                Console.WriteLine(urun.urunAciklamasi);
                Console.WriteLine("---------------");
            }

            sepetManager Sepetmanager = new sepetManager();
            Sepetmanager.Ekle(urun1);
            Sepetmanager.Ekle(urun2);
        }
    }
}
