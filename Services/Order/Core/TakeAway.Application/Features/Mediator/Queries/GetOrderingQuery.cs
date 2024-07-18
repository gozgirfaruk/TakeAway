using MediatR;
using TakeAway.Application.Features.Mediator.Results;

namespace TakeAway.Application.Features.Mediator.Queries
{
    public class GetOrderingQuery : IRequest<List<GetOrderingQueryResult>>
    {
    }
}
