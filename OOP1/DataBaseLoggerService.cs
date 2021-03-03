using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
