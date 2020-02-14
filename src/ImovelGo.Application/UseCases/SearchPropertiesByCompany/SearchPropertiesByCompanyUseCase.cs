using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.SearchPropertiesByCompany
{
    public sealed class SearchPropertiesByCompanyUseCase : ISearchPropertiesByCompanyUseCase
    {
        private readonly IPropertyRepository _propertyRepository;

        public SearchPropertiesByCompanyUseCase(
            IPropertyRepository propertyRepository
            )
        {
            _propertyRepository = propertyRepository;
        }

        public async Task<PagedResultsDTO<PropertyDTO>> Excecute(FilterDTO filter)
        {
            PagedResultsDTO<PropertyDTO> results = await _propertyRepository.Search(filter);
            return results;
        }
    }
}
