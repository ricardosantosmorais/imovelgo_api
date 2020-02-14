using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.Repositories
{
    public interface ICityRepository
    {
        Task<CityDTO> Get(int id);
        Task<List<CityDTO>> GetByCompany(int id);
        Task<List<CityDTO>> GetAll();
        Task<CityDTO> Add(CityDTO city);
        Task Update(CityDTO city);
    }
}
