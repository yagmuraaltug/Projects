using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    interface ICampaignManager
    {
        void CampaignAdd(Campaign campaign);
        void CampaignUpDate(Campaign campaign);
        void CampaignDelete(Campaign campaign);

    }
}
