using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Repositories
{
    public interface ITagInterface
    {
        Task<IEnumerable<Tag>> GetAllAsync();
    }
}
