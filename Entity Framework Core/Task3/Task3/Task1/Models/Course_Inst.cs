using System.ComponentModel.DataAnnotations;

namespace Task3
{
    public class Course_Inst
    {
        public int Inst_ID { get; set; }
        public virtual Instructor Instructor { get; set; } = null!;

        public int Course_ID { get; set; }
        public virtual Course Course { get; set; } = null!;

        [Required]
        public string Evaluation { get; set; }
    }
}
