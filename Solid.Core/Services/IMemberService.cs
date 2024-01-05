using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IMemberService
    {
        IEnumerable<Member> GetMembers();
         Member GetById(int id);
        void AddMember(Member user);

        void UpdateMember(int id, Member user);

        void DeleteMember(int id);
    }
}
