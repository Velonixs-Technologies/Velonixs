# Quick Customization Guide

This guide helps you quickly customize the website to match your preferences.

## 🎨 Branding & Colors

**File:** `assets/css/style.css`

Find and update these color variables at the top:

```css
:root {
  --primary-color: #0056b3;        /* Main blue - Change this */
  --primary-dark: #003d82;          /* Darker shade */
  --primary-light: #0069d9;         /* Lighter shade */
  --secondary-color: #6c757d;       /* Gray - for text */
  --success-color: #28a745;         /* Green - checkmarks */
  --white: #ffffff;
  --dark: #1a1a1a;
  --text-color: #333333;
  --light-bg: #f8f9fa;
}
```

**Examples of color changes:**
- Corporate Blue: `#0066CC`
- Professional Green: `#00A651`
- Tech Orange: `#FF6B35`
- Elegant Purple: `#663399`
- Modern Red: `#E74C3C`

---

## 📝 Text Content Updates

### Update Company Name

**Search for:** `Velonixs` or `Velonixs Technology`
**Replace in ALL files:**
- `index.html` - Navigation, hero, footer
- `services.html` - Navigation, footer
- `about.html` - Navigation, content, footer
- `contact.html` - Navigation, footer
- `assets/css/style.css` - (no changes needed)

### Update Domain Name

**Search for:** `velonixs.com`
**Replace in ALL files:**
- Links in navigation
- Footer links
- Contact section
- Meta tags

### Update Email Address

**Search for:** `info@velonixs.com`
**Replace with:** Your actual email (e.g., `contact@yourcompany.com`)

**Files to update:**
- `index.html` (footer)
- `services.html` (footer)
- `about.html` (footer)
- `contact.html` (footer + contact cards)

---

## 🔗 Update Navigation Links

If you add new pages or change file names:

**In all HTML files, update navbar:**
```html
<a class="nav-link" href="index.html">Home</a>
<a class="nav-link" href="services.html">Services</a>
<a class="nav-link" href="about.html">About Us</a>
<a class="nav-link" href="contact.html">Contact</a>
```

---

## 📄 Page-Specific Customizations

### HOME PAGE (index.html)

#### Hero Section
```html
<h1>Transform Your Ideas Into Digital Excellence</h1>
<p>Global Software Development & IT Services Company</p>
```
**Change to your tagline and description**

#### Why Choose Us Section
Replace with your 6 main differentiators:
```html
<h3>Your Main Benefit</h3>
<p>Explanation of your benefit...</p>
```

#### Footer - All Pages
```html
<a href="mailto:info@velonixs.com">info@velonixs.com</a>
<a href="https://velonixs.com">velonixs.com</a>
```

---

### SERVICES PAGE (services.html)

Each service follows this structure:

```html
<h2>Service Name</h2>
<p>Description of the service...</p>

<h4>Capabilities/Features</h4>
<ul>
  <li>✓ Capability 1</li>
  <li>✓ Capability 2</li>
</ul>

<h4>Benefits</h4>
<ul>
  <li>✓ Benefit 1</li>
  <li>✓ Benefit 2</li>
</ul>
```

**To update services:**
1. Keep 7 service sections (or add/remove as needed)
2. Update titles, descriptions, and features
3. Update icons (emoji characters)
4. Adjust number of items in lists

---

### ABOUT PAGE (about.html)

#### Company Overview
Update this section:
```html
<p>Velonixs Technology was founded with a vision...</p>
```

#### Vision & Mission
Replace the text in these sections:
```html
<h3>Our Vision</h3>
<p>Your vision statement here...</p>

<h3>Our Mission</h3>
<p>Your mission statement here...</p>
```

#### Core Values
Default 5 values provided. To change:

```html
<h3>Value Name</h3>
<p>Explanation of the value...</p>
```

Change emoji, title, and description as needed.

---

### CONTACT PAGE (contact.html)

#### Contact Information Cards
```html
<h3>Email</h3>
<p><a href="mailto:info@velonixs.com">info@velonixs.com</a></p>
<p style="font-size: 0.9rem;">Response time note</p>
```

#### Contact Form Fields
To modify form fields:

```html
<div class="form-group">
  <label for="name">Full Name *</label>
  <input type="text" id="name" name="name" required>
</div>
```

Add new fields by copying this structure.

#### FAQ Section
Update existing FAQs or add new ones:

```html
<h4>Your Question?</h4>
<p>Your answer here...</p>
```

---

## 🖼️ Add Images

### Logo
1. Add logo file to `assets/images/` folder
2. Update navbar in all HTML files:

```html
<a class="navbar-brand" href="index.html">
  <img src="assets/images/logo.png" alt="Velonixs Logo" height="40">
</a>
```

### Hero Images/Icons
1. Add images to `assets/images/`
2. Replace emoji placeholders with image tags:

```html
<!-- Instead of: -->
<div style="font-size: 3rem;">💻</div>

<!-- Use: -->
<img src="assets/images/service-icon.png" alt="Service Icon">
```

### Team Photos
1. Add photos to `assets/images/team/`
2. Update About page with team section

---

## 🎯 Modify Hero Sections

Each page has a hero section. To customize:

**Default:**
```html
<section class="hero">
  <div class="container">
    <h1>Transform Your Ideas Into Digital Excellence</h1>
    <p>Global Software Development & IT Services Company</p>
  </div>
</section>
```

**To change:**
- Update `<h1>` text
- Update `<p>` subtitle
- Modify styling in `style.css` `.hero` section

---

## 📞 Contact Form Integration

### Using Formspree (Easiest)

1. Sign up at https://formspree.io
2. Create form and get ID
3. In `contact.html`, replace form tag:

```html
<!-- Original: -->
<form id="contactForm" class="contact-form">

<!-- Change to: -->
<form action="https://formspree.io/f/YOUR_FORM_ID" method="POST" class="contact-form">
```

### Using Netlify Forms

When deploying to Netlify, change form tag to:
```html
<form name="contact" method="POST" netlify class="contact-form">
```

---

## 🔍 Search & Replace Quick Reference

### Company Name
- From: `Velonixs`
- To: `Your Company Name`
- Files: All HTML files

### Domain
- From: `velonixs.com`
- To: `yourdomain.com`
- Files: All HTML files (footer, meta tags)

### Email
- From: `info@velonixs.com`
- To: `your-email@yourcompany.com`
- Files: All HTML files (footer, contact page)

### Colors
- From: `#0056b3` (primary blue)
- To: Your brand color
- Files: `style.css` (CSS variables)

---

## ✨ Common Customizations

### Change Number of Services
- **Currently:** 7 services displayed
- **To modify:** Delete or add service sections in `services.html`
- **Note:** Keep structure consistent

### Update Technology Stack
In `about.html` and `index.html`:
```html
<h4>Microsoft Technologies</h4>
<ul style="list-style: none; color: #666;">
  <li>✓ .NET 8 Framework</li>
  <!-- Add/remove technologies here -->
</ul>
```

### Change Industries
In `index.html`, update industries section:
```html
<h4>Industry Name</h4>
<p>Brief description of solutions...</p>
```

### Modify Footer
Footer appears on all pages. Update in each file:
- Company description
- Quick links
- Contact information
- Social media links

---

## 🎨 Advanced CSS Customization

### Change Typography
In `style.css`:

```css
body {
  font-family: 'Your Font Name', sans-serif;
  /* Examples:
     'Segoe UI' (current)
     'Arial'
     'Trebuchet MS'
     'Verdana'
  */
}
```

### Modify Button Styles
```css
.btn-primary {
  background-color: var(--primary-color);
  padding: 0.75rem 2rem;
  border-radius: 5px;  /* Change to 25px for pill buttons */
  /* Customize further as needed */
}
```

### Update Box Shadows
```css
--shadow: 0 2px 8px rgba(0, 0, 0, 0.1);
/* Increase values for more dramatic shadows */
```

### Change Border Radius
Search for `border-radius:` and update values:
- `5px` - Subtle corners
- `10px` - Medium rounded
- `20px` - Very rounded
- `50%` - Circles

---

## 📱 Mobile Customization

All responsive breakpoints are in `style.css`:

```css
@media (max-width: 768px) {
  /* Tablet adjustments */
}

@media (max-width: 576px) {
  /* Mobile adjustments */
}
```

To modify mobile layout, update these media queries.

---

## 🚀 Deployment-Specific Customizations

### For Netlify
1. Add `netlify.toml` in root:
```toml
[build]
command = "echo 'ready'"
```

### For Vercel
1. Add `vercel.json` in root:
```json
{
  "buildCommand": "echo 'ready'"
}
```

---

## 🐛 Common Issues & Fixes

### Links showing 404
- **Problem:** File names don't match links
- **Fix:** Ensure all links match actual file names exactly

### Images not showing
- **Problem:** Wrong file path
- **Fix:** Check `assets/images/` folder, verify path is correct

### Styles not applying
- **Problem:** CSS file path incorrect
- **Fix:** Verify `assets/css/style.css` path is correct

### Form not working
- **Problem:** Form endpoint not configured
- **Fix:** Set up Formspree, Netlify Forms, or backend integration

---

## 📋 Customization Checklist

- [ ] Update company name throughout
- [ ] Change primary color theme
- [ ] Update contact email and website
- [ ] Modify hero section text and visuals
- [ ] Update services descriptions
- [ ] Customize About Us content
- [ ] Update team/company information
- [ ] Add your logo
- [ ] Configure contact form
- [ ] Set up analytics
- [ ] Test all pages on mobile
- [ ] Deploy to hosting platform

---

## 💡 Pro Tips

1. **Use Find & Replace** - Most editors have this (Ctrl+H in VS Code)
2. **Keep Backup** - Save original before major changes
3. **Test Changes** - Open in browser after updates
4. **Mobile First** - Always test on mobile devices
5. **Consistent Branding** - Use same colors and fonts throughout
6. **Update Footer** - Keep same across all pages for consistency

---

Need more help? Check the README.md or DEPLOYMENT.md files!
