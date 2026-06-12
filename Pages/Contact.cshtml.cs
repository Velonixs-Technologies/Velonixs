using Microsoft.AspNetCore.Mvc.RazorPages;
using Velonixs.Models;
using Velonixs.Services;

namespace Velonixs.Pages;

public sealed class ContactModel(SiteContentService content) : PageModel
{
    public ContactPageContent PageContent => content.Contact;
}
