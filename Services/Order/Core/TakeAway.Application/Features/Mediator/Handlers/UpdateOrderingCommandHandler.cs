using MediatR;
using TakeAway.Application.Features.Mediator.Commands;
using TakeAway.Application.Interfaces;
using TakeAway.Domain.Entities;

namespace TakeAway.Application.Features.Mediator.Handlers
{
    public class UpdateOrderingCommandHandler : IRequestHandler<UpdateOrderingCommand>
    {
        private readonly IRepository<Ordering> _repository;

        public UpdateOrderingCommandHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateOrderingCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.OrderingID);
            values.OrderDate = request.OrderDate;
            values.UserID = request.UserID;
            values.TotalPrice = request.TotalPrice;
            await _repository.UpdateAsync(values);
        }
    }
}
