# Velonixs Dynamic Website

This document describes the ASP.NET Core Razor Pages version of the Velonixs website.

## Branch

- Primary branch: `feature/aspnet-razor-pages`
- Framework: ASP.NET Core Razor Pages
- Target framework: `.NET 10`
- Local development tool: Visual Studio 2022 or `dotnet` CLI

## Purpose

The dynamic website keeps the same Velonixs design and content while moving the implementation from standalone HTML files into ASP.NET Core Razor Pages. This gives the project a stronger base for future dynamic features such as server-side contact handling, authentication, database-backed content, admin pages, or CRM integrations.

## Main Files

- `Velonixs.sln` - Visual Studio solution file
- `Velonixs.csproj` - ASP.NET Core project file
- `Program.cs` - Application startup, routing, static files, and legacy URL redirects
- `Pages/Index.cshtml` - Home page
- `Pages/Services.cshtml` - Services page
- `Pages/About.cshtml` - About page
- `Pages/Contact.cshtml` - Contact page with Web3Forms integration
- `Pages/PrivacyPolicy.cshtml` - Privacy policy page
- `Pages/TermsConditions.cshtml` - Terms and conditions page
- `Pages/Shared/_Layout.cshtml` - Shared navigation, footer, metadata, CSS, and scripts
- `Services/SiteContentService.cs` - Centralized website content used by the Razor pages
- `Models/SiteContent.cs` - Content models used by the service
- `wwwroot/assets/css/style.css` - Main website styling
- `wwwroot/assets/js/main.js` - Navigation state, smooth scrolling, and form success handling
- `wwwroot/assets/images/` - Logo and image assets

## Implemented Features

- Same visual design as the static website.
- ASP.NET Core Razor Pages structure with shared layout.
- Centralized reusable content through `SiteContentService`.
- Clean URLs:
  - `/`
  - `/services`
  - `/about`
  - `/contact`
  - `/privacy-policy`
  - `/terms-conditions`
- Legacy static URL redirects:
  - `/index.html` to `/`
  - `/services.html` to `/services`
  - `/about.html` to `/about`
  - `/contact.html` to `/contact`
  - `/privacy-policy.html` to `/privacy-policy`
  - `/terms-conditions.html` to `/terms-conditions`
- Web3Forms contact form integration using the same access key as the static site.
- Home-page redirect after successful enquiry submission.
- Footer with corrected company name, current year, legal links, and LinkedIn profile.

## Run Locally

From the repository root:

```powershell
git switch feature/aspnet-razor-pages
dotnet restore
dotnet run
```

Then open the local URL shown in the terminal, commonly:

```text
https://localhost:5001
```

You can also open `Velonixs.sln` in Visual Studio 2022 and start the project with the run button.

## Contact Form

The dynamic site currently uses Web3Forms from the browser, matching the static site:

```html
https://api.web3forms.com/submit
```

For a more secure future implementation, the Web3Forms access key or email delivery provider can be moved to server-side configuration and handled through a Razor Page `OnPost` method or a dedicated API endpoint.

## Deployment Options

This dynamic version cannot be hosted on GitHub Pages because it requires an ASP.NET Core runtime. Suitable hosting options include:

- Azure App Service
- IIS on Windows Server
- Render, Railway, or similar .NET-capable platforms
- Docker hosting on a VPS or cloud platform

## Best Use Case

Use the dynamic website when Velonixs needs server-side functionality, controlled backend logic, database integration, admin features, authentication, custom enquiry workflows, or future business automation.
