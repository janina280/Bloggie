using Bloggie.Web.Data;
using Bloggie.Web.Models.Domain;
using Bloggie.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bloggie.Web.Controllers;

public class AdminTagsController : Controller
{
    private readonly BloggieDbContext bloggiedbContext;
    public AdminTagsController(BloggieDbContext bloggieDbContext)
    {
       this.bloggiedbContext=bloggieDbContext;
    }

    [HttpGet]
    public IActionResult AddAsync()
    {
        return View();
    }
    [HttpPost]
    [ActionName("AddAsync")]
    public  async Task<IActionResult>  AddAsync(AddTagRequest addTagRequest)
    {
        //Mapping AddTagRequest to Tag domain model
        var tag = new Tag
        {
            Name = addTagRequest.Name,
            DisplayName = addTagRequest.DisplayName
        }; 
        bloggiedbContext.Tags.AddAsync(tag);
        bloggiedbContext.SaveChanges();

        return View("Add");
    }
}