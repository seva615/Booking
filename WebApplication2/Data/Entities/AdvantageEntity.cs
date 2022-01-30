using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data.DataInterfaces;
using Booking.Data.Entities;

namespace Booking.Data
{
    public class AdvantageEntity : IEntity
    {
        public Guid Id { get; set; }

        public string AdvantageName { get; set; }

        public string AdvantageType { get; set; }        
        
    }
}
