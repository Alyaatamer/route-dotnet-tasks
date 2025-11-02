using AutoMapper;
using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Contracts.UOW;
using ECommerce.Domain.Models.Products;
using ECommerce.Service.Specifications;
using ECommerce.Shared.DTO_s;

namespace ECommerce.Service.Services
{
    public class ProductServices(IUnitOfWork unitOfWork , IMapper mapper) : IProductServices
    {
        private readonly IMapper mapper = mapper;

        public async Task<IEnumerable<BrandDTO>> GetAllBrandsAsync()
        {
            var Repo = unitOfWork.GetRebosatory<ProductBrand, int>();
            var Brands = await Repo.GetAllAsync();
            var BrandDto = mapper.Map<IEnumerable<ProductBrand>, IEnumerable<BrandDTO>>(Brands);
            return BrandDto;
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync(int? BrandId, int? TypeId)
        {
            var Spec = new ProductSpecifications(BrandId, TypeId);
            var Products = await unitOfWork.GetRebosatory<Product, int>().GetAllWithSpecificationsAsync(Spec);
            return mapper.Map<IEnumerable<Product>, IEnumerable<ProductDTO>>(Products);
        }

        public async Task<IEnumerable<TypeDTO>> GetAllTypesAsync()
        {
            var Types = await unitOfWork.GetRebosatory<ProductType, int>().GetAllAsync();
            return mapper.Map<IEnumerable<ProductType>, IEnumerable<TypeDTO>>(Types);
        }

        public async Task<ProductDTO> GetProductByIdAsync(int id)
        {
            var Spec = new ProductSpecifications(id);
            var Product = await unitOfWork.GetRebosatory<Product, int>().GetByIdWithSpecificationAsync(Spec);
            return mapper.Map<Product, ProductDTO>(Product);
        }
    }
}
