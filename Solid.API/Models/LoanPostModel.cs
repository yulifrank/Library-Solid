namespace Solid.API.Models
{
    public class LoanPostModel
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int MemberId { get; set; } // Foreign key

    }
}
