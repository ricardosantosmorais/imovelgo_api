using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImovelGo.Application.UseCases.SearchPropertiesByCompany;
using ImovelGo.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ImovelGo.WebApi.UseCases.SeachPropertiesByCompany
{
    [Route("api/[controller]")]
    public class PropertyController : Controller
    {
        private readonly ISearchPropertiesByCompanyUseCase _searchPropertiesByCompany;
        private readonly Presenter _presenter;

        public PropertyController(
            ISearchPropertiesByCompanyUseCase searchPropertiesByCompany,
            Presenter presenter)
        {
            _searchPropertiesByCompany = searchPropertiesByCompany;
            _presenter = presenter;
        }

        /// <summary>
        /// Get an account balance
        /// </summary>
        [HttpPost("Search")]
        public async Task<IActionResult> Get([FromBody] FilterDTO filter)
        {
            PagedResultsDTO<PropertyDTO> output = await _searchPropertiesByCompany.Excecute(filter);
            _presenter.Populate(output);
            return _presenter.ViewModel;
        }
    }
}
