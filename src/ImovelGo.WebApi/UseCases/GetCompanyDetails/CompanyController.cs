using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImovelGo.Application.UseCases.GetCompanyDetailByDomain;
using ImovelGo.Core.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ImovelGo.WebApi.UseCases.GetCompanyDetails
{
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        private readonly IGetCompanyDetailByDomainUseCase _getCompanyDetailByDomain;
        private readonly Presenter _presenter;

        public CompanyController(
            IGetCompanyDetailByDomainUseCase getCompanyDetailByDomain,
            Presenter presenter)
        {
            _getCompanyDetailByDomain = getCompanyDetailByDomain;
            _presenter = presenter;
        }

        /// <summary>
        /// Get an account balance
        /// </summary>
        [HttpGet("{domain}", Name = "GetCompanyByDomain")]
        public async Task<IActionResult> Get(string domain)
        {
            CompanyDTO output = await _getCompanyDetailByDomain.Execute(domain, true);
            _presenter.Populate(output);
            return _presenter.ViewModel;
        }
    }
}
