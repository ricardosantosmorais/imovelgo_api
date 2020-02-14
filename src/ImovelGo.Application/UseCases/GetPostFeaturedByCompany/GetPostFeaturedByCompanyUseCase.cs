using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetPostFeaturedByCompany
{
    public sealed class GetPostFeaturedByCompanyUseCase : IGetPostFeaturedByCompanyUseCase
    {
        private readonly IPostRepository _postRepository;

        public GetPostFeaturedByCompanyUseCase(
            IPostRepository postRepository
            )
        {
            _postRepository = postRepository;
        }

        public async Task<List<PostDTO>> Excecute(int id)
        {
            List<PostDTO> properties = await _postRepository.GetFeaturedByCompany(id);
            return properties;
        }
    }
}
                                                             