using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data.DataInterfaces;

namespace Booking.Data
{        
    public class CountryEntity : IEntity
    {
        public Guid Id { get; set; }

        public string CountryName { get; set; }

        public IEnumerable<CityEntity> Cities { get; set; }
    }
}
