using Velonixs.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<SiteContentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
    app.UseHttpsRedirection();
}

app.UseStaticFiles();

var legacyRoutes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
{
    ["/index.html"] = "/",
    ["/services.html"] = "/services",
    ["/about.html"] = "/about",
    ["/contact.html"] = "/contact",
    ["/privacy-policy.html"] = "/privacy-policy",
    ["/terms-conditions.html"] = "/terms-conditions"
};

app.Use(async (context, next) =>
{
    var requestPath = context.Request.Path.Value?.TrimEnd('/') ?? string.Empty;

    if (legacyRoutes.TryGetValue(requestPath, out var canonicalPath))
    {
        context.Response.Redirect(canonicalPath + context.Request.QueryString, permanent: true);
        return;
    }

    await next();
});

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
