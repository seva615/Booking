using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API
{
    public class CreateHotelViewModel
    {
        public string HotelName { get; set; }

        public string Adress { get; set; }

        public string Description { get; set; }

        public Guid CityId { get; set; }
    }
}
