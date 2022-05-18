using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.API
{
    public class CreateRoomViewModel
    {
        public Guid HotelId { get; set; }

        public string RoomType { get; set; }

        public int RoomNumber { get; set; }

        public int Price { get; set; }
        
        public int NumberOfPerson { get; set; }

        public int RoomSpace { get; set; }

    }
}
