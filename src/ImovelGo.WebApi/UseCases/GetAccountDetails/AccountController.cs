using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImovelGo.Application.UseCases.GetAccountDetail;
using ImovelGo.Core.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ImovelGo.WebApi.UseCases.GetAccountDetails
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IGetAccountDetailsUseCase _getAccountDetailsUseCase;
        private readonly Presenter _presenter;

        public AccountController(
            IGetAccountDetailsUseCase getAccountDetailsUseCase,
            Presenter presenter
            )
        {
            _getAccountDetailsUseCase = getAccountDetailsUseCase;
            _presenter = presenter;
        }

        /// <summary>
        /// Get an account balance
        /// </summary>
        [HttpGet("{accountId}", Name = "GetAccount")]
        public async Task<IActionResult> Get(Guid accountId)
        {
            AccountDTO output = await _getAccountDetailsUseCase.Execute(accountId);
            _presenter.Populate(output);
            return _presenter.ViewModel;
        }
    }
}
