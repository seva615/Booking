using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.Services;
using Booking.Data;
using AutoMapper;

namespace Booking.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HotelViewModel, HotelModel>();
            CreateMap<HotelModel, HotelViewModel>();
            CreateMap<HotelModel, HotelEntity>();
            CreateMap<HotelEntity, HotelModel>();
            CreateMap<CityViewModel, CityModel>();
            CreateMap<CityModel, CityViewModel>();
            CreateMap<CityModel, CityEntity>();
            CreateMap<CityEntity, CityModel>();
            CreateMap<ContryViewModel, ContryModel>();
            CreateMap<ContryModel, ContryViewModel>();
            CreateMap<ContryModel, ContryEntity>();
            CreateMap<ContryEntity, ContryModel>();


        }
         
    }
}
