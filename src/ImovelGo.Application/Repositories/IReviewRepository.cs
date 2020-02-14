using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.Repositories
{
    public interface IReviewRepository
    {
        Task<ReviewDTO> Get(int id);
        Task<List<ReviewDTO>> GetByCompany(int id);
        Task<List<ReviewDTO>> GetAll();
        Task<ReviewDTO> Add(ReviewDTO review);
        Task Update(ReviewDTO review);
    }
}
