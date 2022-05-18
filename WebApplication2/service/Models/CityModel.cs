using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Services
{
    public class CityModel
    {
        public Guid Id { get; set; }

        public string CityName { get; set; }

        public Guid CountryId { get; set; }

        public CountryModel Country { get; set; }

        public IEnumerable<HotelModel> Hotels { get; set; }
    }
}
