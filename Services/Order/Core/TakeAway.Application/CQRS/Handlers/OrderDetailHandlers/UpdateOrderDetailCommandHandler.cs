using TakeAway.Application.CQRS.Commands.OrderDetailCommands;
using TakeAway.Application.Interfaces;
using TakeAway.Domain.Entities;

namespace TakeAway.Application.CQRS.Handlers.OrderDetailHandlers
{
    public class UpdateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public UpdateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateOrderDetailCommand command)
        {
            var values = await _repository.GetByIdAsync(command.OrderDetailID);
            values.OrderingID= command.OrderDetailID;
            values.ProductName= command.ProductName;
            values.Amount= command.Amount;
            values.Price= command.Price;
            values.TotalPrice= command.TotalPrice;
            values.ProductID= command.ProductID;
            await _repository.UpdateAsync(values);
        }
    }
}
