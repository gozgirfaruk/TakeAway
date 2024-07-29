using TakeAway.Basket.Dtos;

namespace TakeAway.Basket.Services
{
    public interface IBasketService
    {
        Task<BasketTotalDto> GetBasketTotal(string UserId);
        Task SaveBasket(BasketTotalDto basketTotalDto);
        Task DeleteBasket(string UserId);

    }
}
