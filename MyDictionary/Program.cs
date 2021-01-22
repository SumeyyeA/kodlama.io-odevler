using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, double> HarfNotu = new MyDictionary<string, double>();
            HarfNotu.Add("AA", 4.0);
            HarfNotu.Add("BA", 3.5);
            HarfNotu.Add("BB", 3.0);
            HarfNotu.Add("CB", 2.5);
            HarfNotu.Add("CC", 2.0);
            HarfNotu.Add("DC", 1.5);
            HarfNotu.Add("DD", 1.0);
            HarfNotu.Add("FD", 0.5);
            HarfNotu.Add("FF", 0.0);

            foreach (var harf in HarfNotu.Keys)
            {
                Console.WriteLine(harf);
            }

            foreach (var not in HarfNotu.Values)
            {
                Console.WriteLine(not);
            }
        }
    }
}
