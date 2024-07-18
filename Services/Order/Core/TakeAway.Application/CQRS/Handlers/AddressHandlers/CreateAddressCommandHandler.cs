using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeAway.Application.CQRS.Commands.AddressCommands;
using TakeAway.Application.Interfaces;
using TakeAway.Domain.Entities;

namespace TakeAway.Application.CQRS.Handlers.AddressHandlers
{
    public class CreateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public CreateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAddressCommand command)
        {
            await _repository.CreateAsync(new Address
            {
                City = command.City,
                Detail = command.Detail,
                District = command.District,
                Email = command.Email,
                Name = command.Name,
                UserID = command.UserID,
                UserName = command.UserName,
                Surname = command.Surname,
            });
        }
    }
}
