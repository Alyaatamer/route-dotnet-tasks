using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task3
{
    [Table("Topics")]
    public class Topic
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
