using ECommerce.Domain.Contracts.Seed;
using ECommerce.Domain.Models.Products;
using ECommerce.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace ECommerce.Persistence.Seed
{
    public class DataSeeding : IDataSeeding
    {
        private readonly StoredDbContext context;

        public DataSeeding(StoredDbContext context)
        {
            this.context = context;
        }
        public async Task DataSeedAsync()
        {
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.ProductBrands.Any())
            {
                var BrandData = await File.ReadAllTextAsync(@"..\InfraStructure\ECommerce.Persistence\Data\brands.json");
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(BrandData);

                if(brands != null && brands.Any())
                {
                    context.ProductBrands.AddRange(brands);
                }
            }

            if (!context.ProductTypes.Any())
            {
                var TypeData = await File.ReadAllTextAsync(@"..\InfraStructure\ECommerce.Persistence\Data\types.json");
                var Types = JsonSerializer.Deserialize<List<ProductType>>(TypeData);

                if (Types != null && Types.Any())
                {
                    context.ProductTypes.AddRange(Types);
                }
            }

            if (!context.Products.Any())
            {
                var ProductsData = await File.ReadAllTextAsync(@"..\InfraStructure\ECommerce.Persistence\Data\products.json");
                var products = JsonSerializer.Deserialize<List<Product>>(ProductsData);

                if (products != null && products.Any())
                {
                    context.Products.AddRange(products);
                }
            }

            context.SaveChanges();
        }
    }
}
