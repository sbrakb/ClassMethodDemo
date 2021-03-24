using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player user)
        {
            if (_userValidationService.Validate(user)==true)
            {
                Console.WriteLine("Kayıt Olundu");
            }
            else
            {
                Console.WriteLine("Kulannıcı Bilgileri Hatalı. Kayıt Başarısız.");
            }
        }

        public void Delete(Player user)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Player user)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
