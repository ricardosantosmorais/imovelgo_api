using System;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.Repositories
{
    public interface ICompanyRepository
    {
        Task<CompanyDTO> Get(int id);
        Task<CompanyDTO> Get(Guid guid);
        Task<CompanyDTO> Get(string domain);
        Task<CompanyDTO> Add(CompanyDTO company);
        Task Update(CompanyDTO company);
        Task Delete(int id);
    }
}
