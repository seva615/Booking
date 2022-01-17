﻿using System;
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
            CreateMap<RoomViewModel, RoomModel>();
            CreateMap<RoomModel, RoomViewModel>();
            CreateMap<RoomModel, RoomEntity>();
            CreateMap<RoomEntity, RoomModel>();
            CreateMap<AdvantageViewModel, AdvantageModel>();
            CreateMap<AdvantageModel, AdvantageViewModel>();
            CreateMap<AdvantageModel, AdvantageEntity>();
            CreateMap<AdvantageEntity, AdvantageModel>();
            CreateMap<CreateContryViewModel, ContryModel>();
            CreateMap<ContryModel, CreateContryViewModel>();
            CreateMap<CreateCityViewModel, CityModel>();
            CreateMap<CityModel, CreateCityViewModel>();
            CreateMap<CreateHotelViewModel, HotelModel>();
            CreateMap<HotelModel, CreateHotelViewModel>();
            CreateMap<CreateRoomViewModel, RoomModel>();
            CreateMap<RoomModel, CreateRoomViewModel>();
            CreateMap<CreateAdvantageViewModel, AdvantageModel>();
            CreateMap<AdvantageModel, CreateAdvantageViewModel>();
        }         
    }
}
