using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==11111 && gamer.FirstName=="SSSSS" && gamer.LastName=="AAAAA" && gamer.IdentityNumber==22222)
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
