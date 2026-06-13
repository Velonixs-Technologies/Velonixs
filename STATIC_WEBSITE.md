# Velonixs Static Website

This document describes the static HTML version of the Velonixs website. This is the version currently suited for GitHub Pages hosting.

## Branch

- Primary branch: `main`
- Hosting target: GitHub Pages
- Custom domain: `velonixs.com`

## Purpose

The static website is a lightweight company website for Velonixs Technologies. It presents the business, services, contact options, privacy policy, and terms and conditions without requiring a server-side runtime.

## Main Files

- `index.html` - Home page
- `services.html` - Services and capabilities
- `about.html` - Company overview, values, process, and technology stack
- `contact.html` - Contact page with Web3Forms enquiry submission
- `privacy-policy.html` - Privacy policy page
- `terms-conditions.html` - Terms and conditions page
- `assets/css/style.css` - Main website styling
- `assets/js/main.js` - Navigation state, smooth scrolling, and form success handling
- `assets/images/Logo.png` - Full logo source
- `assets/images/logo-nav.png` - Navigation/favicon logo
- `CNAME` - GitHub Pages custom domain configuration

## Implemented Features

- Responsive Bootstrap-based layout.
- Custom Velonixs logo in the navigation bar and browser icon.
- Service, about, contact, privacy, and terms pages.
- Footer with corrected company name, current year, quick links, legal links, and LinkedIn profile.
- Web3Forms contact form integration using an access key.
- Home-page redirect after successful enquiry submission.
- Custom domain support through GitHub Pages and `CNAME`.

## Contact Form

The contact form submits to Web3Forms:

```html
https://api.web3forms.com/submit
```

The form uses a hidden `access_key`, subject, redirect URL, and spam-trap checkbox. After a successful submission, users are redirected to the home page with `?submitted=true`, where the JavaScript displays a thank-you message.

## Deployment

The static website can be deployed by pushing the `main` branch to GitHub. GitHub Pages is configured to build from the root of the `main` branch.

Expected GitHub Pages settings:

- Source: Deploy from a branch
- Branch: `main`
- Folder: `/ (root)`
- Custom domain: `velonixs.com`
- HTTPS: Enforced after DNS is valid

## DNS

For GitHub Pages, the apex domain should point to GitHub Pages IP addresses, and `www` should be a CNAME to the GitHub Pages host.

The repository also contains `CNAME`, which should contain:

```text
velonixs.com
```

## Best Use Case

Use the static website when you want simple, low-cost hosting with GitHub Pages and do not need server-side features such as authentication, dashboards, admin content management, database storage, or custom backend form handling.
