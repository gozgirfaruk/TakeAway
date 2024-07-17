using AutoMapper;
using MongoDB.Driver;
using TakeAway.CatalogApi.Dtos.CategoryDtos;
using TakeAway.CatalogApi.Dtos.SliderDtos;
using TakeAway.CatalogApi.Entities;
using TakeAway.CatalogApi.Settings;

namespace TakeAway.CatalogApi.Services.SliderServices
{
    public class SliderService : ISliderService
    {
        private readonly IMongoCollection<Slider> _slidercollection;
        private readonly IMapper _mapper;

        public SliderService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _slidercollection = database.GetCollection<Slider>(_databaseSettings.SliderCollectionName);
            _mapper = mapper;
        }

        public async Task CreateSliderAsync(CreateSliderDto sliderDto)
        {
            await _slidercollection.InsertOneAsync(_mapper.Map<Slider>(sliderDto));
        }

        public async Task DeleteSliderAsync(string id)
        {
            await _slidercollection.DeleteOneAsync(x => x.SliderID == id);
        }

        public async Task<List<ResultSliderDto>> GetAllSliderAsync()
        {
            var values = await _slidercollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultSliderDto>>(values);
        }

        public async Task<GetByIdSliderDto> GetByIdSliderAsync(string id)
        {
            var values = await _slidercollection.Find<Slider>(x => x.SliderID == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdSliderDto>(values);
        }

        public async Task UpdateSliderAsync(UpdateSliderDto sliderDto)
        {
            var values = _mapper.Map<Slider>(sliderDto);
            await _slidercollection.FindOneAndReplaceAsync(x => x.SliderID == sliderDto.SliderID, values);
        }
    }
}
