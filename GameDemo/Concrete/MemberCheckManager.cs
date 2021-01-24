using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class MemberCheckManager : IMemberCheckService
    {
        public bool CheckIfRealMember(Member member)
        {
            return true;
        }
    }
}
