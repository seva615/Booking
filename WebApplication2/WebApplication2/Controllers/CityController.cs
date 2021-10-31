using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Booking.Services;
using AutoMapper;

namespace Booking.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;

        public CityController(ICityService cityService, IMapper mapper)
        {
            _mapper = mapper;
            _cityService = cityService;
        }

        [HttpGet]
        [Route("getCities")]
        public IEnumerable<CityViewModel> GetCities()
        {
            var CityModels = _cityService.GetCities();
            var CityViewModels = _mapper.Map<IEnumerable<CityViewModel>>(CityModels);
            return CityViewModels;
        }

        [HttpGet]
        [Route("getCity")]
        public CityViewModel GetCity(Guid id)
        {
            var CityModel = _cityService.GetCity(id);
            var CityViewModel = _mapper.Map<CityModel, CityViewModel>(CityModel);
            return CityViewModel;
        }

        [HttpPost]
        [Route("addCity")]
        public void AddCity(CityViewModel city)
        {
            var CityModel = _mapper.Map<CityViewModel, CityModel>(city);
            _cityService.AddCity(CityModel);
        }
        [HttpPut]
        [Route("editCity")]
        public void EditCity(CityViewModel city)
        {
            var CityModel = _mapper.Map<CityViewModel, CityModel>(city);
            _cityService.EditCity(CityModel);
        }

        [HttpDelete]
        [Route("deleteCity")]
        public void DeleteCity(Guid id)
        {
            _cityService.DeleteCity(id);
        }
    }
}
