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

        public async Task<Loan> AddLoanAsync(Loan Loan)
        {
            await _loanRepository.AddLoanAsync(Loan);
            return Loan;
            
        }

        public async Task DeleteLoanAsync(int id)
        {
           await _loanRepository.DeleteLoanAsync(id);
        }

        public Loan GetById(int id)
        {
            return _loanRepository.GetById(id);    
        }

        public List<Loan> GetLoans()
        {
            return _loanRepository.GetLoans();
        }

        public async Task<Loan> UpdateLoanAsync(int id, Loan Loan)
        {
          return await _loanRepository.UpdateLoanAsync(id, Loan);
     
        }
    }
}
