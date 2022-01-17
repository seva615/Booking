using System;
using System.Collections.Generic;
using System.Text;
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
        public void DeleteRoom(Guid id)
        {
            _roomRepository.DeleteRoomEntity(id);
        }

        public void AddRoom(RoomModel room)
        {
            if (_hotelRepository.GetHotelEntity(room.HotelId) != null)
            {
                var RoomEntity = _mapper.Map<RoomModel, RoomEntity>(room);
                _roomRepository.AddRoomEntity(RoomEntity);
            }
            else
            {
                throw new NotFoundException("No hotel found with entered id");
            }
            
        }

        public RoomModel GetRoom(Guid id)
        {
            var RoomEntity = _roomRepository.GetRoomEntity(id);
            var RoomModel = _mapper.Map<RoomEntity, RoomModel>(RoomEntity);
            return RoomModel;
        }

        public void EditRoom(RoomModel room)
        {
            var RoomEntity = _mapper.Map<RoomModel, RoomEntity>(room);
            _roomRepository.EditRoomEntity(RoomEntity);
        }

        public IEnumerable<RoomModel> GetRooms()
        {
            var RoomEntities = _roomRepository.GetRoomEntities();
            var RoomModels = _mapper.Map<IEnumerable<RoomModel>>(RoomEntities);
            return RoomModels;
        }
    }
}
