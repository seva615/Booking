using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Booking.Services;

namespace Booking.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomController(IRoomService roomService, IMapper mapper)
        {
            _mapper = mapper;
            _roomService = roomService;
        }

        [HttpGet]
        [Route("getRooms")]
        public IEnumerable<RoomViewModel> GetRooms()
        {
            var RoomModels = _roomService.GetRooms();
            var RoomViewModels = _mapper.Map<IEnumerable<RoomViewModel>>(RoomModels);
            return RoomViewModels;
        }

        [HttpGet]
        [Route("getRoom")]
        public RoomViewModel GetRoom(Guid id)
        {
            var RoomModel = _roomService.GetRoom(id);
            var RoomViewModel = _mapper.Map<RoomModel, RoomViewModel>(RoomModel);
            return RoomViewModel;
        }

        [HttpPost]
        [Route("addRoom")]
        public void AddRoom(CreateRoomViewModel room)
        {
            var RoomModel = _mapper.Map<CreateRoomViewModel, RoomModel>(room);
            _roomService.AddRoom(RoomModel);
        }

        [HttpPut]
        [Route("editRoom")]
        public void EditRoom(RoomViewModel room)
        {
            var RoomModel = _mapper.Map<RoomViewModel, RoomModel>(room);
            _roomService.EditRoom(RoomModel);
        }

        [HttpDelete]
        [Route("deleteRoom")]
        public void DeleteRoom(Guid id)
        {
            _roomService.DeleteRoom(id);
        }
    }
}
