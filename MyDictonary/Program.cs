using System;


namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> meyveler = new MyDictionary<string>();
            meyveler.Add("ayva");
            meyveler.Add("armut");
            meyveler.Add("kayısı");
            meyveler.Add("şeftali");
            meyveler.Add("elma");

            foreach (var meyve in meyveler)
            {
                Console.WriteLine(meyve);
            }

            MyDictionary<int> sayilar = new MyDictionary<int>();
            sayilar.Add(1);
            sayilar.Add(100);
            sayilar.Add(73);
            sayilar.Add(82);

            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            /*
            MyDictionary<int,Sehirler> sehirler = new MyDictionary<Sehirler>();
            sehirler.Add(10);
            Console.WriteLine(meyveler);
            */
        }
        public class Sehirler
        {
            public string SehirAdi { get; set; }
            public int Plakası { get; set; }
        }
    }

}
