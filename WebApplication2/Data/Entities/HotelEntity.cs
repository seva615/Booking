using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Booking.Data.DataInterfaces;


namespace Booking.Data
{
    public class HotelEntity : IEntity
    {
        public Guid Id { get; set; }

        public string HotelName { get; set; }

        public string Description { get; set; }

        public string Adress { get; set; }

        public Guid CityId { get; set; }

        public CityEntity City { get; set; }
        public IEnumerable<RoomEntity> Rooms { get; set; }       
    }
}
