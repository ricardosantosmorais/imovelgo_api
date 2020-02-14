using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.Login
{
    public interface ILoginUseCase
    {
        Task<AccountDTO> Excecute(int? companyId, string email, string password);
    }
}
