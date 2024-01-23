
namespace Solid.Core.Entities
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Loan> Loans { get; set; }
       
    }
}
