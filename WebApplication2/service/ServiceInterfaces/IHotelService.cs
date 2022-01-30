using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Services
{
    public interface IHotelService
    {
        public Task DeleteHotel(Guid id);

        public Task AddHotel(HotelModel hotel);

        public Task<HotelModel> GetHotel(Guid id);

        public Task EditHotel(HotelModel hotel);

        public Task<IEnumerable<HotelModel>> GetHotels();
    }
}
