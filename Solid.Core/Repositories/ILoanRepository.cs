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

        Loan AddLoan(Loan Loan);

        Loan UpdateLoan(int id, Loan Loan);

        void DeleteLoan(int id);
    }
}
