using AutoMapper;
using Domain.Enums;
using Domain.Models;
using Domain.Services.Destinations.DTO;
using Domain.Services.User.DTO;
using Microsoft.AspNetCore.Identity.Data;
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


            //CreateMap<AddUserDto, AuthUser>().ReverseMap();

            //CreateMap<AuthUser, UserResponseDto>().ReverseMap();

        }
    }
    
}
