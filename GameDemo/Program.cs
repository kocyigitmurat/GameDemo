using System;
using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ ÜYELİK İŞLEMLERİ ------------");

            Member member = new Member();
            member.Id = "1";
            member.FirstName = "murat";
            member.LastName = "koçyiğit";
            member.BirthDay = "19960904";
            member.TcNo = "12345678901";

            BaseMemberManager memberManager = new MemberManager(new MemberCheckManager());
            memberManager.Save(member);
            memberManager.Delete(member);
            memberManager.Update(member);

            Console.WriteLine("------------ ÜYELİK İŞLEMLERİ SONU ------------");
            Console.WriteLine("");
            Console.WriteLine("------------ KAMPANYA İŞLEMLERİ ------------");
            Campaign campaign = new Campaign();
            campaign.Id = "1";
            campaign.Name = "Açılış";
            campaign.Description = "Açılışa özel Kampanya";

            BaseCampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);

            Console.WriteLine("------------ KAMPANYA İŞLEMLERİ SONU ------------");
            Console.WriteLine("");
            Console.WriteLine("------------ SATIŞ İŞLEMLERİ ------------");
            Sales sale = new Sales();
            sale.Id = "1";
            sale.GameName = "Yılan Oyunu";
            sale.count = 3;

            BaseSalesManager salesManager = new SalesManager();
            salesManager.Add(sale, member, campaign);
            salesManager.Cancel(sale);
            salesManager.Update(sale, member, campaign);
            Console.WriteLine("------------ SATIŞ İŞLEMLERİ SONU ------------");

        }
    }
}
