using AutoMapper;
using Domain.Enum;
using Domain.Models;
using Domain.Services.DTO;
using Workshop.API.User.RequestObjects;

namespace Workshop.API.User.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Registration
            CreateMap<AddUserRequest, AddUserDto>().ReverseMap();
            CreateMap<AddUserDto, AuthUser>().ReverseMap();

            // Login
            CreateMap<LoginRequest, LoginDto>().ReverseMap();

            // Forgot Password
            CreateMap<ForgotPasswordRequest, ForgotUserDto>().ReverseMap();

            // Verify Code
            CreateMap<VerifyCodeRequest, VerifyCodeDto>().ReverseMap();

            // Reset Password
            CreateMap<ResetPasswordRequest, ResetPasswordDto>().ReverseMap();

            // Patch User
            CreateMap<PatchUserRequest, PatchUserDto>().ReverseMap();

            // User Response
            CreateMap<AuthUser, UserResponseDto>()
                .ForMember(dest => dest.Role,
                    opt => opt.MapFrom(src => src.Role.ToString()));

            CreateMap<UserResponseDto, AuthUser>()
                .ForMember(dest => dest.Role,
                    opt => opt.MapFrom(src => Enum.Parse<UserRoles>(src.Role!, true)));

            CreateMap<UserResponseDto, UserResponse>().ReverseMap();
        }
    }
}