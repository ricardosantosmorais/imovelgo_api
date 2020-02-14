using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ImovelGo.Application.UseCases.GetFeaturedPropertiesByCompany;
using ImovelGo.Application.UseCases.GetPopularPropertiesByCompany;
using ImovelGo.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ImovelGo.WebApi.UseCases.GetPopularProperties
{
    [Route("api/[controller]")]
    public class PropertyController : Controller
    {
        private readonly IGetPopularPropertiesByCompanyUseCase _getPopularProperties;
        private readonly Presenter _presenter;

        public PropertyController(
            IGetPopularPropertiesByCompanyUseCase getPopularProperties,
            Presenter presenter
            )
        {
            _getPopularProperties = getPopularProperties;
            _presenter = presenter;
        }

        /// <summary>
        /// Get an account balance
        /// </summary>
        [HttpGet("GetPopular/{companyId}")]
        public async Task<IActionResult> GetPopular(int companyId)
        {
            List<PropertyDTO> output = await _getPopularProperties.Excecute(companyId);
            _presenter.Populate(output);
            return _presenter.ViewModel;
        }
    }
}
