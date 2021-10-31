using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data
{        
    public class ContryEntity
    {
        public Guid Id { get; set; }
        public string ContryName { get; set; }
        public IEnumerable<CityEntity> Cities { get; set; }
    }
}
