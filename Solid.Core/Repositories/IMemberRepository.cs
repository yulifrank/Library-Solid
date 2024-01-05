using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();

        Member GetById(int id);

        Member AddMember(Member user);

        Member UpdateMember(int id, Member user);

        void DeleteMember(int id);
    }
}
