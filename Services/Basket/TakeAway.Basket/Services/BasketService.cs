using TakeAway.Basket.Dtos;

namespace TakeAway.Basket.Services
{
    public class BasketService : IBasketService
    {
        public Task DeleteBasket(string UserId)
        {
            throw new NotImplementedException();
        }

        public Task<BasketTotalDto> GetBasketTotal(string UserId)
        {
            throw new NotImplementedException();
        }

        public Task SaveBasket(BasketTotalDto basketTotalDto)
        {
            throw new NotImplementedException();
        }
    }
}
