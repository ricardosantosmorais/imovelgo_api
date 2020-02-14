using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.SearchPropertiesByCompany
{
    public interface ISearchPropertiesByCompanyUseCase
    {
        Task<PagedResultsDTO<PropertyDTO>> Excecute(FilterDTO filter);
    }
}
