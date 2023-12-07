
namespace Solid.Core.Entities
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        static private int count = 0;
        public Member()
        {
            MemberId = count++;
        }
        



    }
}
