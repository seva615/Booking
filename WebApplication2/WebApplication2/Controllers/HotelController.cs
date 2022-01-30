using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Booking.Services;
using AutoMapper;
using System.Threading.Tasks;

namespace Booking.API
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class HotelController : Controller
    {
        private readonly IHotelService _hotelService;
        private readonly IMapper _mapper;
         
        public HotelController(IHotelService hotelService, IMapper mapper)
        {
            _mapper = mapper;
            _hotelService = hotelService;
        }

        [HttpGet]
        [Route("getHotels")]
        public async Task<IEnumerable<HotelViewModel>> GetHotels()
        {
            var HotelModels = await _hotelService.GetHotels();
            var HotelViewModels = _mapper.Map<IEnumerable<HotelViewModel>>(HotelModels);
           return HotelViewModels;
        }

        [HttpGet]
        [Route("getHotel")]
        public async Task<HotelViewModel> GetHotel(Guid id)
        {
            var HotelModel = await _hotelService.GetHotel(id);
            var HotelViewModel = _mapper.Map<HotelModel, HotelViewModel>(HotelModel);
            return HotelViewModel;
        }

        [HttpPost]
        [Route("addHotel")]
        public async Task AddHotel(CreateHotelViewModel hotel)
        {
            var HotelModel = _mapper.Map<CreateHotelViewModel, HotelModel>(hotel);
            await _hotelService.AddHotel(HotelModel);
        }

        [HttpPut]
        [Route("editHotel")]
        public async Task EditHotel(HotelViewModel hotel)
        {
            var HotelModel = _mapper.Map<HotelViewModel, HotelModel>(hotel);
            await _hotelService.EditHotel(HotelModel);
        }

        [HttpDelete]
        [Route("deleteHotel")]
        public void DeleteHotel(Guid id)
        {
            _hotelService.DeleteHotel(id);
        }
    }
}