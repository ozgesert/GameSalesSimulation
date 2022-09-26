using System;
using System.Collections.Generic;
using System.Text;
using GameSalesSimulation.Entities;

namespace GameSalesSimulation.Abstracts
{
    public interface ICampaignService
    {
        void NewCampaignAdd(Campaign campaign);
        void CampaignDelete(Campaign campaign);
        void CampaignUpdated(Campaign campaign);
       
    }
}
