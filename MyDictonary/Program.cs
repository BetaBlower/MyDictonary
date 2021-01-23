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

            Console.WriteLine(meyveler);

            MyDictionary<int> sayılar = new MyDictionary<int>();
            sayılar.Add(1);
            sayılar.Add(100);
            sayılar.Add(73);
            sayılar.Add(82);

            Console.WriteLine(sayılar);
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
