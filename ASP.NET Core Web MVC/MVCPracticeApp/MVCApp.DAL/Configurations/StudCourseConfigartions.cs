using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCApp.DAL.Models;
using MVCApp.DAL.Models.Instructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.DAL.Configurations
{
    public class StudCourseConfigartions : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(x => new
            {
                x.CourseId,
                x.StudentId,
            });
        }
    }
}
