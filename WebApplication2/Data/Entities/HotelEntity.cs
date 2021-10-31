using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace Booking.Data
{
    public class HotelEntity
    {
        public Guid Id { get; set; }
        public string HotelName { get; set; }
        public string Advantage { get; set; }
        public string Adress { get; set; }
        public Guid CityId { get; set; }
        public CityEntity city { get; set; }
       
    }
}
