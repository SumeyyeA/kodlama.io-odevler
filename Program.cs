using System;
namespace _2gunodev6
{
    class Product
    {
        public string UrunAdi { get; set; }

        public string UrunAciklamasi { get; set; }

        public int UrunFiyati { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.UrunAdi = "mouse";
            product1.UrunAciklamasi = "kablosuz";
            product1.UrunFiyati = 100;

            Product product2 = new Product();
            product2.UrunAdi = "klavye";
            product2.UrunAciklamasi = "ledli";
            product2.UrunFiyati = 500;

            Product product3 = new Product();
            product3.UrunAdi = "pc çantası";
            product3.UrunAciklamasi = "askılı";
            product3.UrunFiyati = 200;

            Product[] products = new Product[] { product1, product2, product3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("for ile urunler" +" "+ products[i].UrunAdi);
            }  
            foreach(var product in products)
            {
                Console.WriteLine("foreach ile urunler" +" "+ product.UrunAdi);
            }
            int a = 0;
            while (a < products.Length)
            {
                Console.WriteLine("while ile urunler" +" "+ products[a].UrunAdi);
                a++;
            }
        }
    }
    
}