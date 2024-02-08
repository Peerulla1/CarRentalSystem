﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Exceptions
{
    public class CustomerNotFoundException: ApplicationException
    {
        CustomerNotFoundException() { }
        CustomerNotFoundException(string message) : base(message) { }
    }
}
