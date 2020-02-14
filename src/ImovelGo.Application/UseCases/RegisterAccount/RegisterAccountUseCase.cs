using System;
using System.Threading.Tasks;
using ImovelGo.Application.Exception;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.RegisterAccount
{
    public sealed class RegisterAccountUseCase : IRegisterAccountUseCase
    {
        private readonly IAccountRepository _accountRepository;

        public RegisterAccountUseCase(
            IAccountRepository accountRepository
            )
        {
            _accountRepository = accountRepository;
        }

        public async Task<AccountDTO> Excecute(AccountDTO account)
        {
            var accByEmail = await _accountRepository.GetByEmail(account.CompanyId, account.Email);
            if(accByEmail != null) 
                throw new AccountExistsException($"O e-mail informado já existe. Tente fazer o login.");

            if (!String.IsNullOrEmpty(account.Cpf))
            {
                var accByCpf = await _accountRepository.GetByCpf(account.CompanyId, account.Cpf);
                if (accByCpf != null)
                    throw new AccountExistsException($"O CPF informado já existe.");
            }

            account.Password = Common.SecurityManager.CreateHash(account.Password);

            return await _accountRepository.Add(account);
        }
    }
}
