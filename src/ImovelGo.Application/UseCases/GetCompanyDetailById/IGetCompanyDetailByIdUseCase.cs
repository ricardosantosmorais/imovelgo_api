using System;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetCompanyDetailById
{
    public interface IGetCompanyDetailByIdUseCase
    {
        Task<CompanyDTO> Excecute(int id);
    }
}
