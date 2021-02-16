using System;

namespace GameStoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerValidation());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                DateOfBirth = "31.07.1995",
                FirstName = "Yagmur",
                LastName = "Altug",
                NationalityId = "11"
            }) ;

            OrderManager orderManager = new OrderManager();
            orderManager.Sale(new Order
            {
                Id = 1,
                OrderName = "Chess",
                OrderPrice = 150
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.CampaignAdd(new Campaign
            {
                Id = 1,
                Percentage = 20
            }
                );
        }
    }
}
