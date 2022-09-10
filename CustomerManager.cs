using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine("Eklenen Müşteri" + " : " + customer.Name + " " + customer.Surname);
            Console.WriteLine("Müşteri Hesabı Başarıyla Eklendi!");
            Console.WriteLine(" ");
           
        }
        
        public void Liste(Customer customer)
        {
            Customer[] customers = new Customer[] { customer };
            foreach (var musteri in customers) 
            {
                Console.WriteLine(musteri.Name + " " + musteri.Surname);
                Console.WriteLine("Müşteri Yaşı : " + musteri.Age);
                Console.WriteLine("Toplam Varlıkları : " + musteri.TotalAssets + " TL ");
                Console.WriteLine("Kredi Skoru : " + musteri.CreditScore);
                Console.WriteLine("Müşteri Hesabı Başarıyla Listelendi!");
                Console.WriteLine(" ");

            }
        }
        
       public void Kaldır(Customer customer)
        {
            Customer[] customers = new Customer[] { customer };
            foreach (var musteri in customers)
            {
                Console.WriteLine("Kaldırılan Müşteri Hesabı : " + musteri.Name + " " + musteri.Surname );
            }
                Console.WriteLine("Müşteri Hesabı Başarıyla Kaldırıldı !");



        }

            
    }
}
