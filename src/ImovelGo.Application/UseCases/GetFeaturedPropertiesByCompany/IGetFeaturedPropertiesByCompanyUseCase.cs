using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetFeaturedPropertiesByCompany
{
    public interface IGetFeaturedPropertiesByCompanyUseCase
    {
        Task<List<PropertyDTO>> Excecute(int id);
    }
}
