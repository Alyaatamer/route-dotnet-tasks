using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Rent> Rents { get; set; } = new HashSet<Rent>();
    }
}
