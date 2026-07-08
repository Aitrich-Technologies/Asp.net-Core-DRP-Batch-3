<<<<<<<< HEAD:.NetCore/Razor/Sdudents/Arya/Razor/Exercise3/Exercise3/Repository/DestinationRepository.cs
﻿using Exercise3.Interface;
using Exercise3.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercise3.Repository
========
﻿using Microsoft.EntityFrameworkCore;
using TourManagement.Interface;
using TourManagement.Model;

namespace TourManagement.Repository
>>>>>>>> 72d82c91693b9e35788e1e94f879a16858273e20:.NetCore/Blazor/Workshop/Workshop3/TourManagement/TourManagement/Repository/DestinationRepository.cs
{
    public class DestinationRepository : IDestinationRepository
    {
        private readonly AppDbContext _context;
        public DestinationRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Destination destination)
        {
           _context.Destinations.Add(destination);
            await _context.SaveChangesAsync();
            //throw new NotImplementedException();
        }

        public async Task<List<Destination>> GetAll()
        {
            return await _context.Destinations.ToListAsync();
            //throw new NotImplementedException();
        }
<<<<<<<< HEAD:.NetCore/Razor/Sdudents/Arya/Razor/Exercise3/Exercise3/Repository/DestinationRepository.cs

        public async Task<Destination?> GetById(int id)
        {
            return await _context.Destinations.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Add(Destination destination)
========
        public async Task<Destination> GetByIdAsync(int id)
>>>>>>>> 72d82c91693b9e35788e1e94f879a16858273e20:.NetCore/Blazor/Workshop/Workshop3/TourManagement/TourManagement/Repository/DestinationRepository.cs
        {
            return await _context.Destinations.FindAsync(id);
        }
<<<<<<<< HEAD:.NetCore/Razor/Sdudents/Arya/Razor/Exercise3/Exercise3/Repository/DestinationRepository.cs

        public void Update(Destination destination)
========
        public async Task UpdateAsync(Destination destination)
>>>>>>>> 72d82c91693b9e35788e1e94f879a16858273e20:.NetCore/Blazor/Workshop/Workshop3/TourManagement/TourManagement/Repository/DestinationRepository.cs
        {
            var existing = await _context.Destinations.FindAsync(destination.Id);

            if (existing != null)
            {
                existing.Name = destination.Name;
                existing.Description = destination.Description;
                existing.ImageUrl = destination.ImageUrl;

                await _context.SaveChangesAsync();
            }
        }

        public void Delete(Destination destination)
        {
<<<<<<<< HEAD:.NetCore/Razor/Sdudents/Arya/Razor/Exercise3/Exercise3/Repository/DestinationRepository.cs
            _context.Destinations.Remove(destination);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
========
            var destination = await _context.Destinations.FindAsync(id);

            if (destination != null)
            {
                _context.Destinations.Remove(destination);
                await _context.SaveChangesAsync();
            }
        }

>>>>>>>> 72d82c91693b9e35788e1e94f879a16858273e20:.NetCore/Blazor/Workshop/Workshop3/TourManagement/TourManagement/Repository/DestinationRepository.cs
    }
}