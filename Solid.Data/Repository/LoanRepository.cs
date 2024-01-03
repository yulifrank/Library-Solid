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
        public Loan AddLoan(Loan Loan)
        {
            _context.Loans.Add(Loan);
            _context.SaveChanges();
            return Loan;
        }

        public void DeleteLoan(int id)
        {
            var temp = _context.Loans.Find( id);
            _context.Loans.Remove(temp);
            _context.SaveChanges();

        }

        public Loan GetById(int id)
        {
            return _context.Loans.Find(id);
        }

        public List<Loan> GetLoans()
        {
            return _context.Loans.ToList();
        }

        public Loan UpdateLoan(int id, Loan Loan)
        {
            var temp = _context.Loans.Find(id);
            temp = Loan;
            _context.SaveChanges();
            return temp;
        }
    }
 
}