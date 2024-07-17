using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TakeAway.Discount.Dtos;
using TakeAway.Discount.Services;

namespace TakeAway.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountCouponService _couponService;

        public DiscountsController(IDiscountCouponService couponService)
        {
            _couponService = couponService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDiscountCouponList()
        {
            var values =await _couponService.GetAllDiscountCouponList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscountCouponById(int id)
        {
            var values = await _couponService.GetDiscountCouponById(id);
            return Ok(values);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _couponService.DeleteDiscountCouponAsync(id);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> InsertDiscountCoupon(CreateDiscountCouponDto createDiscountCouponDto)
        {
            await _couponService.CreateDiscountCouponAsync(createDiscountCouponDto);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountCouponDto updateDiscountCouponDto)
        {
            await _couponService.UpdateDiscountCouponAsync(updateDiscountCouponDto);
            return Ok();
        }
    }
}
