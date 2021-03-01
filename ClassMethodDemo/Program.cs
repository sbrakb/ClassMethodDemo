using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 101235, FirstName = "Mesut", LastName = "Özil", Phone = 19071907, Expl = "Yeni Müşteri" };   
            Customer customer2 = new Customer { Id = 101453, FirstName = "İrfan Can", LastName = "Kahveci", Phone = 19051907, Expl = "Mevcut Borcu Ödenmemiş" };
            Customer customer3 = new Customer { Id = 101324, FirstName = "Arda", LastName = "Turan", Phone = 19051905, Expl = "Yeni Kredi Talebi" };

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (Customer customer in customers)
            {
                CustomerManager.Add(customer);
            }

            Console.WriteLine(" *** Müşteri Listesi *** ");

            foreach (Customer customer in customers)
            {
                CustomerManager.List(customer);
            }

            Console.WriteLine();

            foreach (Customer customer in customers)
            {
                CustomerManager.Delete(customer);
            }

        }


        
    }
}
