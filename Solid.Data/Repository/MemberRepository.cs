using Microsoft.EntityFrameworkCore;
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
            var temp = _context.Members.Find(id);
            _context.Members.Remove(temp);
            _context.SaveChanges();

        }


        public Member GetById(int id)
        {
            return _context.Members.Find(id);
        }

        public IEnumerable<Member> GetMembers()
        {
            return _context.Members.Include(x=>x.Loans);
        }

        public Member UpdateMember(int id, Member member)
        {
            var temp = _context.Members.Find(id);
            temp = member;
            _context.SaveChanges();
            return temp;
        }
    }
}
