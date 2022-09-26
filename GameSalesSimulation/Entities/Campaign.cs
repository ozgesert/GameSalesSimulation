﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Entities
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public TimeSpan CampaignDuration { get; set; }
        public string CampaignName { get; set; }
    }
}
