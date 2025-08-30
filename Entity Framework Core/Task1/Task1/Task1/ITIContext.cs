using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ITIContext : DbContext
    {
       public DbSet<Student> Students { get; set; }
       public DbSet<Department> Departments { get; set; }
       public DbSet<Instructor> Instructors { get; set; }
       public DbSet<Course> courses { get; set; }
       public DbSet<Topic> Topics { get; set; }
       public DbSet<Stud_Course> Stud_Courses { get; set; }
       public DbSet<Course_Inst> Course_Insts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=ITIDb;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>().HasKey(sc => new { sc.Stud_ID, sc.Course_ID });
            modelBuilder.Entity<Course_Inst>().HasKey(ci => new { ci.Inst_ID, ci.Course_ID });
        }
    }
}
