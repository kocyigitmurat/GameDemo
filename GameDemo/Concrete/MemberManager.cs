using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class MemberManager : BaseMemberManager
    {
        private IMemberCheckService _memberCheckService;

        public MemberManager(MemberCheckManager memberCheckManager)
        {
            _memberCheckService = memberCheckManager;
        }

        public override void Save(Member member)
        {
            if (_memberCheckService.CheckIfRealMember(member))
            {
                base.Save(member);
            } else
            {
                throw new Exception("Not a valid member !");
            }
            
        }
    }
}
