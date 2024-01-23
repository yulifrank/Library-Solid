using Solid.Core.Entities;
using Solid.Core.Repositories;

namespace Solid.Data.Repository
{
    public class LoanRepository : ILoanRepository
    {

        private readonly DataContext _context;

        public LoanRepository(DataContext context)
        {
            _context = context;
        }
        public async Task< Loan >AddLoanAsync(Loan Loan)
        {
            _context.Loans.Add(Loan);
          await   _context.SaveChangesAsync();
            return Loan;
        }

        public async Task DeleteLoanAsync(int id)
        {
            var temp = _context.Loans.Find( id);
            _context.Loans.Remove(temp);
           await _context.SaveChangesAsync();

        }

        public Loan GetById(int id)
        {
            return _context.Loans.Find(id);
        }

        public List<Loan> GetLoans()
        {
            return _context.Loans.ToList();
        }

        public async Task<Loan> UpdateLoanAsync(int id, Loan Loan)
        {
            var temp = _context.Loans.Find(id);
            temp = Loan;
           await _context.SaveChangesAsync();
            return temp;
        }
    }
 
}