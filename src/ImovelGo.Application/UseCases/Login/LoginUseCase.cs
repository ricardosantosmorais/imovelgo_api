using System;
using System.Threading.Tasks;
using ImovelGo.Application.Exception;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.Login
{
    public sealed class LoginUseCase : ILoginUseCase
    {
        private readonly IAccountRepository _accountRepository;

        public LoginUseCase(
            IAccountRepository accountRepository
            )
        {
            _accountRepository = accountRepository;
        }

        public async Task<AccountDTO> Excecute(int? companyId, string email, string password)
        {
            password = Common.SecurityManager.CreateHash(password);
            var account = await _accountRepository.Get(companyId, email, password);
            if(account == null)
                throw new AccountNotFoundException($"The account does not exists or is not processed yet.");

            return account;
        }
    }
}
