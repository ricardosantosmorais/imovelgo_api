using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetAllCity
{
    public interface IGetAllCityUseCase
    {
        Task<List<CityDTO>> Execute();
    }
}
