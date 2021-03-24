using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player user)
        {
            if (user.Id==1 && user.FirstName=="SABIR" && user.LastNAme=="AKBANA" && user.BirthDate==1991 && user.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
