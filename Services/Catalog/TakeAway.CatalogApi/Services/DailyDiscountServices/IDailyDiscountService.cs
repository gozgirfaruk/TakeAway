using TakeAway.CatalogApi.Dtos.DailyDiscountDtos;

namespace TakeAway.CatalogApi.Services.DailyDiscountServices
{
    public interface IDailyDiscountService
    {
        Task<List<ResultDailyDiscountDto>> GetAllDailyDiscountAsync();
        Task CreateDailyDiscountAsync(CreateDailyDiscountDto DailyDiscountDto);
        Task UpdateDailyDiscountAsync(UpdateDailyDiscountDto DailyDiscountDto);
        Task DeleteDailyDiscountAsync(string id);
        Task<GetByIdDailyDiscountDto> GetByIdDailyDiscountAsync(string id);
    }
}
