using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data
{
    public class CityEntity
    {
        public Guid Id { get; set; }
        public string CityName { get; set; }
        public Guid ContryId { get; set; }
        public IEnumerable<HotelEntity> Hotels { get; set; }
    }
}
