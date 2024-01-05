namespace Solid.Core.Entities
{
    public class Loan
    {
        public int LoanId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        // Navigation properties
        public int BookId { get; set; } // Foreign key

        public Book Book { get; set; }
        public List<Member> Members { get; set; }

        static private int count = 0;
        public Loan()
        {
            LoanId = count++;
        }



    }
}
