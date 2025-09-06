using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class TapeDVD
    {
        public int CopyID { get; set; }
        public decimal PurchasedPrice { get; set; }
        public DateTime PurchasedDate { get; set; }

        public int MovieID { get; set; }
        public int SupplierID { get; set; }
        public ICollection<Rent> Rents { get; set; } = new HashSet<Rent>();

        public Supplier Supplier { get; set; }

        public Movie Movie { get; set; }
    }
}
