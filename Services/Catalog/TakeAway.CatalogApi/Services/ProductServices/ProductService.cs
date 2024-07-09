using TakeAway.CatalogApi.Dtos.ProductDtos;

namespace TakeAway.CatalogApi.Services.ProductServices
{
    public class ProductService : IProductService
    {
        public Task CreateProductAsync(CreateProductDto ProductDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultProductDto>> GetAllProductAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdProductDto> GetByIdProductAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(UpdateProductDto ProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
