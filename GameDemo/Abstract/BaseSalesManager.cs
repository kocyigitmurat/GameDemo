using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public abstract class BaseSalesManager : ISalesService
    {
        public void Add(Sales sales, Member member, Campaign campaign)
        {
            Console.WriteLine(member.FirstName + " isimli üye " + sales.count + "adet " + sales.GameName+ " oyundan satın almıştır.");
            if(campaign != null)
            {
                Console.WriteLine("Bu satın alma işleminde, " + campaign.Name + " isimli Kampanyadan yaralanılmıştır");
            }
        }

        public void Cancel(Sales sales)
        {
            Console.WriteLine(sales.Id + " numaralı Sipariş iptal edilmiştir !");
        }

        public void Update(Sales sales, Member member, Campaign campaign)
        {           
            Console.WriteLine(sales.Id + " numaralı Sipariş güncellenmiştir.");
        }
    }
}
