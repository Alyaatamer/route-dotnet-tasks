using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Supplier
    {
        public int SupplierID {  get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }

        public ICollection<TapeDVD> tapeDVDs { get; set; }
    }
}
