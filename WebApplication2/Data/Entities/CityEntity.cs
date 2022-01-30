using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data.DataInterfaces;

namespace Booking.Data
{
    public class CityEntity : IEntity
    {
        public Guid Id { get; set; }

        public string CityName { get; set; }

        public Guid CountryId { get; set; }

        public CountryEntity Country { get; set; }

        public IEnumerable<HotelEntity> Hotels { get; set; }
    }
}
