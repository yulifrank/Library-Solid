using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repository
{
    public class MemberRepository : IMemberRepository
    {

        private readonly DataContext _context;

        public MemberRepository(DataContext context)
        {
            _context = context;
        }
        public Member AddMember(Member member)
        {
            _context.Members.Add(member);
            return member;
        }

        public void DeleteMember(int id)
        {
            var temp = _context.Members.Find(x => x.MemberId == id);
            _context.Members.Remove(temp);
        }

        public Member GetById(int id)
        {
            return _context.Members.Find(x => x.MemberId == id);
        }

        public List<Member> GetMembers()
        {
            return _context.Members;
        }

        public Member UpdateMember(int id, Member member)
        {
            var temp = _context.Members.Find(x => x.MemberId == id);
            temp = member;
            return temp;
        }
    }
}
