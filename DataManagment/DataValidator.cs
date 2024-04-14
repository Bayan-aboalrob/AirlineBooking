using System;
using System.Collections;
using System.Collections.Generic;

namespace AirlineBooking.DataManagment
{
    public interface IDataValidator<T>
    {
        public abstract bool Validate(T data, out IEnumerable<string> validationErrors);
    }
}
