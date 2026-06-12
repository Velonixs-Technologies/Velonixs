using Microsoft.AspNetCore.Mvc.RazorPages;
using Velonixs.Models;
using Velonixs.Services;

namespace Velonixs.Pages;

public sealed class ServicesModel(SiteContentService content) : PageModel
{
    public ServicesPageContent PageContent => content.Services;
}
