using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetPostFeaturedByCompany
{
    public interface IGetPostFeaturedByCompanyUseCase
    {
        Task<List<PostDTO>> Excecute(int id);
    }
}
