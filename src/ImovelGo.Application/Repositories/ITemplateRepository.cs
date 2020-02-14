using System;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.Repositories
{
    public interface ITemplateRepository
    {
        Task<TemplateDTO> Get(int id);
        Task<TemplateDTO> GetByCompanyId(int id);
        Task<TemplateDTO> Add(TemplateDTO template);
        Task Update(TemplateDTO template);
        Task Delete(int id);
    }
}
