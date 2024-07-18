using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAway.Application.CQRS.Commands.OrderDetailCommands
{
    public class CreateOrderDetailCommand
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderingID { get; set; }
    }
}
