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
        void AddLoan(Loan Loan);

        void UpdateLoan(int id, Loan Loan);

        void DeleteLoan(int id);
    }
}
