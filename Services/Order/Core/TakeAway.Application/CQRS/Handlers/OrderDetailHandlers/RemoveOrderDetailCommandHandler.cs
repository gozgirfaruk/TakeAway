using TakeAway.Application.CQRS.Commands.OrderDetailCommands;
using TakeAway.Application.Interfaces;
using TakeAway.Domain.Entities;

namespace TakeAway.Application.CQRS.Handlers.OrderDetailHandlers
{
    public class RemoveOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public RemoveOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveOrderDetailCommand command)
        {
            await _repository.DeleteAsync(command.OrderDetailID);
        }
    }
}