using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface ILoanService
    {
         List<Loan> GetLoans();

         Loan GetById(int id);
        Task<Loan> AddLoanAsync(Loan Loan);

        Task<Loan> UpdateLoanAsync(int id, Loan Loan);

        Task DeleteLoanAsync(int id);
    }
}
