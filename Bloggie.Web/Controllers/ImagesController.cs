using Bloggie.Web.Repositories;
using EzTool.SDK.Infra.GreenAssembly.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bloggie.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> UploadAsync(IFromFile file)
        {

        }

    }

}
