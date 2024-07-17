using TakeAway.Discount.Dtos;

namespace TakeAway.Discount.Services
{
    public interface IDiscountCouponService
    {
        Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponList();
        Task CreateDiscountCouponAsync(CreateDiscountCouponDto createDiscountCouponDto);
        Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateDiscountCouponDto);
        Task DeleteDiscountCouponAsync(int id);
       Task<GetDiscountCouponByIdDto> GetDiscountCouponById(int id);
    }
}
