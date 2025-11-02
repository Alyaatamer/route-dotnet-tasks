using ECommerce.Abstraction.IServices;
using ECommerce.Shared.DTO_s;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Persentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController(IServicesManger servicesManger) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAllProducts(int? BrandId , int? TypeId)
        {
            var Products = await servicesManger.ProductServices.GetAllProductsAsync(BrandId , TypeId);
            return Ok(Products);
        }
        [HttpGet("Brands")]
        public async Task<ActionResult<IEnumerable<BrandDTO>>> GetAllBrands()
        {
            var Brands = await servicesManger.ProductServices.GetAllBrandsAsync();
            return Ok(Brands);
        }
        [HttpGet("Types")]
        public async Task<ActionResult<IEnumerable<TypeDTO>>> GetAllTypes()
        {
            var Types = await servicesManger.ProductServices.GetAllTypesAsync();
            return Ok(Types);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProductById(int id)
        {
            var Product = await servicesManger.ProductServices.GetProductByIdAsync(id);
            return Ok(Product);
        }
    }
}
