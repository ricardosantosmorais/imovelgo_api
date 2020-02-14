using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ImovelGo.Application.UseCases.GetPostFeaturedByCompany;
using ImovelGo.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ImovelGo.WebApi.UseCases.GetPostFeaturedByCompany
{
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly IGetPostFeaturedByCompanyUseCase _getPostFeaturedByCompany;
        private readonly Presenter _presenter;

        public PostController(
            IGetPostFeaturedByCompanyUseCase getPostFeaturedByCompany,
            Presenter presenter
            )
        {
            _getPostFeaturedByCompany = getPostFeaturedByCompany;
            _presenter = presenter;
        }

        /// <summary>
        /// Get an account balance
        /// </summary>
        [HttpGet("GetPopular/{companyId}")]
        public async Task<IActionResult> GetPopular(int companyId)
        {
            List<PostDTO> output = await _getPostFeaturedByCompany.Excecute(companyId);
            _presenter.Populate(output);
            return _presenter.ViewModel;
        }
    }
}
