using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class FilmContext : DbContext
    {
        public DbSet<Member> Member{ get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Rent> rents { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<TapeDVD> tapes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=FilmDb;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TapeDVD>().HasKey(m => m.CopyID);

            modelBuilder.Entity<Member>().Property(m => m.MemberID).UseIdentityColumn(1, 1);
            modelBuilder.Entity<TapeDVD>().Property(m => m.CopyID).UseIdentityColumn(1, 1);
            modelBuilder.Entity<Rent>().Property(m => m.RentID).UseIdentityColumn(1, 1);
            modelBuilder.Entity<Supplier>().Property(m => m.SupplierID).UseIdentityColumn(1, 1);
            modelBuilder.Entity<Movie>().Property(m => m.MovieID).UseIdentityColumn(1, 1);

            modelBuilder.Entity<Rent>().HasOne(m => m.Member).WithMany(r => r.Rents).HasForeignKey(m => m.MemberID);
            modelBuilder.Entity<Rent>().HasOne(t => t.TapeDVD).WithMany(r => r.Rents).HasForeignKey(t => t.CopyID);
            modelBuilder.Entity<TapeDVD>().HasOne(s => s.Supplier).WithMany(t => t.tapeDVDs).HasForeignKey(s => s.SupplierID);
            modelBuilder.Entity<TapeDVD>().HasOne(m => m.Movie).WithMany(t => t.tapes).HasForeignKey(m => m.MovieID);
            

        }

    }
}
