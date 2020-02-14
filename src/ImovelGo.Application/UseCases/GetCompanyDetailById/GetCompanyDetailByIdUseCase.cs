using System;
using System.Threading.Tasks;
using ImovelGo.Application.Exception;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetCompanyDetailById
{
    public sealed class GetCompanyDetailByIdUseCase : IGetCompanyDetailByIdUseCase
    {
        private readonly ICompanyRepository _companyRepository;

        public GetCompanyDetailByIdUseCase(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<CompanyDTO> Excecute(int id)
        {
            CompanyDTO company = await _companyRepository.Get(id);

            if (company == null)
                throw new CompanyNotFoundException($"The company {id} does not exists or is not processed yet.");

            return company;
        }
    }
}
