using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAway.Application.CQRS.Commands.AddressCommands
{
    public class UpdateAddressCommand
    {
        public int AddressID { get; set; }
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Detail { get; set; }
    }
}
