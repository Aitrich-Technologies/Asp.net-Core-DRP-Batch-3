using AutoMapper;
using Domain.Models;
using Domain.Services.Destinations.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Destination, DestinationDto>().ReverseMap();
        CreateMap<Destination, DestinationResponseDto>().ReverseMap();

    }
}
}
