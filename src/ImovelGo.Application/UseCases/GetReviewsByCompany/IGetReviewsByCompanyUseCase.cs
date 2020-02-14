using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetReviewsByCompany
{
    public interface IGetReviewsByCompanyUseCase
    {
        Task<List<ReviewDTO>> Excecute(int id);
    }
}
