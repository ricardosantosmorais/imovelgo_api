using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Application.Exception;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetPopularPropertiesByCompany
{
    public sealed class GetPopularPropertiesByCompanyUseCase : IGetPopularPropertiesByCompanyUseCase
    {
        private readonly IPropertyRepository _propertyRepository;
        private readonly IAddressRepository _addressRepository;

        public GetPopularPropertiesByCompanyUseCase(
            IAddressRepository addressRepository,
            IPropertyRepository propertyRepository
            )
        {
            _addressRepository = addressRepository;
            _propertyRepository = propertyRepository;
        }

        public async Task<List<PropertyDTO>> Excecute(int id)
        {
            List<PropertyDTO> properties = await _propertyRepository.GetPopularByCompany(id);
            return properties;
        }
    }
}
