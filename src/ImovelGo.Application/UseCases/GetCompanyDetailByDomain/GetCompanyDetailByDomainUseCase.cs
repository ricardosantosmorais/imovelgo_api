using System;
using System.Threading.Tasks;
using ImovelGo.Application.Exception;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetCompanyDetailByDomain
{
    public sealed class GetCompanyDetailByDomainUseCase : IGetCompanyDetailByDomainUseCase
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IPageRepository _pageRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly ITemplateRepository _templateRepository;
        private readonly IAccountRepository _accountRepository;

        public GetCompanyDetailByDomainUseCase(ICompanyRepository companyRepository,
            IPageRepository pageRepository,
            IAddressRepository addressRepository,
            IAccountRepository accountRepository,
            ITemplateRepository templateRepository)
        {
            _companyRepository = companyRepository;
            _pageRepository = pageRepository;
            _addressRepository = addressRepository;
            _templateRepository = templateRepository;
            _accountRepository = accountRepository;
        }

        public async Task<CompanyDTO> Execute(string domain, bool loadPages = false)
        {
            CompanyDTO company = await _companyRepository.Get(domain);

            if (company != null)
            {
                company.Template = await _templateRepository.GetByCompanyId(company.Id);
                company.Agents = await _accountRepository.GetAgentsByCompany(company.Id);
                company.Address = await _addressRepository.GetByCompany(company.Id);
                if (loadPages)
                {
                    company.Pages = await _pageRepository.GetByCompanyId(company.Id);
                }
            }

            if (company == null)
                throw new CompanyNotFoundException($"The company {domain} does not exists or is not processed yet.");

            return company;
        }
    }
}
