using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data
{
    public class CityEntity
    {
        public Guid Id { get; set; }

        public string CityName { get; set; }

        public Guid CountryId { get; set; }

        public CountryEntity Country { get; set; }

        public IEnumerable<HotelEntity> Hotels { get; set; }
    }
}
