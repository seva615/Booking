using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Data
{
    public interface IHotelRepository
    {
        public void DeleteHotelEntity(Guid id);
        public void AddHotelEntity(HotelEntity hotel);
        public void EditHotelEntity(HotelEntity hotel);
        public HotelEntity GetHotelEntity(Guid id);
        public IEnumerable<HotelEntity> GetHotelEntities();
    }
}
