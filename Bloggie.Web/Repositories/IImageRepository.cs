namespace Bloggie.Web.Repositories
{
    public interface IImageRepository
    {
        Task<string> UploadAsync(IFromFile file);
    }
}
