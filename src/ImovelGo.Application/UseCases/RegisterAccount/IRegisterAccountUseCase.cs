using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.RegisterAccount
{
    public interface IRegisterAccountUseCase
    {
        Task<AccountDTO> Excecute(AccountDTO account);
    }
}
