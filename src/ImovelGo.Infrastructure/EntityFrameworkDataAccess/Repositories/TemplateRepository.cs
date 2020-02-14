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
    public class TemplateRepository : ITemplateRepository
    {
        private readonly ImovelGoContext _context;
        private readonly IMapper _mapping;

        public TemplateRepository(ImovelGoContext context, IMapper mapping)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
            _mapping = mapping;
        }

        public async Task<TemplateDTO> Add(TemplateDTO template)
        {
            Template entity = new Template()
            {
                Name = template.Name,
                DateAdd = DateTime.Now,
                Enabled = true,
                Html = template.Html
            };

            await _context.Template.AddAsync(entity);
            await _context.SaveChangesAsync();
            return _mapping.Map<TemplateDTO>(entity);
        }

        public async Task Delete(int id)
        {
            Template entity = new Template()
            {
                Id = id,
                Enabled = false
            };

            await _context.Template.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<TemplateDTO> Get(int id)
        {
            Template entity = await _context
                .Template
                .FindAsync(id);

            return _mapping.Map<TemplateDTO>(entity);
        }

        public async Task<TemplateDTO> GetByCompanyId(int id)
        {
            Template entity = await (from a in _context.Template
                                     join aa in _context.Company on a.Id equals aa.TemplateId
                                     where aa.Id == id
                                     select a).FirstOrDefaultAsync();

            return _mapping.Map<TemplateDTO>(entity);
        }

        public async Task Update(TemplateDTO template)
        {
            Template entity = new Template()
            {
                Id = template.Id,
                Name = template.Name,
                Enabled = template.Enabled,
                Html = template.Html
            };

            await _context.Template.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
    }
}
