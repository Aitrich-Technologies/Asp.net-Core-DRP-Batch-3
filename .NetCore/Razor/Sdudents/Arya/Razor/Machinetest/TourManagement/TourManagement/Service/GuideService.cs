using TourManagement.Dto;
using TourManagement.Interface;
using TourManagement.Models;

namespace TourManagement.Services
{
    public class GuideService : IGuideService
    {
        private readonly IGuideRepository _guideRepository;

        public GuideService(IGuideRepository guideRepository)
        {
            _guideRepository = guideRepository;
        }

        public async Task<List<Guide>> GetAllGuidesAsync()
        {
            return await _guideRepository.GetAllAsync();
        }

        public async Task<Guide?> GetGuideByIdAsync(int id)
        {
            return await _guideRepository.GetByIdAsync(id);
        }

        public async Task AddGuideAsync(GuideDto dto)
        {
            var guide = new Guide
            {
                GuideName = dto.GuideName,
                PhoneNumber = dto.PhoneNumber,
                Experience = dto.Experience,
                Langauage = dto.Langauage
            };

            await _guideRepository.AddAsync(guide);
            await _guideRepository.SaveAsync();
        }

        public async Task UpdateGuideAsync(GuideDto dto)
        {
            var guide = await _guideRepository.GetByIdAsync(dto.Id);

            if (guide != null)
            {
                guide.GuideName = dto.GuideName;
                guide.PhoneNumber = dto.PhoneNumber;
                guide.Experience = dto.Experience;
                guide.Langauage = dto.Langauage;

                await _guideRepository.UpdateAsync(guide);
                await _guideRepository.SaveAsync();
            }
        }

        public async Task DeleteGuideAsync(int id)
        {
            var guide = await _guideRepository.GetByIdAsync(id);

            if (guide != null)
            {
                await _guideRepository.DeleteAsync(guide);
                await _guideRepository.SaveAsync();
            }
        }
    }
}