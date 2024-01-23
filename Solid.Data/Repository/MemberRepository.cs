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
        public  async Task< Member> AddMemberAsync(Member member)
        {
            _context.Members.Add(member);
           await _context.SaveChangesAsync();
            return member;
        }
        public async Task DeleteMemberAsync(int id)
        {
            var temp = _context.Members.Find(id);
            _context.Members.Remove(temp);
            await _context.SaveChangesAsync();

        }
        public Member GetById(int id)
        {
            return _context.Members.Find(id);
        }
        public IEnumerable<Member> GetMembers()
        {
            return _context.Members.Include(x=>x.Loans);
        }
        public async Task< Member> UpdateMemberAsync(int id, Member member)
        {
            var temp = _context.Members.Find(id);
            temp = member;
            await _context.SaveChangesAsync();
            return temp;
        }
    }
}
