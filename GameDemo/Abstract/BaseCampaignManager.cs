using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " isimli Kampanya eklenmiştir");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " isimli Kampanya silinmiştir");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " isimli Kampanya güncellenmiştir");
        }
    }
}
