using AutoMapper;
using ParkyAPI.Models;
using ParkyAPI.Models.DTO;
using ParkyAPI.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.NationalParkMapper
{
    public class NationalParkMappings : Profile
    {
        public NationalParkMappings()
        {
            CreateMap<NationalPark, NationalParkDTO>().ReverseMap();
            CreateMap<Trail, TrailDTO>().ReverseMap();
            CreateMap<Trail, TrailCreateDTO>().ReverseMap();
            CreateMap<Trail, TrailUpdateDTO>().ReverseMap();

        }
    }
}
