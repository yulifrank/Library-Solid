using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return Loan;
        }

        public void DeleteLoan(int id)
        {
             var temp= _context.Loans.Find(x=>x.LoanId == id);
            _context.Loans.Remove(temp);
          }

        public Loan GetById(int id)
        {
              return _context.Loans.Find(x => x.LoanId == id);
        }

        public List<Loan> GetLoans()
        {
            return _context.Loans;
        }

        public Loan UpdateLoan(int id, Loan Loan)
        {
            var temp = _context.Loans.Find(x => x.LoanId == id);
            temp = Loan;
            return temp;
        }
    }
}
