using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public static void Add(Customer customer)
        {
            Console.WriteLine("   *** Yeni Müşteri Eklendi! *** ");
            Console.WriteLine(" Müşteri Numarası : " + customer.Id);
            Console.WriteLine(" Adı              : " + customer.FirstName);
            Console.WriteLine(" Soyadı           : " + customer.LastName);
            Console.WriteLine(" Telefon          : " + customer.Phone);
            Console.WriteLine(" Açıklama         : " + customer.Expl);
            Console.WriteLine();
        }
        public static void List(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName);
        }

        public static void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id+ " Numaralı ------- Müşteri Silindi ------- ");
        }
    }
}
