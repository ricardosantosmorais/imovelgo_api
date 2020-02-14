using System;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetCompanyDetailByDomain
{
    public interface IGetCompanyDetailByDomainUseCase
    {
        Task<CompanyDTO> Execute(string domain, bool loadPages);
    }
}
