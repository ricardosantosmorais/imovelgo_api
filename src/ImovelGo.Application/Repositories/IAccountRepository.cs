using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.Repositories
{
    public interface IAccountRepository
    {
        Task<AccountDTO> Get(int id);
        Task<AccountDTO> Get(Guid guid);
        Task<AccountDTO> Get(int? companyId, string email, string password);
        Task<AccountDTO> GetByEmail(int? companyId, string email);
        Task<AccountDTO> GetByCpf(int? companyId, string cpf);
        Task<AccountDTO> Add(AccountDTO account);
        Task Update(AccountDTO address);
        Task UpdatePassword(AccountDTO account);
        Task Delete(int id);
        Task<List<AccountDTO>> GetAgentsByCompany(int companyId);
    }
}
