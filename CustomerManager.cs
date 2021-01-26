using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> Musteriler = new List<Customer>();
        public void MusteriEkle(int Id, string Adi, string Soyadi, string DogumYeri)
        {
            Customer Musteri = new Customer();

            Musteri.Id = Id;
            Musteri.MusteriAdi = Adi;
            Musteri.MusteriSoyadi = Soyadi;
            Musteri.MusteriDogumYeri = DogumYeri;

            Musteriler.Add(Musteri);

        }
        public void MusteriListele()
        {
            Console.WriteLine("----------Müşteri Listesi----------");
            Console.WriteLine("   ID    - Ad Soyad - D.Yeri");
            Console.WriteLine("-----------------------------------");
            foreach (var item in Musteriler)
            {
                Console.WriteLine(item.Id + " " + item.MusteriAdi + " " + item.MusteriSoyadi + " " + item.MusteriDogumYeri);
            }
        }
        public void ArananMusteriListele(int KimlikNumarasi)
        {
            foreach (var item in Musteriler)
            {
                if (item.Id == KimlikNumarasi)
                {                    
                    Console.WriteLine(item.Id + "   " + item.MusteriAdi + " " + item.MusteriSoyadi + "   " + item.MusteriDogumYeri);
                }
            }
        }

        public void MusteriSil(int KimlikNumarasi)
        {
            var itemToRemove = Musteriler.SingleOrDefault(r => r.Id == KimlikNumarasi);
            if (itemToRemove != null)
                Musteriler.Remove(itemToRemove);
            Console.WriteLine(KimlikNumarasi + " ID nolu kişinin kaydı silindi.");
            Console.WriteLine();
            MusteriListele();
            Menu();
            

        }
        public void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("--MENÜ İŞLEMLER---");
            Console.WriteLine("1- KİŞİ EKLE");
            Console.WriteLine("2- KİŞİ SİL");
            Console.WriteLine("3- LİSTELE");
            Console.WriteLine();
            Console.Write("Hangi işlemi yapmak istiyorsunuz? : ");

            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.Write("Musteri Id(sayı olmalıdır): "); 
                    int a= Convert.ToInt32(Console.ReadLine());
                    Console.Write("Musteri Adı: ");
                    string b = Console.ReadLine();
                    Console.Write("Musteri Soyadı: ");
                    string c = Console.ReadLine();
                    Console.Write("Dogum Yeri: ");
                    string d= Console.ReadLine();                    
                    MusteriEkle(a,b,c,d);
                    Console.WriteLine(a+" "+b+" isimli kullanıcı eklendi...!!");
                    Console.WriteLine();
                    MusteriListele();
                    Menu();
                    break;

                case 2:
                    Console.WriteLine();
                    Console.Write("Silmek için kişinin ID No'sunu yazıp ENTER a basınız. ID: ");
                    int MeunuKey = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    MusteriSil(MeunuKey);                           
                    break;
                case 3:
                    MusteriListele();
                    Menu();
                    break;
                default:
                    Console.WriteLine("yanlış değer girdiniz");
                    break;
            }
            
               



            


        }
    }
}
