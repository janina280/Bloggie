using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bloggie.Web.Models.ViewModels;

public class EditBlogPostRequest
{
    public Guid Id { get; set; }
    public required string Heading { get; set; }
    public required string PageTitle { get; set; }
    public required string Content { get; set; }
    public required string ShortDescription { get; set; }
    public required string FeaturedImageUrl { get; set; }
    public required string UrlHandle { get; set; }
    public required string Author { get; set; }
    public bool Visible { get; set; }
    public DateTime PublishedDate { get; set; }

    public required IEnumerable<SelectListItem> Tags { get; set; }
    public string[] SelectedTags { get; set; } = Array.Empty<string>();
}