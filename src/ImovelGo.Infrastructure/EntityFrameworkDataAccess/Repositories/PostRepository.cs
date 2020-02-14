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
    public class PostRepository : IPostRepository
    {
        private readonly ImovelGoContext _context;
        private readonly IMapper _mapping;

        public PostRepository(ImovelGoContext context, IMapper mapping)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
            _mapping = mapping;
        }

        public async Task<PostDTO> Add(PostDTO post)
        {
            Post entity = new Post()
            {
                AccountId = post.AccountId,
                CategoryId = post.CategoryId,
                CompanyId = post.CompanyId,
                HtmlContent = post.HtmlContent,
                PhotoUrl = post.PhotoUrl,
                PostId = post.PostId,
                Resume = post.Resume,
                Tags = post.Tags,
                Title = post.Title,
                Published = false,
                PageViews = 0,
                Deleted = false,
                Enabled = true,
                DateAdd = DateTime.Now,
                DateUpdated = DateTime.Now
            };

            await _context.Post.AddAsync(entity);
            await _context.SaveChangesAsync();
            return _mapping.Map<PostDTO>(entity);
        }

        public async Task Delete(int id)
        {
            Post entity = new Post()
            {
                Id = id,
                Deleted = true,
                Enabled = false
            };

            await _context.Post.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<PostDTO> Get(int id)
        {
            Post entity = await _context
                .Post
                .FindAsync(id);

            if (entity == null)
                return null;

            return _mapping.Map<PostDTO>(entity);
        }

        public async Task<PostDTO> Get(Guid id)
        {
            Post entity = await _context
                .Post
                .Where(x => x.PostId == id).FirstOrDefaultAsync();

            if (entity == null)
                return null;

            return _mapping.Map<PostDTO>(entity);
        }

        public async Task GetDetail(PostDTO post)
        {
            post.Category = _mapping
                        .Map<PostCategoryDTO>(await _context
                        .PostCategory
                        .FindAsync(post.CategoryId));

            post.Comemnts = _mapping
                        .Map<List<PostCommentDTO>>(await _context
                        .PostComment
                        .Where(x=> x.PostId == post.Id)
                        .ToListAsync());
        }

        public async Task<List<PostDTO>> GetByCompany(int id)
        {
            List<Post> entity = await _context
                .Post
                .Where(x => x.CompanyId == id && x.Enabled && !x.Deleted && x.Published)
                .ToListAsync();

            return _mapping.Map<List<PostDTO>>(entity);
        }

        public async Task<List<PostDTO>> GetFeaturedByCompany(int id)
        {
            List<Post> entity = await _context
                .Post
                .Where(x => x.CompanyId == id && x.Enabled && !x.Deleted && x.Published)
                .OrderByDescending(x => x.PageViews)
                .Take(3)
                .ToListAsync();

            return _mapping.Map<List<PostDTO>>(entity);
        }

        public async Task Update(PostDTO post)
        {
            Post entity = new Post()
            {
                Id = post.Id,
                CategoryId = post.CategoryId,
                HtmlContent = post.HtmlContent,
                PhotoUrl = post.PhotoUrl,
                Resume = post.Resume,
                Tags = post.Tags,
                Title = post.Title,                
                DateUpdated = DateTime.Now,
                Enabled = post.Enabled
            };

            await _context.Post.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePageView(int id)
        {
            Post entity = await _context
                .Post
                .FindAsync(id);

            entity.PageViews++;

            await _context.Post.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
    }
}
