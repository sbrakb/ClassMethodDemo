using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncu Kayıt(doğrulama gerekli)-silme-güncelleme

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "gamer1", LastName = "gamer11", BirthYear = 1111, IdentityNumber = 11 });
            gamerManager.Delete(new Gamer { Id = 2, FirstName = "gamer2", LastName = "gamer22", BirthYear = 2222, IdentityNumber = 22 });
            gamerManager.Update(new Gamer { Id = 3, FirstName = "gamer3", LastName = "gamer33", BirthYear = 3333, IdentityNumber = 33 });


            //Oyun ekleme-silme-güncelleme

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game { GameId = 1, GameName = "Game1", GamePrice = 270 });
            gameManager.Delete(new Game { GameId = 2, GameName = "Game2", GamePrice = 300 });
            gameManager.Update(new Game { GameId = 3, GameName = "Game3", GamePrice = 210 });

            // Kampanyalar

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { CampaignId = 1, CampaignName = "Kampanya1", DiscountRate = 10 });
            campaignManager.Delete(new Campaign { CampaignId = 1, CampaignName = "Kampanya1", DiscountRate = 10 });
            campaignManager.Update(new Campaign { CampaignId = 1, CampaignName = "Kampanya1", DiscountRate = 10 });

            //Satış-İndirimli satış

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(new Game { GameId = 1, GameName = "Game1", GamePrice = 270 }, new Gamer { Id = 3, FirstName = "gamer3", LastName = "gamer33", BirthYear = 3333, IdentityNumber = 33 });
           
            salesManager.CampaignSales(new Game { GameId = 2, GameName = "Game2", GamePrice = 300 },
                                       new Gamer { Id = 3, FirstName = "gamer3", LastName = "gamer33", BirthYear = 3333, IdentityNumber = 33 },
                                       new Campaign { CampaignId = 1, CampaignName = "Kampanya1", DiscountRate = 10 }
                                       );


        }
    }
}
