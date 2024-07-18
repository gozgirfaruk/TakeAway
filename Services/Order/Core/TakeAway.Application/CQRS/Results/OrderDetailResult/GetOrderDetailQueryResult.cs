using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAway.Domain.Entities;

namespace TakeAway.Application.CQRS.Results.OrderDetailResult
{
    public class GetOrderDetailQueryResult
    {
        public int OrderDetailID { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderingID { get; set; }
    }
}
