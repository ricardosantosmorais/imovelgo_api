using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.Repositories
{
    public interface IAddressRepository
    {
        Task<AddressDTO> Get(int id);
        Task<AddressDTO> Get(Guid guid);
        Task<List<AddressDTO>> GetByAccount(int id);
        Task<List<AddressDTO>> GetByCompany(int id);
        Task<AddressDTO> Add(AddressDTO address);
        Task Update(AddressDTO address);
        Task Delete(int id);
    }
}
