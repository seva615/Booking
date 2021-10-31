using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API
{
    public class ContryViewModel
    {
        public Guid Id { get; set; }
        public string ContryName { get; set; }
        public IEnumerable<CityViewModel> Cities { get; set; }
    }
}
