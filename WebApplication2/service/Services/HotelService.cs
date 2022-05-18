using System;
using System.Collections.Generic;
using System.Text;
using Booking.Data;
using AutoMapper;
using System.Threading.Tasks;

namespace Booking.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public HotelService(IHotelRepository hotelRepository, ICityRepository cityRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _cityRepository = cityRepository;
            _mapper = mapper;
        }
        public async Task DeleteHotel(Guid id)
        {
            await _hotelRepository.Delete(id);  
        }

        public async Task AddHotel(HotelModel hotel)
        {
            if (_cityRepository.GetById(hotel.CityId) != null)
            {
                var HotelEntity = _mapper.Map<HotelModel, HotelEntity>(hotel);
                await _hotelRepository.Add(HotelEntity);
            }
            else
            {
                throw new NotFoundException("No city found with entered id");
            }
        }

        public async Task<HotelModel> GetHotel(Guid id)
        {
            var HotelEntity = await _hotelRepository.GetById(id);
            var HotelModel = _mapper.Map<HotelEntity, HotelModel>(HotelEntity);
            return HotelModel;
        }

        public async Task EditHotel(HotelModel hotel)
        {
            var HotelEntity = _mapper.Map<HotelModel, HotelEntity>(hotel);
            await _hotelRepository.Edit(HotelEntity);            
        }

        public async Task<IEnumerable<HotelModel>> GetHotels()
        {           
            var HotelEntities = await _hotelRepository.GetAll();
            var HotelModels = _mapper.Map<IEnumerable<HotelModel>>(HotelEntities);
            return HotelModels;
        }
    }
}
