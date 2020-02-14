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
    public class AddressRepository : IAddressRepository
    {
        private readonly ImovelGoContext _context;
        private readonly IMapper _mapping;

        public AddressRepository(ImovelGoContext context, IMapper mapping)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
            _mapping = mapping;
        }

        public async Task<AddressDTO> Add(AddressDTO address)
        {
            Address entity = new Address()
            {
                CityId = address.CityId,
                AddressId = Guid.NewGuid(),
                Complement = address.Complement,
                CountryId = address.CountryId,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Deleted = false,
                Enabled = true,
                Latitude = address.Latitude,
                Longitude = address.Longitude,
                Name = address.Name,
                NeighborhoodId = address.NeighborhoodId,
                Number = address.Number,
                PostalCode = address.PostalCode,
                StateId = address.StateId,
                Street = address.Street
            };

            await _context.Address.AddAsync(entity);
            await _context.SaveChangesAsync();
            return _mapping.Map<AddressDTO>(entity);
        }

        public async Task<AddressDTO> Get(int id)
        {
            Address entity = await _context
                .Address
                .FindAsync(id);

            return await GetReferences(_mapping.Map<AddressDTO>(entity));
        }

        public async Task<AddressDTO> Get(Guid guid)
        {
            Address entity = await _context
                .Address
                .Where(x => x.AddressId == guid).FirstOrDefaultAsync();

            return await GetReferences(_mapping.Map<AddressDTO>(entity));
        }

        public async Task<List<AddressDTO>> GetByAccount(int id)
        {
            var addresses = await (from a in _context.Address
                                   join aa in _context.AccountAddress on a.Id equals aa.AddressId
                                   where aa.AccountId == id
                                   select a).ToListAsync();

            var ListAddress = _mapping.Map<List<AddressDTO>>(addresses);

            foreach (var item in ListAddress)
            {
                await GetReferences(item);
            }

            return ListAddress;
        }

        public async Task<List<AddressDTO>> GetByCompany(int id)
        {
            var addresses = await (from a in _context.Address
                                   join aa in _context.CompanyAddress on a.Id equals aa.AddressId
                                   where aa.CompanyId == id
                                   select a).ToListAsync();

            var ListAddress = _mapping.Map<List<AddressDTO>>(addresses);

            foreach (var item in ListAddress)
            {
                await GetReferences(item);
            }

            return ListAddress;
        }

        public async Task Delete(int id)
        {
            Address entity = new Address()
            {
                Id = id,
                Deleted = true,
                Enabled = false
            };

            await _context.Address.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(AddressDTO address)
        {
            Address entity = new Address()
            {
                Id = address.Id,
                CityId = address.CityId,
                AddressId = address.AddressId,
                Complement = address.Complement,
                CountryId = address.CountryId,
                DateUpdated = DateTime.Now,
                Latitude = address.Latitude,
                Longitude = address.Longitude,
                Name = address.Name,
                NeighborhoodId = address.NeighborhoodId,
                Number = address.Number,
                PostalCode = address.PostalCode,
                StateId = address.StateId,
                Street = address.Street
            };

            await _context.Address.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        private async Task<AddressDTO> GetReferences(AddressDTO address)
        {
            address.Country = _mapping.Map<CountryDTO>(await _context
                .Country
                .FindAsync(address.CountryId));

            address.State = _mapping.Map<StateDTO>(await _context
                .State
                .FindAsync(address.StateId));

            address.Neighborhood = _mapping.Map<NeighborhoodDTO>(await _context
                .Neighborhood
                .FindAsync(address.NeighborhoodId));

            if(address.Neighborhood != null && address.Neighborhood.ZoneId.HasValue)
            {
                address.Neighborhood.Zone = _mapping.Map<ZoneDTO>(await _context
                .Zone
                .FindAsync(address.Neighborhood.ZoneId));
            }

            address.City = _mapping.Map<CityDTO>(await _context
                .City
                .FindAsync(address.CityId));

            return address;
        }
    }
}
