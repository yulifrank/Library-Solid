using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void AddMember(Member user)
        {
          _memberRepository.AddMember(user);
        }

        public void DeleteMember(int id)
        {
            _memberRepository.DeleteMember(id);
        }

        public Member GetById(int id)
        {
            return _memberRepository.GetById(id);
        }

       

        public void UpdateMember(int id, Member user)
        {
            _memberRepository.UpdateMember(id, user);
        }

        IEnumerable<Member> IMemberService.GetMembers()
        {
            return _memberRepository.GetMembers();
        }
    }
}
