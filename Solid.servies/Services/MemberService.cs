using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Solid.servies.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;
        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public async Task <Member> AddMemberAsync(Member member)
        {
         await _memberRepository.AddMemberAsync(member);
            return member;
        }

        public async Task DeleteMemberAsync(int id)
        {
          await   _memberRepository.DeleteMemberAsync(id);
        }

        public Member GetById(int id)
        {
            return _memberRepository.GetById(id);
        }

       

        public  async Task<Member> UpdateMemberAsync(int id, Member member)
        {
           return await _memberRepository.UpdateMemberAsync(id, member);
              
        }

        IEnumerable<Member> IMemberService.GetMembers()
        {
            return _memberRepository.GetMembers();
        }
    }
}
