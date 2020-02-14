using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;
using ImovelGo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Dapper;

namespace ImovelGo.Infrastructure.EntityFrameworkDataAccess
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly ImovelGoContext _context;
        private readonly IMapper _mapping;
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public PropertyRepository(ImovelGoContext context,
            IMapper mapping,
            ISqlConnectionFactory sqlConnectionFactory)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
            _mapping = mapping;
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        public async Task<PropertyDTO> Add(PropertyDTO property)
        {
            Property entity = new Property()
            {
                PropertyTypeId = property.PropertyTypeId,
                BrokerId = property.BrokerId,
                CompanyId = property.CompanyId,
                StatusId = property.StatusId,
                AddressId = property.AddressId,
                Bedroom = property.Bedroom,
                SalePrice = property.SalePrice,
                RentPrice = property.RentPrice,
                GoalId = property.GoalId,
                Discount = property.Discount,
                TaxPrice = property.TaxPrice,
                CondominiumPrice = property.CondominiumPrice,
                Description = property.Description,
                Title = property.Title,
                Suite = property.Suite,
                BathRoom = property.BathRoom,
                Vacancies = property.Vacancies,
                VideoUrl = property.VideoUrl,
                UsefulAreaWidth = property.UsefulAreaWidth,
                UsefulAreaDepth = property.UsefulAreaDepth,
                TotalAreaWidth = property.TotalAreaWidth,
                TotalAreaDepth = property.TotalAreaDepth,
                PrivateAreaWidth = property.PrivateAreaWidth,
                PrivateAreaDepth = property.PrivateAreaDepth,
                IsNew = property.IsNew,
                Featured = property.Featured,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Enabled = true,
                Deleted = false,
                Floor = property.Floor,
                PetAccept = property.PetAccept,
                Furnished = property.Furnished,
                NearMetro = property.NearMetro
            };

            await _context.Property.AddAsync(entity);
            await _context.SaveChangesAsync();
            return _mapping.Map<PropertyDTO>(entity);
        }

        public async Task<PropertyDTO> Get(int id)
        {
            PropertyDTO entity = _mapping
                .Map<PropertyDTO>(await _context
                .Property
                .FindAsync(id));

            if (entity == null)
                return null;

            await GetReferences(entity);


            return entity;
        }

        public async Task<List<PropertyDTO>> GetByCompany(int id)
        {
            var properties = _mapping.Map<List<PropertyDTO>>(await (from a in _context.Property
                                                                    where a.CompanyId == id
                                                                    where a.Enabled
                                                                    select a).ToListAsync());

            if (properties.Any())
            {
                foreach (var item in properties)
                {
                    await GetReferences(item);
                }
            }

            return properties;
        }

        public async Task<List<PropertyDTO>> GetByCompanyAndFeatured(int id)
        {
            var properties = _mapping.Map<List<PropertyDTO>>(await (from a in _context.Property
                                                                    where a.CompanyId == id
                                                                    where a.Enabled
                                                                    where a.Featured
                                                                    select a).ToListAsync());

            if (properties.Any())
            {
                foreach (var item in properties)
                {
                    await GetReferences(item);
                }
            }

            return properties;
        }

        public async Task<List<PropertyDTO>> GetByCompanyAndLast(int id)
        {
            var properties = _mapping.Map<List<PropertyDTO>>(await (from a in _context.Property
                                                                    where a.CompanyId == id
                                                                    where a.Enabled
                                                                    where a.Featured
                                                                    select a).Take(6).ToListAsync());

            if (properties.Any())
            {
                foreach (var item in properties)
                {
                    await GetReferences(item);
                }
            }

            return properties;
        }

        public async Task<List<PropertyDTO>> GetPopularByCompany(int id)
        {
            var properties = _mapping.Map<List<PropertyDTO>>(await (from a in _context.Property
                                                                    where a.CompanyId == id
                                                                    where a.Enabled
                                                                    where a.Deleted == false
                                                                    select a).OrderByDescending(x => x.PageViews).Take(6).ToListAsync());

            if (properties.Any())
            {
                foreach (var item in properties)
                {
                    await GetReferences(item);
                }
            }

            return properties;
        }

        public async Task Update(PropertyDTO property)
        {
            Property entity = new Property()
            {
                Id = property.Id,
                PropertyTypeId = property.PropertyTypeId,
                BrokerId = property.BrokerId,
                CompanyId = property.CompanyId,
                StatusId = property.StatusId,
                AddressId = property.AddressId,
                Bedroom = property.Bedroom,
                SalePrice = property.SalePrice,
                RentPrice = property.RentPrice,
                GoalId = property.GoalId,
                Discount = property.Discount,
                TaxPrice = property.TaxPrice,
                CondominiumPrice = property.CondominiumPrice,
                Description = property.Description,
                Title = property.Title,
                Suite = property.Suite,
                BathRoom = property.BathRoom,
                Vacancies = property.Vacancies,
                VideoUrl = property.VideoUrl,
                UsefulAreaWidth = property.UsefulAreaWidth,
                UsefulAreaDepth = property.UsefulAreaDepth,
                TotalAreaWidth = property.TotalAreaWidth,
                TotalAreaDepth = property.TotalAreaDepth,
                PrivateAreaWidth = property.PrivateAreaWidth,
                PrivateAreaDepth = property.PrivateAreaDepth,
                IsNew = property.IsNew,
                Featured = property.Featured,
                DateUpdated = DateTime.Now,
                Enabled = true,
                Deleted = false,
                Floor = property.Floor,
                PetAccept = property.PetAccept,
                Furnished = property.Furnished,
                NearMetro = property.NearMetro
            };

            await _context.Property.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Property entity = await _context
                .Property
                .FindAsync(id);

            entity.Deleted = true;

            await _context.Property.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePageViews(int id)
        {
            Property entity = await _context
                .Property
                .FindAsync(id);

            entity.PageViews++;

            await _context.Property.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<PagedResultsDTO<PropertyDTO>> Search(FilterDTO filter)
        {
            var results = new PagedResultsDTO<PropertyDTO>();

            var connection = this._sqlConnectionFactory.GetOpenConnection();
            var query = @"
                        SELECT DISTINCT SQL_CALC_FOUND_ROWS 
                        * FROM Property p
                        inner join Address a ON p.AddressId = a.Id
                        inner join PropertyType t ON p.PropertyTypeId = t.Id
                        WHERE p.CompanyId = @CompanyId
                        AND p.GoalId = @GoalId
                        AND CASE WHEN @GoalId = 1
                            THEN (@MinValue IS NULL OR p.SalePrice >= @MinValue) AND (@MaxValue IS NULL OR p.SalePrice <= @MaxValue)
                        ELSE
                            (@MinValue IS NULL OR p.RentPrice >= @MinValue) AND (@MaxValue IS NULL OR p.RentPrice <= @MaxValue)
                        END
                        AND (@MinArea IS NULL OR (p.TotalAreaWidth * p.TotalAreaDepth) >= @MinArea)
                        AND (@MaxArea IS NULL OR (p.TotalAreaWidth * p.TotalAreaDepth) <= @MaxArea)
                        AND (@BathRoom IS NULL OR p.BathRoom = @BathRoom)
                        AND (@BedRoom IS NULL OR p.BedRoom = @BedRoom)
                        AND (@Type IS NULL OR p.PropertyTypeId = @Type)
                        AND (@Vacancy IS NULL OR p.Vacancies = @Vacancy)
                        AND (@NearMetro IS NULL OR p.NearMetro = @NearMetro)
                        AND (@NearBeach IS NULL OR p.NearBeach = @NearBeach)
                        AND (@AirCondition IS NULL OR p.AirCondition = @AirCondition)
                        AND (@Heating IS NULL OR p.Heating = @Heating)
                        AND (@PetAccept IS NULL OR p.PetAccept = @PetAccept)
                        AND (@Furnished IS NULL OR p.Furnished = @Furnished)
                        AND (@NeightborhoodId IS NULL OR a.NeighborhoodId = @NeightborhoodId)
                        AND (@CityId IS NULL OR a.CityId = @CityId)
                        AND (@StateId IS NULL OR a.StateId = @StateId)
                        AND (@ZoneId IS NULL OR a.ZoneId = @ZoneId)
                        AND (@CountryId IS NULL OR a.CountryId = @CountryId)
                        AND p.Enabled = true AND p.Deleted = false AND p.Published = true
                        ORDER BY p.DateAdd
                        LIMIT @Offset, @PageSize;

                        SELECT FOUND_ROWS();
                        ";
            var multi = await connection.QueryMultipleAsync(query,
                new {
                    CompanyId = filter.CompanyId,
                    Offset = filter.OffSet,
                    PageSize = filter.PageSize,
                    GoalId = filter.GoalId,
                    MinValue = filter.MinValue,
                    MaxValue = filter.MaxValue,
                    BathRoom = filter.BathRoom,
                    BedRoom = filter.BedRoom,
                    Type = filter.Type,
                    Vacancy = filter.Vacancy,
                    NearMetro = filter.NearMetro,
                    NearBeach = filter.NearBeach,
                    AirCondition = filter.AirCondition,
                    Heating = filter.Heating,
                    PetAccept = filter.PetAccept,
                    Furnished = filter.Furnished,
                    NeightborhoodId = filter.NeightborhoodId,
                    CityId = filter.CityId,
                    StateId = filter.StateId,
                    ZoneId = filter.ZoneId,
                    CountryId = filter.CountryId,
                    MinArea = filter.MinArea,
                    MaxArea = filter.MaxArea
                }
            );
            results.Items = _mapping.Map<List<PropertyDTO>>(multi.Read<Property, Address, PropertyType, Property>((p, a, t) =>
            {
                p.Address = a;
                p.PropertyType = t;
                return p;
            }));
            results.TotalCount = multi.ReadFirst<int>();
            query = @"
                    SELECT * FROM PropertyPhoto where PropertyId IN @ids
                    ";
            var ids = results.Items.Select(x => x.Id);
            var photos = await connection.QueryAsync<PropertyPhoto>(query, new { ids });

            foreach (var property in results.Items)
            {
                property.Photos = _mapping.Map<List<PropertyPhotoDTO>>(photos.Where(x => x.PropertyId == property.Id));
            }

            return results;
        }

        private async Task<PropertyDTO> GetReferences(PropertyDTO property)
        {
            property.PropertyType = _mapping
                        .Map<PropertyTypeDTO>(await _context
                        .PropertyType
                        .FindAsync(property.PropertyTypeId));

            property.Address = _mapping
                .Map<AddressDTO>(await _context
                .Address
                .FindAsync(property.AddressId));

            property.Broker = _mapping
                .Map<BrokerDTO>(await _context
                .Broker
                .FindAsync(property.BrokerId));

            property.Photos = _mapping
                .Map<List<PropertyPhotoDTO>>(await _context
                .PropertyPhoto
                .Where(x => x.PropertyId == property.Id && x.Enabled).ToListAsync());

            return property;
        }
    }
}
