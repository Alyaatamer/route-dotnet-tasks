using IKEA.DAL.Models.Auth;
using IKEA.DAL.Models.Employee;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IKEA.DAL.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> optionsBuilder): base(optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        }
}
