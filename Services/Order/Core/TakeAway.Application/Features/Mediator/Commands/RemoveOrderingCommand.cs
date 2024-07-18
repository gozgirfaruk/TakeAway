﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAway.Application.Features.Mediator.Commands
{
    public class RemoveOrderingCommand : IRequest
    {
        public int OrderingID { get; set; }

        public RemoveOrderingCommand(int orderingID)
        {
            OrderingID = orderingID;
        }
    }
}