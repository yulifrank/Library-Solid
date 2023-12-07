namespace Solid.Core.Entities
{
    public class Loan
    {
        public int LoanId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }


        static private int count = 0;
        public Loan()
        {
            LoanId = count++;
        }



    }
}
