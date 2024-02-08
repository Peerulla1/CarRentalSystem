using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Exceptions
{
    public class CarNotFoundException : ApplicationException
    {
        CarNotFoundException() { }

         CarNotFoundException(string message) : base(message) { }
      
            
    }

}