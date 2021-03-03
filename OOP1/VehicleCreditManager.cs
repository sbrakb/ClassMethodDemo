using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }

        public void DoSmthn()
        {
            throw new NotImplementedException();
        }
    }
}
