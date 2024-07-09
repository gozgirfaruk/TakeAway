using TakeAway.CatalogApi.Dtos.SliderDtos;

namespace TakeAway.CatalogApi.Services.SliderServices
{
    public interface ISliderService
    {
        Task<List<ResultSliderDto>> GetAllSliderAsync();
        Task CreateSliderAsync(CreateSliderDto SliderDto);
        Task UpdateSliderAsync(UpdateSliderDto SliderDto);
        Task DeleteSliderAsync(string id);
        Task<GetByIdSliderDto> GetByIdSliderAsync(string id);
    }
}
