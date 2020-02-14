using System;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetAccountDetail
{
    public interface IGetAccountDetailsUseCase
    {
        Task<AccountDTO> Execute(Guid accountId);
    }
}
