using Microsoft.AspNetCore.Mvc.RazorPages;
using Velonixs.Models;
using Velonixs.Services;

namespace Velonixs.Pages;

public sealed class AboutModel(SiteContentService content) : PageModel
{
    public AboutPageContent PageContent => content.About;
}
