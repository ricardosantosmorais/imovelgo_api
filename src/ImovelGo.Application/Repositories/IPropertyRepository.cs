using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.Repositories
{
    public interface IPropertyRepository
    {
        Task<PropertyDTO> Get(int id);
        Task<List<PropertyDTO>> GetByCompany(int id);
        Task<List<PropertyDTO>> GetByCompanyAndFeatured(int id);
        Task<List<PropertyDTO>> GetByCompanyAndLast(int id);
        Task<List<PropertyDTO>> GetPopularByCompany(int id);
        Task<PagedResultsDTO<PropertyDTO>> Search(FilterDTO filter);
        Task<PropertyDTO> Add(PropertyDTO property);
        Task Update(PropertyDTO property);
        Task Delete(int id);
        Task UpdatePageViews(int id);
    }
}
