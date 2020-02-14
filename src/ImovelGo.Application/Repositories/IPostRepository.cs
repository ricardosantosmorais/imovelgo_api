using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.Repositories
{
    public interface IPostRepository
    {
        Task<PostDTO> Get(int id);
        Task<PostDTO> Get(Guid id);
        Task GetDetail(PostDTO post);
        Task<List<PostDTO>> GetByCompany(int id);
        Task<List<PostDTO>> GetFeaturedByCompany(int id);
        Task<PostDTO> Add(PostDTO review);
        Task Update(PostDTO review);
        Task Delete(int id);
        Task UpdatePageView(int id);
    }
}
