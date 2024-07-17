using Dapper;
using TakeAway.Discount.Context;
using TakeAway.Discount.Dtos;

namespace TakeAway.Discount.Services
{
    public class DiscountCouponService : IDiscountCouponService
    {
        private readonly DiscountContext _context;

        public DiscountCouponService(DiscountContext context)
        {
            _context = context;
        }

        public async Task CreateDiscountCouponAsync(CreateDiscountCouponDto createDiscountCouponDto)
        {
            string query = "Insert Into Coupons (Code,Rate,IsActive) values (@code,@rate,@isactive)";
            var parameters = new DynamicParameters();
            parameters.Add("@code", createDiscountCouponDto.Code);
            parameters.Add("@rate", createDiscountCouponDto.Rate);
            parameters.Add("@isactive", createDiscountCouponDto.IsActive);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

        public async Task DeleteDiscountCouponAsync(int id)
        {
            string query = "Delete From Coupons where CouponID = @p1";
            var parameters = new DynamicParameters();
            parameters.Add("@p1", id);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

        public async Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponList()
        {
            string query = "Select * From Coupons";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultDiscountCouponDto>(query);
            return values.ToList();
        }

        public async Task<GetDiscountCouponByIdDto> GetDiscountCouponById(int id)
        {
            string query = "Select * From Coupons Where CouponID=@p1";
            var parameters = new DynamicParameters();
            parameters.Add("@p1",id);
            var connection = _context.CreateConnection();
            var value = await connection.QueryFirstOrDefaultAsync<GetDiscountCouponByIdDto>(query);
            return value;
        }

        public async Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateDiscountCouponDto)
        {
            string query = "Update Coupons Set Code=@code,Rate=@rate,IsActive=@isavtive Where CouponID=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@code", updateDiscountCouponDto.Code);
            parameters.Add("@rate", updateDiscountCouponDto.Rate);
            parameters.Add("@isactive",updateDiscountCouponDto.IsActive);
            parameters.Add("@id",updateDiscountCouponDto.CouponID);
            var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, parameters);
        }

  
    }
}
