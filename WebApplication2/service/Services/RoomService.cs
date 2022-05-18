using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Booking.Data;

namespace Booking.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;

        public RoomService(IRoomRepository roomRepository, IHotelRepository hotelRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _roomRepository = roomRepository;
            _mapper = mapper;
        }
        public async Task DeleteRoom(Guid id)
        {
            await _roomRepository.Delete(id);
        }

        public async Task AddRoom(RoomModel room)
        {
            if ( await _hotelRepository.GetById(room.HotelId) != null)
            {
                var RoomEntity = _mapper.Map<RoomModel, RoomEntity>(room);
                await _roomRepository.Add(RoomEntity);
            }
            else
            {
                throw new NotFoundException("No hotel found with entered id");
            }
            
        }

        public async Task<RoomModel> GetRoom(Guid id)
        {
            var RoomEntity = await _roomRepository.GetById(id);
            var RoomModel = _mapper.Map<RoomEntity, RoomModel>(RoomEntity);
            return RoomModel;
        }

        public async Task EditRoom(RoomModel room)
        {
            var RoomEntity = _mapper.Map<RoomModel, RoomEntity>(room);
            await _roomRepository.Edit(RoomEntity);
        }

        public async Task<IEnumerable<RoomModel>> GetRooms()
        {
            var RoomEntities = await _roomRepository.GetAll();
            var RoomModels = _mapper.Map<IEnumerable<RoomModel>>(RoomEntities);
            return RoomModels;
        }
    }
}
