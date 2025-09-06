using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Rent
    {
        public int RentID { get; set; }
        public DateTime RentedDate { get; set; }
        public string ReturnDate { get; set; }

        public decimal charge { get; set; }

        public Member Member { get; set; }
        public int MemberID { get; set; }

        public TapeDVD TapeDVD { get; set; }
        public int CopyID { get; set; }

        

    }
}
