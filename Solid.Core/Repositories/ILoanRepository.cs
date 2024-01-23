using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ILoanRepository
    {
       List<Loan> GetLoans();

        Loan GetById(int id);

        Task<Loan> AddLoanAsync(Loan Loan);

        Task<Loan> UpdateLoanAsync(int id, Loan Loan);

        Task DeleteLoanAsync(int id);
    }
}
