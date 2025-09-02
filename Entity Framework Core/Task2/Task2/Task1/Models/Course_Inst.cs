using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    public class Course_Inst
    {
        public int Inst_ID { get; set; }
        public Instructor Instructor { get; set; }

        public int Course_ID { get; set; }
        public Course Course { get; set; }

        [Required]
        public string Evaluation { get; set; }
    }
}
