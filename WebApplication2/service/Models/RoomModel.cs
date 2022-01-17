using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Services
{
    public class RoomModel
    {        
        public Guid Id { get; set; }

        public Guid HotelId { get; set; }

        public string RoomType { get; set; }

        public int RoomNumber { get; set; }

        public int Price { get; set; }

        public int RoomSpace { get; set; }

        public IEnumerable<AdvantageModel> AdvantageId { get; set; }

        public IEnumerable<AdvantageModel> Advantages { get; set; }
    }
}
