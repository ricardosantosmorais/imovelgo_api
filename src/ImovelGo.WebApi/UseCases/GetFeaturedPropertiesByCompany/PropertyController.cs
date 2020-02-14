using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ImovelGo.Application.UseCases.GetFeaturedPropertiesByCompany;
using ImovelGo.Application.UseCases.GetPopularPropertiesByCompany;
using ImovelGo.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ImovelGo.WebApi.UseCases.GetFeaturedPropertiesByCompany
{
    [Route("api/[controller]")]
    public class PropertyController : Controller
    {
        private readonly IGetFeaturedPropertiesByCompanyUseCase _getFeaturedPropertiesByCompany;
        private readonly Presenter _presenter;

        public PropertyController(
            IGetFeaturedPropertiesByCompanyUseCase getFeaturedPropertiesByCompany,
            Presenter presenter
            )
        {
            _getFeaturedPropertiesByCompany = getFeaturedPropertiesByCompany;
            _presenter = presenter;
        }

        /// <summary>
        /// Get an account balance
        /// </summary>
        [HttpGet("GetFeatured/{companyId}")]
        public async Task<IActionResult> GetFeatured(int companyId)
        {
            List<PropertyDTO> output = await _getFeaturedPropertiesByCompany.Excecute(companyId);
            _presenter.Populate(output);
            return _presenter.ViewModel;
        }
    }
}
