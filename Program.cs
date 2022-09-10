using System;

namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // Müşteriler
            Customer musteri1 = new Customer();
            musteri1.Name = "Kezban";
            musteri1.Surname = "Mutsuz";
            musteri1.Age = 31;
            musteri1.TotalAssets = 19000;
            musteri1.CreditScore = 400;

            Customer musteri2 = new Customer();
            musteri2.Name = "Alican";
            musteri2.Surname = "Kabak";
            musteri2.Age = 27;
            musteri2.TotalAssets = 475000;
            musteri2.CreditScore = 650;

            Customer musteri3 = new Customer();
            musteri3.Name = "Rahmi";
            musteri3.Surname = "Keçi";
            musteri3.Age = 59;
            musteri3.TotalAssets = 39000000;
            musteri3.CreditScore = 750;

            
            // Manager İşlemleri
            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
            customerManager.Ekle(musteri3);

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Liste(musteri1);
            customerManager1.Liste(musteri2);
            customerManager1.Liste(musteri3);

            CustomerManager customerManager3 = new CustomerManager();
            customerManager3.Kaldır(musteri1);




        }
    }
}
