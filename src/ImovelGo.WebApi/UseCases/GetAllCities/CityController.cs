using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImovelGo.Application.UseCases.GetAllCity;
using ImovelGo.Core.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ImovelGo.WebApi.UseCases.GetAllCities
{
    //[Authorize]
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        private readonly IGetAllCityUseCase _getAllCityUseCase;
        private readonly Presenter _presenter;

        public CityController(
            IGetAllCityUseCase getAllCityUseCase,
            Presenter presenter
            )
        {
            _getAllCityUseCase = getAllCityUseCase;
            _presenter = presenter;
        }

        /// <summary>
        /// Get an account balance
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<CityDTO> output = await _getAllCityUseCase.Execute();
            _presenter.Populate(output);
            return _presenter.ViewModel;
        }
    }
}
