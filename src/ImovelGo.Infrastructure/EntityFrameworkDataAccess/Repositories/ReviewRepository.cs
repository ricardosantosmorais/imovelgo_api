using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ImovelGo.Application.Repositories;
using ImovelGo.Core.Domain;
using ImovelGo.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ImovelGo.Infrastructure.EntityFrameworkDataAccess
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ImovelGoContext _context;
        private readonly IMapper _mapping;

        public ReviewRepository(ImovelGoContext context, IMapper mapping)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
            _mapping = mapping;
        }

        public async Task<ReviewDTO> Add(ReviewDTO review)
        {
            Review entity = new Review()
            {
                AccountId = review.AccountId,
                Avatar = review.Avatar,
                Name = review.Name,
                Title = review.Title,
                CompanyId = review.CompanyId,
                Description = review.Description,
                DateUpdated = DateTime.Now,
                Deleted = false,
                DateAdd = DateTime.Now,
                Enabled = true
            };

            await _context.Review.AddAsync(entity);
            await _context.SaveChangesAsync();
            return _mapping.Map<ReviewDTO>(entity);
        }

        public async Task Delete(int id)
        {
            Review entity = new Review()
            {
                Id = id,
                Deleted = true,
                Enabled = false
            };

            await _context.Review.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<ReviewDTO> Get(int id)
        {
            Review entity = await _context
                .Review
                .FindAsync(id);

            return _mapping.Map<ReviewDTO>(entity);
        }

        public async Task<List<ReviewDTO>> GetAll()
        {
            List<Review> entity = await _context
                .Review
                .ToListAsync();

            return _mapping.Map<List<ReviewDTO>>(entity);
        }

        public async Task Update(ReviewDTO review)
        {
            Review entity = new Review()
            {
                Id = review.Id,
                Avatar = review.Avatar,
                DateUpdated = DateTime.Now,
                Description = review.Description,
                Name = review.Name,
                Title = review.Title,
                Enabled = review.Enabled
            };

            await _context.Review.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ReviewDTO>> GetByCompany(int id)
        {
            List<Review> entity = await _context
                .Review
                .Where(x => x.CompanyId == id)
                .ToListAsync();

            return _mapping.Map<List<ReviewDTO>>(entity);
        }
    }
}
