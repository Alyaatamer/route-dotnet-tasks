using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.BLL.Dto_s.DepartmentDto_s
{
    public class CreatedDepartmentDto
    {
        [Required (ErrorMessage = "Name is required")]
        public String Name {  get; set; }
        [Required(ErrorMessage = "Code is required")]
        public String Code { get; set; }
        public String Description { get; set; }
    }
}
