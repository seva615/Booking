using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API
{
    public class CityViewModel
    {
        public Guid Id { get; set; }

        public string CityName { get; set; }

        public Guid CountryId { get; set; }

        public CountryViewModel Country { get; set; }

        public IEnumerable<HotelViewModel> Hotels { get; set; }

    }
}
