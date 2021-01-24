using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public interface IMemberService
    {
        void Save(Member member);
        void Delete(Member member);
        void Update(Member member);
    }
}
