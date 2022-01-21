using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API
{
    public class CreateCityViewModel
    {
        public string CityName { get; set; }

        public Guid CountryId { get; set; }
    }
}
