using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAway.CatalogApi.Dtos.SliderDtos;
using TakeAway.CatalogApi.Services.SliderServices;

namespace TakeAway.CatalogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private readonly ISliderService _sliderService;

        public SlidersController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSliderList()
        {
            var values = await _sliderService.GetAllSliderAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> InsertSlider(CreateSliderDto createSliderDto)
        {
            await _sliderService.CreateSliderAsync(createSliderDto);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            await _sliderService.UpdateSliderAsync(updateSliderDto);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteSlider(string id)
        {
            await _sliderService.DeleteSliderAsync(id);
            return Ok();
        }
        [HttpGet("GetSliderById")]
        public async Task<IActionResult> GetSliderById(string id)
        {
            var values = await _sliderService.GetByIdSliderAsync(id);
            return Ok(values);
        }
    }
}
