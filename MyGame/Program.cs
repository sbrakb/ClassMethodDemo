using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(new Player
            {
                Id = 1,
                BirthDate = 1991,
                FirstName = "SABIR",
                LastNAme = "AKBANA",
                IdentityNumber = 12345,

            });
            Console.WriteLine("Hello World!");
        }
    }
}
