using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAway.Application.CQRS.Queries.AddressQueries
{
    public class GetAddresByIdQuery
    {
        public int AddressID { get; set; }

        public GetAddresByIdQuery(int addressID)
        {
            AddressID = addressID;
        }
    }
}
