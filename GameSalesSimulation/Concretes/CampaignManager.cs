using GameSalesSimulation.Abstracts;
using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Concretes
{
    public class CampaignManager : ICampaignService
    {
        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted " +campaign.CampaignName);
        }

        public void CampaignUpdated(Campaign campaign)
        {
            Console.WriteLine("Campaign updated " + campaign.CampaignName);
        }

        public void NewCampaignAdd(Campaign campaign)
        {
            Console.WriteLine("New ampaign added " + campaign.CampaignName);
        }
    }
}
