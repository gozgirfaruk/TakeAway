using AutoMapper;
using MongoDB.Driver;
using TakeAway.CatalogApi.Dtos.ProductDtos;
using TakeAway.CatalogApi.Entities;
using TakeAway.CatalogApi.Settings;

namespace TakeAway.CatalogApi.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database=client.GetDatabase(_databaseSettings.DatabaseName);
            _productCollection=database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
            _mapper = mapper;
        }

        public async Task CreateProductAsync(CreateProductDto productDto)
        {
            await _productCollection.InsertOneAsync(_mapper.Map<Product>(productDto));
        }

        public async Task DeleteProductAsync(string id)
        {
            await _productCollection.DeleteOneAsync(x=>x.ProductID == id);
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            var values = await _productCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values);
        }

        public async Task<GetByIdProductDto> GetByIdProductAsync(string id)
        {
            var values = await _productCollection.Find(x => x.ProductID == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdProductDto>(values);
        }

        public async Task UpdateProductAsync(UpdateProductDto productDto)
        {
            await _productCollection.FindOneAndReplaceAsync(x=>x.ProductID==productDto.ProductID,_mapper.Map<Product>(productDto));
        }
    }
}
