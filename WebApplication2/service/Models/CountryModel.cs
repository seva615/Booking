using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Services
{
   public class CountryModel
    {
        public Guid Id { get; set; }

        public string CountryName { get; set; }

        public IEnumerable<CityModel> Cities { get; set; }
    }
}
