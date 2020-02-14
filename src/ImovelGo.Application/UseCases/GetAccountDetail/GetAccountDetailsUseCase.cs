using System;
using System.Threading.Tasks;
using ImovelGo.Application.Exception;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetAccountDetail
{
    public sealed class GetAccountDetailsUseCase : IGetAccountDetailsUseCase
    {
        private readonly IAccountRepository _accountRepository;

        public GetAccountDetailsUseCase(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<AccountDTO> Execute(Guid accountId)
        {
            AccountDTO account = await _accountRepository.Get(1);

            if (account == null)
                throw new AccountNotFoundException($"The account {accountId} does not exists or is not processed yet.");

            return account;
        }
    }
}
