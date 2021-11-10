using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Services
{
   public class HotelModel
    {
        public Guid Id { get; set; }
        public string HotelName { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public Guid CityId { get; set; }
        public CityModel city { get; set; }


    }
}
