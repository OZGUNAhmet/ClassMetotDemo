using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager MusteriManager = new CustomerManager();

            MusteriManager.MusteriEkle(101, "Ahmet", "Özgün", "Ankara");
            MusteriManager.MusteriEkle(102, "Ebru", "Yakut", "İstanbul");
            MusteriManager.MusteriEkle(103, "Sevinç", "Tekin", "Bursa");

            
            MusteriManager.MusteriListele();

            Console.WriteLine();
            MusteriManager.Menu();
            
        }
    }
}
