using Bloggie.Web.Data;
using Bloggie.Web.Models.Domain;
using Bloggie.Web.Models.ViewModels;
using Bloggie.Web.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Bloggie.Web.Controllers;

public class AdminTagsController : Controller
{
    private readonly ITagRepository tagRepository;

    public AdminTagsController(ITagRepository tagRepository)
    {
        this.tagRepository = tagRepository;
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    [ActionName("Add")]
    public async Task<IActionResult> Add(AddTagRequest addTagRequest)
    {
        //Mapping AddTagRequest to Tag domain model
        var tag = new Tag
        {
            Name = addTagRequest.Name,
            DisplayName = addTagRequest.DisplayName
        };

        await tagRepository.AddAsync(tag);
        return RedirectToAction("List");
    }

    [HttpGet]
    [ActionName("List")]
    public async Task<IActionResult> List()
    {
        var tags = await tagRepository.GetAllAsync();
        return View(tags);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(Guid id)
    {
        //1st  method
        //var tag=   bloggieDbContext.Tags.Find(id);

        //2nd method
        var tag = await bloggieDbContext.Tags.FirstOrDefaultAsync(x => x.Id == id);
        if (tag != null)
        {
            var editTagRequest = new EditTagRequest()
            {
                Id = tag.Id,
                Name = tag.Name,
                DisplayName = tag.DisplayName
            };
            return View(editTagRequest);
        }

        return View(null);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(EditTagRequest editTagRequest)
    {
        var tag = new Tag
        {
            Id = editTagRequest.Id,
            Name = editTagRequest.Name,
            DisplayName = editTagRequest.DisplayName
        };
        var updateTag = await tagRepository.UpdateAsync(tag);
        if (updateTag != null)
        {
            //SHOW SUCCES NOTIFICATION
        }
        else
        {
            //SHOW ERROR NOTIFICATION
        }
        return RedirectToAction("Edit", new { id = editTagRequest.Id });
    }

    [HttpPost]
    public async Task<IActionResult> Delete(EditTagRequest editTagRequest)
    {
        var tag = await bloggieDbContext.Tags.FindAsync(editTagRequest.Id);
        if (tag != null)
        {
            bloggieDbContext.Tags.Remove(tag);
            await bloggieDbContext.SaveChangesAsync();
            return RedirectToAction("List");
        }

        return RedirectToAction("Edit", new { id = editTagRequest.Id });
    }

}