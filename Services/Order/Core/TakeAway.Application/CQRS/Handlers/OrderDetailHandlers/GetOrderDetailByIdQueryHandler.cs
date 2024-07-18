using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAway.Application.CQRS.Queries.OrderDetailQueries;
using TakeAway.Application.CQRS.Results.OrderDetailResult;
using TakeAway.Application.Interfaces;
using TakeAway.Domain.Entities;

namespace TakeAway.Application.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailByIdQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.OrderDetailID);
            return new GetOrderDetailByIdQueryResult
            {
                Amount = values.Amount,
                OrderDetailID = values.OrderDetailID,
                OrderingID = values.OrderDetailID,
                Price = values.Price,
                ProductName = values.ProductName,
                ProductID = values.ProductID,
                TotalPrice = values.TotalPrice,
            };
        }
    }
}
