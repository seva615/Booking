using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data
{        
    public class CountryEntity
    {
        public Guid Id { get; set; }

        public string CountryName { get; set; }

        public IEnumerable<CityEntity> Cities { get; set; }
    }
}
