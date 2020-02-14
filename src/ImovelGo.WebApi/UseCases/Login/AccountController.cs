using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using ImovelGo.Application.UseCases.Login;
using ImovelGo.Core.Domain;
using ImovelGo.WebApi.Filters;
using ImovelGo.WebApi.Helper;
using ImovelGo.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace ImovelGo.WebApi.UseCases.Login
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly ILoginUseCase _loginUseCase;
        private readonly Presenter _presenter;
        private readonly ILogger<AccountController> _logger;
        private readonly IConfiguration _config;
        private readonly TokenPackage _token;

        public AccountController(
            ILoginUseCase loginUseCase,
            ILogger<AccountController> logger,
            IConfiguration config,
            Presenter presenter)
        {
            _loginUseCase = loginUseCase;
            _presenter = presenter;
            _logger = logger;
            _config = config;
            _token = new TokenPackage(_config);
        }

        /// <summary>
        /// Get an account balance
        /// </summary>
        [HttpPost("Login")]
        public async Task<IActionResult> Post([FromBody] AccountDTO account)
        {
            try
            {
                AccountDTO output = await _loginUseCase.Excecute(account.CompanyId, account.Email, account.Password);
                _presenter.Populate(output);

                if (output != null)
                {
                    var token = _token.Encode(output);

                    return Ok(new
                    {
                        authenticated = true,
                        accessToken = token,
                        message = "OK"

                    });
                } else
                {
                    return Unauthorized(new {
                        authenticated = false,
                        message = "Error"
                    });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status401Unauthorized, ex.Message);
            }
        }        
    }
}
