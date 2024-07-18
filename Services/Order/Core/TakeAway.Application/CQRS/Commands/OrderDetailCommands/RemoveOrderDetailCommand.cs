using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAway.Application.CQRS.Commands.OrderDetailCommands
{
    public class RemoveOrderDetailCommand
    {
        public int OrderDetailID { get; set; }

        public RemoveOrderDetailCommand(int orderDetailID)
        {
            OrderDetailID = orderDetailID;
        }
    }
}
