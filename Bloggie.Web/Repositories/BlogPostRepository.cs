using Bloggie.Web.Data;
using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Repositories
{
    public class BlogPostRepository: IBlogPostRepository
    {
        private readonly BloggieDbContext bloggieDbContext;

        public BlogPostRepository(BloggieDbContext bloggieDbContext)
        {
           this.bloggieDbContext = bloggieDbContext;
        }
        public async Task<IEnumerable<BlogPost>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<BlogPost?> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<BlogPost> AddAsync(BlogPost blogPost)
        {
            await bloggieDbContext.AddAsync(blogPost);
           await bloggieDbContext.SaveChangesAsync();
           return blogPost;
        }

        public async Task<BlogPost?> UpdateAsync(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }

        public async Task<BlogPost?> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
