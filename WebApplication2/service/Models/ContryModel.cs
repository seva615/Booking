using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Services
{
   public class ContryModel
    {
        public Guid Id { get; set; }
        public string ContryName { get; set; }
        public IEnumerable<CityModel> Cities { get; set; }
    }
}
