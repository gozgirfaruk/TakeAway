using TakeAway.Application.CQRS.Commands.OrderDetailCommands;
using TakeAway.Application.Interfaces;
using TakeAway.Domain.Entities;

namespace TakeAway.Application.CQRS.Handlers.OrderDetailHandlers
{
    public class CreateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repositroy;

        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repositroy)
        {
            _repositroy = repositroy;
        }

        public async Task Handle(CreateOrderDetailCommand command)
        {
            await _repositroy.CreateAsync(new OrderDetail
            {
                Amount = command.Amount,
                OrderingID = command.OrderingID,
                Price = command.Price,
                ProductID = command.ProductID,
                TotalPrice = command.TotalPrice,
                ProductName = command.ProductName
            });
        }
    }
}
