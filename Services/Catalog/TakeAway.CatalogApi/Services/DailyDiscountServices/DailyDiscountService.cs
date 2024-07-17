using AutoMapper;
using MongoDB.Driver;
using TakeAway.CatalogApi.Dtos.DailyDiscountDtos;
using TakeAway.CatalogApi.Entities;
using TakeAway.CatalogApi.Settings;

namespace TakeAway.CatalogApi.Services.DailyDiscountServices
{
    public class DailyDiscountService : IDailyDiscountService
    {
        private readonly IMongoCollection<DailyDiscount> _dailyDiscountCollection;
        private readonly IMapper _mapper;

        public DailyDiscountService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _dailyDiscountCollection=database.GetCollection<DailyDiscount>(_databaseSettings.DailyDiscountCollectionName);
            _mapper = mapper;
        }

        public async Task CreateDailyDiscountAsync(CreateDailyDiscountDto dailyDiscountDto)
        {
           await _dailyDiscountCollection.InsertOneAsync(_mapper.Map<DailyDiscount>(dailyDiscountDto));
        }

        public async Task DeleteDailyDiscountAsync(string id)
        {
            await _dailyDiscountCollection.DeleteOneAsync(x=>x.DailyDiscountID == id);
        }

        public async Task<List<ResultDailyDiscountDto>> GetAllDailyDiscountAsync()
        {
            var values = await _dailyDiscountCollection.Find(x=>true).ToListAsync();
            return _mapper.Map<List<ResultDailyDiscountDto>>(values);
        }

        public async Task<GetByIdDailyDiscountDto> GetByIdDailyDiscountAsync(string id)
        {
            var values = await _dailyDiscountCollection.Find(x => x.DailyDiscountID == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdDailyDiscountDto>(values);
        }

        public async Task UpdateDailyDiscountAsync(UpdateDailyDiscountDto dailyDiscountDto)
        {
            var values = _mapper.Map<DailyDiscount>(dailyDiscountDto);
            await _dailyDiscountCollection.FindOneAndReplaceAsync(x=>x.DailyDiscountID==dailyDiscountDto.DailyDiscountID, values);
        }
    }
}
