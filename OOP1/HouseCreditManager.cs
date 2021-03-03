using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class HouseCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }

        public void DoSmthn()
        {
            throw new NotImplementedException();
        }
    }
}
