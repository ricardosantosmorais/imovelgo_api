using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;

namespace ImovelGo.Application.UseCases.GetReviewsByCompany
{
    public sealed class GetGetReviewsByCompanyUseCase : IGetReviewsByCompanyUseCase
    {
        private readonly IReviewRepository _reviewRepository;

        public GetGetReviewsByCompanyUseCase(
            IReviewRepository reviewRepository
            )
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<List<ReviewDTO>> Excecute(int id)
        {
            List<ReviewDTO> reviews = await _reviewRepository.GetByCompany(id);
            return reviews;
        }
    }
}
