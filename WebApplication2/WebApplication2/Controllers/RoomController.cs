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
        public async Task<IEnumerable<RoomViewModel>> GetRooms()
        {
            var RoomModels = await _roomService.GetRooms();
            var RoomViewModels = _mapper.Map<IEnumerable<RoomViewModel>>(RoomModels);
            return RoomViewModels;
        }

        [HttpGet]
        [Route("getRoom")]
        public async Task<RoomViewModel> GetRoom(Guid id)
        {
            var RoomModel = await _roomService.GetRoom(id);
            var RoomViewModel = _mapper.Map<RoomModel, RoomViewModel>(RoomModel);
            return RoomViewModel;
        }

        [HttpPost]
        [Route("addRoom")]
        public async Task AddRoom(CreateRoomViewModel room)
        {
            var RoomModel = _mapper.Map<CreateRoomViewModel, RoomModel>(room);
            await _roomService.AddRoom(RoomModel);
        }

        [HttpPut]
        [Route("editRoom")]
        public async Task EditRoom(RoomViewModel room)
        {
            var RoomModel = _mapper.Map<RoomViewModel, RoomModel>(room);
            await _roomService.EditRoom(RoomModel);
        }

        [HttpDelete]
        [Route("deleteRoom")]
        public async Task DeleteRoom(Guid id)
        {
            await _roomService.DeleteRoom(id);
        }
    }
}
