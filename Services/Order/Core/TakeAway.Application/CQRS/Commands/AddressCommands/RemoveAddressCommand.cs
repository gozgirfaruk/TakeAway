﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAway.Application.CQRS.Commands.AddressCommands
{
    public class RemoveAddressCommand
    {
        public int AddressID { get; set; }

        public RemoveAddressCommand(int addressID)
        {
            AddressID = addressID;
        }
    }
}
