namespace Solid.Core.Entities
{
    public class Loan
    {
        public int LoanId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        // Navigation properties
        public int MemberId { get; set; } // Foreign key

        public Member Member { get; set; }
        public List<Book> Books { get; set; }

       



    }
}
