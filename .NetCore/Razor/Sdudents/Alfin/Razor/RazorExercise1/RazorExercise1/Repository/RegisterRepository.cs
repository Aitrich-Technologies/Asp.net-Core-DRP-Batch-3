using AutoMapper;
using RazorExercise1.Dto;
using RazorExercise1.Interface;
using RazorExercise1.Model;
using Microsoft.EntityFrameworkCore;

namespace RazorExercise1.Repository
{
    public class RegisterRepository: IRegisterRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public RegisterRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddUserAsync(RegisterDto registerDto)
        {
            var register = _mapper.Map<Register>(registerDto);
            _context.Registers.Add(register);
            await _context.SaveChangesAsync();
        }

        public async Task<Register> GetByUsernameAndPasswordAsync(string Username, string Password)
        {
            return await _context.Registers
     .FirstOrDefaultAsync(u => u.Username == Username && u.Password == Password);
        }
    }
}
