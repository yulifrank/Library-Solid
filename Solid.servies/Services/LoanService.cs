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
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _loanRepository;
        public LoanService(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public void AddLoan(Loan Loan)
        {
            _loanRepository.AddLoan(Loan);
        }

        public void DeleteLoan(int id)
        {
            _loanRepository.DeleteLoan(id);
        }

        public Loan GetById(int id)
        {
            return _loanRepository.GetById(id);    
        }

        public List<Loan> GetLoans()
        {
            return _loanRepository.GetLoans();
        }

        public void UpdateLoan(int id, Loan Loan)
        {
            _loanRepository.UpdateLoan(id, Loan);
        }
    }
}
