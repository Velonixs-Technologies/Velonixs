using Microsoft.AspNetCore.Mvc.RazorPages;
using Velonixs.Models;
using Velonixs.Services;

namespace Velonixs.Pages;

public sealed class IndexModel(SiteContentService content) : PageModel
{
    public HomePageContent PageContent => content.Home;
}
