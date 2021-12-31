using System;

namespace Enum_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;
            if (sicaklik<=(int)HavaDurumu.Soguk)
                Console.WriteLine("Disariya cikmak icin havanin biraz daha isinmasini bekleyelim");
            else if(sicaklik>=(int)HavaDurumu.Sicak)
                Console.WriteLine("Disariya cikmak icin cok sicak bir gun");
            else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik<=(int)HavaDurumu.CokSicak)
                Console.WriteLine("Hadi disariya cikalim! ");
        }
    }

    enum Gunler
    {
        Pazartesi=1,
        Sali,
        Carsamba,
        Persembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sicak=25,
        CokSicak = 30
    }
}