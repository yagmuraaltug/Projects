using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    class CampaignManager : ICampaignManager
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine(campaign.Percentage + "% discount in your order !!");
        }

        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine("Sorry the campaign is finished !");
        }

        public void CampaignUpDate(Campaign campaign)
        {
             Console.WriteLine("The campaign has been updated !");
        }
    }
}
