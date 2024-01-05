namespace Solid.Core.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }

        static private int count = 0;
        public Book()
        {
            //BookId = count++;
        }
        public List<Loan> Loans { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
    
    
}
