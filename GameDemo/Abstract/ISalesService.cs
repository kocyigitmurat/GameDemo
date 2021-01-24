using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public interface ISalesService
    {
        void Add(Sales sales, Member member, Campaign campaign);
        void Update(Sales sales, Member member, Campaign campaign);
        void Cancel(Sales sales);
    }
}
