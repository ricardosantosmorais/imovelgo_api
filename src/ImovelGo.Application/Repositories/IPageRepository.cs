using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.Repositories
{
    public interface IPageRepository
    {
        Task<PageDTO> Get(int id);
        Task<List<PageDTO>> GetByCompanyId(int id);
        Task<PageDTO> Add(PageDTO page);
        Task Update(PageDTO page);
    }
}
