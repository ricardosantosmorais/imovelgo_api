using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;
using ImovelGo.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ImovelGo.Infrastructure.EntityFrameworkDataAccess
{
    public class CityRepository : ICityRepository
    {
        private readonly ImovelGoContext _context;
        private readonly IMapper _mapping;

        public CityRepository(ImovelGoContext context, IMapper mapping)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
            _mapping = mapping;
        }

        public async Task<CityDTO> Add(CityDTO city)
        {
            City entity = new City()
            {
                Name = city.Name,
                StateId = city.StateId,
                DateAdd = DateTime.Now,
                Enabled = true
            };

            await _context.City.AddAsync(entity);
            await _context.SaveChangesAsync();
            return _mapping.Map<CityDTO>(entity);
        }

        public async Task Delete(int id)
        {
            City entity = new City()
            {
                Id = id,
                Enabled = false
            };

            await _context.City.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<CityDTO> Get(int id)
        {
            City entity = await _context
                .City
                .FindAsync(id);

            return _mapping.Map<CityDTO>(entity);
        }

        public async Task<List<CityDTO>> GetAll()
        {
            List<City> entity = await _context
                .City
                .ToListAsync();

            return _mapping.Map<List<CityDTO>>(entity);
        }

        public async Task Update(CityDTO city)
        {
            City entity = new City()
            {
                Id = city.Id,
                Name = city.Name,
                StateId = city.StateId,
                Enabled = city.Enabled
            };

            await _context.City.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<CityDTO>> GetByCompany(int id)
        {
            throw new NotImplementedException();
        }
    }
}
