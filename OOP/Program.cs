using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.Id=1
            customer1.Number = "123456";
            customer1.FirstName = "Sabır";
            customer1.LastName = "Akbana";
            customer1.TcNo = "12345678910";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.Number = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new RealCustomer();
            Customer customer4 = new CorporateCustomer();
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

        }
    }
}
