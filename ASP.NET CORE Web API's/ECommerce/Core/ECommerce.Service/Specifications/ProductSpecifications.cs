using ECommerce.Domain.Models.Products;
using System;

namespace ECommerce.Service.Specifications
{
    public class ProductSpecifications : BaseSpecifications<Product, int>
    {
        public ProductSpecifications(int? BrandId, int? TypeId) :
            base(p => (!BrandId.HasValue || p.BrandId == BrandId) && (!TypeId.HasValue || p.TypeId == TypeId))
        {
            AddIncludes(p => p.Brand);
            AddIncludes(p => p.Type);
        }
        public ProductSpecifications(int id) : base(p => p.Id == id)
        {
            AddIncludes(p => p.Brand);
            AddIncludes(p => p.Type);
        }
    }
}
