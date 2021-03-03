using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ApplyingManager
    {
        public void Apply(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuran Bilgilerini Değerlendirme
            //

            creditManager.Calculate();
            loggerService.Log();
        }

        public void CreditPreInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
