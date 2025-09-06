using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Task3
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
             optionsBuilder
            .UseSqlServer(@"Server=.;Database=ITIDb;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;")
            .UseLazyLoadingProxies();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Stud_Course>().HasKey(sc => new { sc.Stud_ID, sc.Course_ID });
            modelBuilder.Entity<Course_Inst>().HasKey(ci => new { ci.Inst_ID, ci.Course_ID });

            modelBuilder.Entity<Stud_Course>().HasKey(sc => new { sc.Stud_ID, sc.Course_ID });

            modelBuilder.Entity<Stud_Course>().HasOne(sc => sc.Student).WithMany(s => s.Stud_Courses).HasForeignKey(sc => sc.Stud_ID);

            modelBuilder.Entity<Stud_Course>().HasOne(sc => sc.Course).WithMany(c => c.Stud_Courses).HasForeignKey(sc => sc.Course_ID);

            
            modelBuilder.Entity<Course_Inst>().HasKey(ci => new { ci.Inst_ID, ci.Course_ID });

            modelBuilder.Entity<Course_Inst>().HasOne(ci => ci.Instructor).WithMany(i => i.Course_Insts).HasForeignKey(ci => ci.Inst_ID);

            modelBuilder.Entity<Course_Inst>().HasOne(ci => ci.Course).WithMany(c => c.Course_Insts).HasForeignKey(ci => ci.Course_ID);
        }
    }
}
