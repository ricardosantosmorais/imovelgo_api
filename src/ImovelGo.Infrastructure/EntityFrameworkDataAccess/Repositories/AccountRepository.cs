using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;
using ImovelGo.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ImovelGo.Infrastructure.EntityFrameworkDataAccess
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ImovelGoContext _context;
        private readonly IMapper _mapping;

        public AccountRepository(ImovelGoContext context, IMapper mapping)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
            _mapping = mapping;
        }

        public async Task<AccountDTO> Add(AccountDTO account)
        {
            Account entity = new Account()
            {
                AccountId = Guid.NewGuid(),
                AccountTypeId = account.AccountTypeId,
                CellPhone = account.CellPhone,
                CompanyId = account.CompanyId,
                Cpf = account.Cpf,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now,
                DDDCellPhone = account.DDDCellPhone,
                Deleted = false,
                DocumentNumber = account.DocumentNumber,
                Email = account.Email,
                Enabled = true,
                FistName = account.FistName,
                Avatar = account.Avatar,
                LastName = account.LastName,
                Password = account.Password,
                Terms = account.Terms
            };

            await _context.Accounts.AddAsync(entity);
            await _context.SaveChangesAsync();
            return _mapping.Map<AccountDTO>(entity);
        }

        public async Task<AccountDTO> Get(int id)
        {
            Account entity = await _context
                .Accounts
                .FindAsync(id);

            return _mapping.Map<AccountDTO>(entity);
        }

        public async Task<AccountDTO> Get(Guid guid)
        {
            Account entity = await _context
                .Accounts
                .Where(x => x.AccountId == guid).FirstOrDefaultAsync();

            return _mapping.Map<AccountDTO>(entity);
        }

        public async Task Delete(int id)
        {
            Account entity = new Account()
            {
                Id = id,
                Deleted = true,
                Enabled = false
            };

            await _context.Accounts.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(AccountDTO account)
        {
            Account entity = new Account()
            {
                Id = account.id,
                Enabled = account.Enabled,
                AccountTypeId = account.AccountTypeId,
                CellPhone = account.CellPhone,
                Cpf = account.Cpf,
                DateUpdated = DateTime.Now,
                DDDCellPhone = account.DDDCellPhone,
                DocumentNumber = account.DocumentNumber,
                Email = account.Email,
                FistName = account.FistName,
                Avatar = account.Avatar,
                LastName = account.LastName
            };

            await _context.Accounts.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<AccountDTO> Get(int? companyId, string email, string password)
        {
            Account entity = await _context
                .Accounts
                .Where(x => x.Email == email && x.Password == password && x.CompanyId == companyId && x.Enabled && !x.Deleted).FirstOrDefaultAsync();

            return _mapping.Map<AccountDTO>(entity);
        }

        public async Task UpdatePassword(AccountDTO account)
        {
            Account entity = await _context
                .Accounts
                .FindAsync(account.id);

            entity.Password = account.Password;

            await _context.Accounts.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<AccountDTO> GetByEmail(int? companyId, string email)
        {
            Account entity = await _context
                            .Accounts
                            .Where(x => x.Email == email && x.CompanyId == companyId).FirstOrDefaultAsync();

            return _mapping.Map<AccountDTO>(entity);
        }

        public async Task<AccountDTO> GetByCpf(int? companyId, string cpf)
        {
            Account entity = await _context
                            .Accounts
                            .Where(x => x.Cpf == cpf && x.CompanyId == companyId).FirstOrDefaultAsync();

            return _mapping.Map<AccountDTO>(entity);
        }

        public async Task<List<AccountDTO>> GetAgentsByCompany(int companyId)
        {
            List<Account> entity = await _context
                            .Accounts
                            .Where(x => x.CompanyId == companyId && x.AccountTypeId == 2).ToListAsync();

            return _mapping.Map<List<AccountDTO>>(entity);
        }

    }
}
