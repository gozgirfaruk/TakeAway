using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAway.Application.Features.Mediator.Results;

namespace TakeAway.Application.Features.Mediator.Queries
{
    public class GetOrderingByIdQuery : IRequest<GetOrderingByIdQueryResult>
    {
        public int OrderingID { get; set; }

        public GetOrderingByIdQuery(int orderingID)
        {
            OrderingID = orderingID;
        }
    }
}
