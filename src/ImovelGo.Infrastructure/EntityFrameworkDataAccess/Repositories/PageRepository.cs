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
    public class PageRepository : IPageRepository
    {
        private readonly ImovelGoContext _context;
        private readonly IMapper _mapping;

        public PageRepository(ImovelGoContext context, IMapper mapping)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
            _mapping = mapping;
        }

        public async Task<PageDTO> Add(PageDTO page)
        {
            Page entity = new Page()
            {
                File = page.File,
                Html = page.Html,
                Title = page.Title,
                Enabled = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            await _context.Page.AddAsync(entity);
            await _context.SaveChangesAsync();
            return _mapping.Map<PageDTO>(entity);
        }

        public async Task<PageDTO> Get(int id)
        {
            Page entity = await _context
                .Page
                .FindAsync(id);

            if (entity == null)
                return null;

            return _mapping.Map<PageDTO>(entity);
        }

        public async Task<List<PageDTO>> GetByCompanyId(int id)
        {
            var pages = _mapping.Map<List<PageDTO>>(await (from a in _context.Page
                                   join aa in _context.CompanyPage on a.Id equals aa.PageId
                                   where aa.CompanyId == id
                                   where a.Enabled
                                   select a).ToListAsync());

            if(pages.Any())
            {
                var companyAreas = await _context.CompanyArea
                                    .Where(x => x.CompanyId == id)
                                    .Select(x => x.AreaId).ToListAsync();

                foreach (var item in pages)
                {
                    item.Areas = _mapping.Map<List<AreaDTO>>(await (from a in _context.Area
                                        where companyAreas.Contains(a.Id)
                                        where a.PageId == item.Id
                                        where a.Enabled
                                        select a).ToListAsync());
                }
            }

            return pages;
        }

        public async Task Update(PageDTO page)
        {
            Page entity = new Page()
            {
                Id = page.Id,
                DateUpdated = DateTime.Now,
                Enabled = page.Enabled,
                File = page.File,
                Html = page.Html,
                Title = page.Title
            };

            await _context.Page.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
    }
}
