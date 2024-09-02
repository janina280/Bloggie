using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using EzTool.SDK.Infra.GreenAssembly.Interfaces;

namespace Bloggie.Web.Repositories
{
    public class CloudinaryImageRepository:IImageRepository
    { private readonly IConfiguration _configuration;
        private readonly Account account;
        public CloudinaryImageRepository(IConfiguration configuration)
        {
            this._configuration= configuration;
            account= new Account(
                configuration.GetSection("Cloudinary")["CloudName"],
                configuration.GetSection("Cloudinary")["ApiKey"],
                configuration.GetSection("Cloudinary")["ApiSecret"]
                );
        }
        public Task<string> UploadAsync(IFromFile file)
        {
            var client = new Cloudinary(account);
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(file.FileName),
                DisplayName = file.F
            };
        }
    }
}
