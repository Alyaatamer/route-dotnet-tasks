using MVCApp.DAL.Models.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.DAL.Models.Instructor
{
    public class Instructor : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Course> courses { get; set; } = new HashSet<Course>();
    }
}
