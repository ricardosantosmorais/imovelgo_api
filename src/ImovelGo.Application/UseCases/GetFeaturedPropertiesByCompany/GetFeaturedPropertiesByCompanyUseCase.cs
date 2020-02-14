using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Application.Exception;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetFeaturedPropertiesByCompany
{
    public sealed class GetFeaturedPropertiesByCompanyUseCase : IGetFeaturedPropertiesByCompanyUseCase
    {
        private readonly IPropertyRepository _propertyRepository;
        private readonly IAddressRepository _addressRepository;

        public GetFeaturedPropertiesByCompanyUseCase(
            IAddressRepository addressRepository,
            IPropertyRepository propertyRepository
            )
        {
            _addressRepository = addressRepository;
            _propertyRepository = propertyRepository;
        }

        public async Task<List<PropertyDTO>> Excecute(int id)
        {
            List<PropertyDTO> properties = await _propertyRepository.GetByCompanyAndFeatured(id);
            foreach (var item in properties)
            {
                item.Address = await _addressRepository.Get(item.AddressId);
            }
            return properties;
        }
    }
}
