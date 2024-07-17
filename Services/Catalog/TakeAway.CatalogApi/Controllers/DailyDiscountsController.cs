using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAway.CatalogApi.Dtos.DailyDiscountDtos;
using TakeAway.CatalogApi.Services.DailyDiscountServices;

namespace TakeAway.CatalogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyDiscountsController : ControllerBase
    {
        private readonly IDailyDiscountService _dailyDiscountService;

        public DailyDiscountsController(IDailyDiscountService dailyDiscountService)
        {
            _dailyDiscountService = dailyDiscountService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDailyDiscountList()
        {
            var values = await _dailyDiscountService.GetAllDailyDiscountAsync();
            return Ok(values);
        }
        [HttpGet("GetDailyDiscountById")]
        public async Task<IActionResult> GetDailyDiscountById(string id)
        {
            var values = await _dailyDiscountService.GetByIdDailyDiscountAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> InsertDailyDiscount(CreateDailyDiscountDto createDailyDiscountDto)
        {
            await _dailyDiscountService.CreateDailyDiscountAsync(createDailyDiscountDto);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDailyDiscount(UpdateDailyDiscountDto updateDailyDiscountDto)
        {
            await _dailyDiscountService.UpdateDailyDiscountAsync(updateDailyDiscountDto);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDailyDiscount(string id)
        {
            await _dailyDiscountService.DeleteDailyDiscountAsync(id);
            return Ok();
        }
    }
}
