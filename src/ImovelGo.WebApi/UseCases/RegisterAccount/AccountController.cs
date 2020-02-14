using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImovelGo.Application.Exception;
using ImovelGo.Application.UseCases.RegisterAccount;
using ImovelGo.Core.Domain;
using ImovelGo.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ImovelGo.WebApi.UseCases.RegisterAccount
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IRegisterAccountUseCase _registerAccountUse;
        private readonly Presenter _presenter;
        private readonly ILogger<AccountController> _logger;

        public AccountController(
            IRegisterAccountUseCase registerAccountUse,
            ILogger<AccountController> logger,
            Presenter presenter)
        {
            _registerAccountUse = registerAccountUse;
            _presenter = presenter;
            _logger = logger;
        }

        /// <summary>
        /// Get an account balance
        /// </summary>
        [HttpPost("Register")]
        public async Task<IActionResult> Post([FromBody] AccountDTO account)
        {
            try
            {
                AccountDTO output = await _registerAccountUse.Excecute(account);
                _presenter.Populate(output);
                return _presenter.ViewModel;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
