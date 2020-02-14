using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetPopularPropertiesByCompany
{
    public interface IGetPopularPropertiesByCompanyUseCase
    {
        Task<List<PropertyDTO>> Excecute(int id);
    }
}
