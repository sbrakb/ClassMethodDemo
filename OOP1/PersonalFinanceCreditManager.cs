using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }

        public void DoSmthn()
        {
            throw new NotImplementedException();
        }
    }
}
