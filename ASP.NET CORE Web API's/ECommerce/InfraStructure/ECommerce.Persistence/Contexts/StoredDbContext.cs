using ECommerce.Domain.Models.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persistence.Contexts
{
    public class StoredDbContext : DbContext
    {

        public StoredDbContext(DbContextOptions<StoredDbContext> options): base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StoredDbContext).Assembly);
        }

        public DbSet<Product> Products { get; set; } 
        public DbSet<ProductBrand> ProductBrands { get; set; } 
        public DbSet<ProductType> ProductTypes { get; set; } 
    }
}
