using Microsoft.EntityFrameworkCore;
using MVCApp.DAL.Models;
using MVCApp.DAL.Models.Courses;
using MVCApp.DAL.Models.Instructor;
using MVCApp.DAL.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.DAL.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> optionsBuilder) : base(optionsBuilder){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<StudentCourse> Stud_Courses { get; set; }
    }
}
