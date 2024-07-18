using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAway.Application.CQRS.Queries.AddressQueries;
using TakeAway.Application.CQRS.Results.AddressResults;
using TakeAway.Application.Interfaces;
using TakeAway.Domain.Entities;

namespace TakeAway.Application.CQRS.Handlers.AddressHandlers
{
    public class GetAddressByIdQueryHandler
    {
        private readonly IRepository<Address> _repository;

        public GetAddressByIdQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task<GetAddressByIdQueryResult> Handle(GetAddresByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.AddressID);
            return new GetAddressByIdQueryResult
            {
                AddressID = values.AddressID,
                City = values.City,
                Detail = values.Detail,
                District = values.District,
                Email = values.Email,
                Name = values.Name,
                Surname = values.Surname,
                UserID = values.UserID,
                UserName = values.UserName
            };
        }
    }
}
