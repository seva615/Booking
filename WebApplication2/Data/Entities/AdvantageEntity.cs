using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data
{
    public class AdvantageEntity
    {
        public Guid Id { get; set; }

        public string AdvantageName { get; set; }

        public string AdvantageType { get; set; }

        public Guid RoomId { get; set; }
    }
}
