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
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ImovelGoContext _context;
        private readonly IMapper _mapping;

        public CompanyRepository(ImovelGoContext context, IMapper mapping)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
            _mapping = mapping;
        }

        public async Task<CompanyDTO> Add(CompanyDTO company)
        {
            Company entity = new Company()
            {
                About = company.About,
                Enabled = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                Deleted = false,
                Domain = company.Domain,
                Email = company.Email,
                Facebook = company.Facebook,
                Instagram = company.Instagram,
                Linkedin = company.Linkedin,
                Logo = company.Logo,
                MinDescription = company.MinDescription,
                Name = company.Name,
                Skype = company.Skype,
                Telephone = company.Telephone,
                Twitter = company.Twitter
            };

            await _context.Company.AddAsync(entity);
            await _context.SaveChangesAsync();
            return _mapping.Map<CompanyDTO>(entity);
        }

        public async Task Delete(int id)
        {
            Company entity = new Company()
            {
                Id = id,
                Deleted = true,
                Enabled = false
            };

            await _context.Company.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<CompanyDTO> Get(int id)
        {
            Company entity = await _context
                .Company
                .FindAsync(id);

            return _mapping.Map<CompanyDTO>(entity);
        }

        public async Task<CompanyDTO> Get(Guid guid)
        {
            Company entity = await _context
                .Company
                .Where(x => x.CompanyId == guid).FirstOrDefaultAsync();

            return _mapping.Map<CompanyDTO>(entity);
        }

        public async Task<CompanyDTO> Get(string domain)
        {
            Company entity = await _context
                .Company
                .Where(x => x.Domain == domain).FirstOrDefaultAsync();

            return _mapping.Map<CompanyDTO>(entity);
        }

        public async Task Update(CompanyDTO company)
        {
            Company entity = new Company()
            {
                Id = company.Id,
                About = company.About,
                DateUpdated = DateTime.Now,
                Domain = company.Domain,
                Email = company.Email,
                Facebook = company.Facebook,
                Instagram = company.Instagram,
                Linkedin = company.Linkedin,
                Logo = company.Logo,
                MinDescription = company.MinDescription,
                Name = company.Name,
                Skype = company.Skype,
                Telephone = company.Telephone,
                Twitter = company.Twitter
            };

            await _context.Company.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
    }
}
