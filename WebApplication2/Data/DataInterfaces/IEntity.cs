using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data.DataInterfaces
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
