using ECommerce.Shared.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Abstraction.IServices
{
    public interface IProductServices
    {
        public Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
        public Task<IEnumerable<TypeDTO>> GetAllTypesAsync();
        public Task<IEnumerable<BrandDTO>> GetAllBrandsAsync();
        public Task<ProductDTO> GetProductByIdAsync(int id);
    }
}
