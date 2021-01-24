using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public class BaseMemberManager : IMemberService
    {
        public virtual void Delete(Member member)
        {
            Console.WriteLine(member.FirstName + " isimli üye silindi");
        }

        public virtual void Save(Member member)
        {
            Console.WriteLine(member.FirstName + " isimli üye eklendi");
        }

        public virtual void Update(Member member)
        {
            Console.WriteLine(member.FirstName + " isimli üye güncellendi");
        }
    }
}
