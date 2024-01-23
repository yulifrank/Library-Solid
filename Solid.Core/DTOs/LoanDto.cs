using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class LoanDto
    {
        public int LoanId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        // Navigation properties
        public int MemberId { get; set; } // Foreign key

    }
}
