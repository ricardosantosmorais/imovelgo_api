using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Application.Exception;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetAllCity
{
    public sealed class GetAllCityUseCase : IGetAllCityUseCase
    {
        private readonly ICityRepository _cityRepository;

        public GetAllCityUseCase(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<List<CityDTO>> Execute()
        {
            return await _cityRepository.GetAll();
        }
    }
}
