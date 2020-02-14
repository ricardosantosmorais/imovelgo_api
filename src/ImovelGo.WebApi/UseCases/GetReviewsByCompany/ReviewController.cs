using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImovelGo.Application.UseCases.GetReviewsByCompany;
using ImovelGo.Core.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ImovelGo.WebApi.UseCases.GetReviewsByCompany
{
    [Route("api/[controller]")]
    public class ReviewController : Controller
    {
        private readonly IGetReviewsByCompanyUseCase _getReviewsByCompany;
        private readonly Presenter _presenter;

        public ReviewController(
            IGetReviewsByCompanyUseCase getReviewsByCompany,
            Presenter presenter)
        {
            _getReviewsByCompany = getReviewsByCompany;
            _presenter = presenter;
        }

        /// <summary>
        /// Get an account balance
        /// </summary>
        [HttpGet("{companyId}")]
        public async Task<IActionResult> Get(int companyId)
        {
            List<ReviewDTO> output = await _getReviewsByCompany.Excecute(companyId);
            _presenter.Populate(output);
            return _presenter.ViewModel;
        }
    }
}
