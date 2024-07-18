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
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAddressCommand command)
        {
            var values = await _repository.GetByIdAsync(command.AddressID);
        values.Name = command.Name;
            values.Surname = command.Surname;
            values.Detail = command.Detail;
            values.City = command.City;
            values.District = command.District;
            values.Email = command.Email;
            values.UserID = command.UserID;
            values.UserName = command.UserName;
            values.Name=command.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
