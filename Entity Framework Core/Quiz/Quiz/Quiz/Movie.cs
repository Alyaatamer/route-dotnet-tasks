using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public ICollection<TapeDVD> tapes { get; set; } = new HashSet<TapeDVD>();
    }
}
