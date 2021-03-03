using System;
using System.Collections.Generic;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalFinanceCreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            HouseCreditManager houseCreditManager = new HouseCreditManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            ApplyingManager applyingManager = new ApplyingManager();
            applyingManager.Apply(personalFinanceCreditManager, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager , vehicleCreditManager};

            //applyingManager.CreditPreInfo(credits);





        }
    }
}
