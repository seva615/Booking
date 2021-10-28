using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Booking.Services;

namespace Booking.API
{   
    [ApiController]
    public class HotelController : Controller
    {
        private readonly IHotelService _hotelService;
        
        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }
        public IEnumerable<HotelViewModel> GetHotels()
        {
           return db.Hotels;
        }

        public HotelViewModel GetHotel(Guid id)
        {
            var HotelModel = _hotelService.GetHotel(id);
            var HotelViewModel = 
            return
        }

        public void AddHotel(HotelViewModel hotel)
        {
            var HotelModel =
            _hotelService.AddHotel(HotelModel);
        }

        public void EditHotel(Guid id, HotelViewModel hotel)
        {
            var HotelModel =
            _hotelService.EditHotel(id, HotelModel);
         
        }

        public void DeleteHotel(Guid id)
        {
            _hotelService.DeleteHotel(id);
        }
    }
}