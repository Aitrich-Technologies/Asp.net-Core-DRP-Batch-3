using AutoMapper;
using MVC_MechineText11.Dto;
using MVC_MechineText11.Enum;
using MVC_MechineText11.Models;
using System.Runtime.InteropServices;

namespace MVC_MechineText11.Helper
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<RegisterDto, Agency>();
            CreateMap<Agency, UserRole>().ReverseMap();
            CreateMap<TourPackage,TourPackageDto>().ReverseMap();
        }
    }
}
