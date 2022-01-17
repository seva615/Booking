using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Services
{
    public interface IHotelService
    {
        public void DeleteHotel(Guid id);

        public void AddHotel(HotelModel hotel);

        public HotelModel GetHotel(Guid id);

        public void EditHotel(HotelModel hotel);

        public IEnumerable<HotelModel> GetHotels();
    }
}
