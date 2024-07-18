using TakeAway.Application.CQRS.Results.OrderDetailResult;
using TakeAway.Application.Interfaces;
using TakeAway.Domain.Entities;

namespace TakeAway.Application.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
    
        public async Task<List<GetOrderDetailQueryResult>> Handle()
        {
            var values = await _repository.GetAllListasync();
            return values.Select(x => new GetOrderDetailQueryResult
            {
                Amount = x.Amount,
                OrderDetailID = x.OrderDetailID,
                OrderingID = x.OrderingID,
                Price = x.Price,
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                TotalPrice =x.TotalPrice
            }).ToList();
        }
    }
}
