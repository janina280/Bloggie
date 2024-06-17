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
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    [ActionName("Add")]
    public  IActionResult  Add(AddTagRequest addTagRequest)
    {
        //Mapping AddTagRequest to Tag domain model
        var tag = new Tag
        {
            Name = addTagRequest.Name,
            DisplayName = addTagRequest.DisplayName
        }; 

         bloggiedbContext.Tags.Add(tag); 
         bloggiedbContext.SaveChanges();

        return View("Add");
    }
}