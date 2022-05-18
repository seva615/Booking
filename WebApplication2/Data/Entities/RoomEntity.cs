using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data.DataInterfaces;

namespace Booking.Data
{
    public class RoomEntity : IEntity
    {
        public Guid Id { get; set; }

        public Guid HotelId { get; set; }

        public HotelEntity Hotel { get; set; }

        public string RoomType { get; set; }

        public int RoomNumber { get; set; }

        public int Price { get; set; }
        
        public int NumberOfPerson { get; set; }

        public int RoomSpace { get; set; }        
    }
}
