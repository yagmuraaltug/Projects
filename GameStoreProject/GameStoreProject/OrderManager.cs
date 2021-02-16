using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    class OrderManager : IOrder
    {
        ICampaignManager _campaignManager;

        public OrderManager()
        {
        }

        public OrderManager(ICampaignManager campaignManager)
        {
            _campaignManager = campaignManager;
        }

        public void Sale(Order order)

        {
            Console.WriteLine(order.OrderName + "is in your basket now !");
        }

    
    }
}
