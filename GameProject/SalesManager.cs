using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            int campaignPrice = game.GamePrice - ((game.GamePrice * campaign.DiscountRate) / 100); 

            Console.WriteLine(game.GameName + " oyunu " + campaign.CampaignName + " kampanyası ile % " + campaign.DiscountRate +
                " indirimle " +  gamer.Id + " no'lu oyuncu tarafından " + campaignPrice + " TL'ye satın alındı!" );
        }

        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " oyununu " + gamer.Id + " numaralı oyuncu tarafından " +  game.GamePrice + " TL'ye satın alındı!" );
        }
    }
}
