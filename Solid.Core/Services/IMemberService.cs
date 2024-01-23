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
        Task<Member> AddMemberAsync(Member user);
        Task<Member> UpdateMemberAsync(int id, Member user);
        Task DeleteMemberAsync(int id);
    }
}
