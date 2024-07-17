namespace TakeAway.Discount.Dtos
{
    public class GetDiscountCouponByIdDto
    {
        public int CouponID { get; set; }
        public string Code { get; set; }
        public int Rate { get; set; }
        public bool IsActive { get; set; }
    }
}
