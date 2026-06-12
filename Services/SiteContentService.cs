using Velonixs.Models;

namespace Velonixs.Services;

public sealed class SiteContentService
{
    public IReadOnlyList<LinkItem> NavigationLinks { get; } = new[]
    {
        new LinkItem("Home", "/"),
        new LinkItem("Services", "/services"),
        new LinkItem("About Us", "/about"),
        new LinkItem("Contact", "/contact")
    };

    public IReadOnlyList<LinkItem> FooterQuickLinks { get; } = new[]
    {
        new LinkItem("Home", "/"),
        new LinkItem("Services", "/services"),
        new LinkItem("About Us", "/about"),
        new LinkItem("Contact", "/contact")
    };

    public IReadOnlyList<LinkItem> FooterServiceLinks { get; } = new[]
    {
        new LinkItem("Custom Software", "/services#custom-software"),
        new LinkItem("Web Applications", "/services#web-apps"),
        new LinkItem("Cloud Solutions", "/services#cloud"),
        new LinkItem("Legacy Modernization", "/services#legacy")
    };

    public HomePageContent Home { get; } = new(
        new HeroContent(
            "Global software delivery",
            "Digital products built for momentum.",
            "Velonixs helps teams design, build, modernize, and scale secure software across custom applications, cloud platforms, and dedicated engineering services.",
            new[]
            {
                new LinkItem("Explore Services", "/services", "btn btn-primary btn-lg"),
                new LinkItem("Start a Project", "/contact", "btn btn-outline-light btn-lg")
            },
            new[]
            {
                new StatItem("7+", "service areas across product, cloud, and teams"),
                new StatItem("24h", "typical response window for new inquiries"),
                new StatItem("Global", "delivery from India for clients worldwide")
            }),
        new SectionContent("Why Choose Velonixs?", "We combine enterprise delivery discipline with the speed and clarity modern software teams need."),
        new[]
        {
            new CardItem("Enterprise Experience", "Architecture-minded delivery for business-critical software, integrations, and internal platforms.", "icon-excellence"),
            new CardItem("Quality First", "Clean engineering practices, security awareness, and pragmatic testing from planning through launch.", "icon-quality"),
            new CardItem("Cost Effective", "Flexible delivery models that help you increase output without overextending your core team.", "icon-value"),
            new CardItem("Partnership Focus", "Long-term thinking, honest tradeoffs, and delivery shaped around your actual business goals.", "icon-partnership"),
            new CardItem("Transparent Communication", "Clear updates, shared priorities, and collaborative feedback loops throughout the engagement.", "icon-communication"),
            new CardItem("Innovation", "Modern technology choices balanced with maintainability, reliability, and operational fit.", "icon-innovation")
        },
        new SectionContent("Our Core Services", "Focused capabilities for companies that need dependable software delivery and scalable engineering support."),
        new[]
        {
            new CardItem("Custom Software Development", "Applications tailored to your workflows, business rules, users, and growth plans.", "icon-code", ArticleClass: "service-card", ColumnClass: "col-md-6 col-xl-4"),
            new CardItem("Web Application Development", "Responsive, secure web platforms with clean UX and robust backend foundations.", "icon-web", ArticleClass: "service-card", ColumnClass: "col-md-6 col-xl-4"),
            new CardItem("Cloud & Azure Solutions", "Cloud architecture, migration, DevOps enablement, monitoring, and cost optimization.", "icon-cloud", ArticleClass: "service-card", ColumnClass: "col-md-6 col-xl-4"),
            new CardItem(".NET Development", "Enterprise-grade .NET applications, APIs, integrations, and modernization initiatives.", "icon-dotnet", ArticleClass: "service-card", ColumnClass: "col-md-6 col-xl-4"),
            new CardItem("Legacy Modernization", "Re-platform, refactor, and improve aging applications while reducing delivery risk.", "icon-modernize", ArticleClass: "service-card", ColumnClass: "col-md-6 col-xl-4"),
            new CardItem("Dedicated Engineering Teams", "Pre-vetted developers and technical specialists who integrate with your team.", "icon-team", ArticleClass: "service-card", ColumnClass: "col-md-6 col-xl-4")
        },
        new SectionContent("Technology Expertise", "Practical modern stacks for applications that need to be fast, secure, observable, and maintainable."),
        new[]
        {
            new TechGroup("Microsoft Technologies", new[] { ".NET 8 & ASP.NET Core", "C# Programming", "Web API Development", "Entity Framework" }),
            new TechGroup("Frontend", new[] { "React & Angular", "TypeScript", "HTML5 & CSS3", "Responsive UI" }),
            new TechGroup("Cloud & DevOps", new[] { "Microsoft Azure", "Docker & Kubernetes", "CI/CD Pipelines", "Infrastructure as Code" }),
            new TechGroup("Data Platforms", new[] { "SQL Server", "PostgreSQL", "MongoDB", "MySQL" })
        },
        new SectionContent("Industries We Serve", "Domain-flexible delivery for operational, customer-facing, and data-heavy systems."),
        new[]
        {
            new CardItem("Manufacturing", "Production planning, inventory management, dashboards, and process automation.", ArticleClass: "value-card"),
            new CardItem("Healthcare", "Patient portals, operational systems, reporting tools, and workflow software.", ArticleClass: "value-card"),
            new CardItem("Education", "Learning platforms, student portals, administration tools, and integrations.", ArticleClass: "value-card"),
            new CardItem("Retail & E-Commerce", "Stores, inventory systems, customer journeys, and sales operations platforms.", ArticleClass: "value-card"),
            new CardItem("Logistics & Supply Chain", "Tracking, fleet management, dispatch workflows, and supply chain automation.", ArticleClass: "value-card"),
            new CardItem("Financial Services", "Secure financial applications, workflow platforms, and reporting systems.", ArticleClass: "value-card")
        },
        new CtaContent(
            "Ready to accelerate your digital journey?",
            "Tell us what you are building, modernizing, or scaling. We will help shape a clear technical path forward.",
            new LinkItem("Get in Touch Today", "/contact", "btn btn-light btn-lg")));

    public ServicesPageContent Services { get; } = new(
        new PageHeroContent("Services That Move Software Forward", "From new products to legacy modernization, Velonixs delivers practical engineering support at every stage."),
        new SectionContent("What We Offer", "End-to-end delivery models for applications, platforms, cloud systems, and technical teams."),
        new[]
        {
            new CardItem("Custom Software", "Purpose-built business systems and workflow platforms.", "icon-code", "#custom-software", ArticleClass: "service-card d-block"),
            new CardItem("Web Applications", "Responsive web platforms, portals, APIs, and dashboards.", "icon-web", "#web-apps", ArticleClass: "service-card d-block"),
            new CardItem(".NET Development", "Enterprise-grade .NET solutions and API development.", "icon-dotnet", "#dotnet", ArticleClass: "service-card d-block"),
            new CardItem("Cloud & Azure", "Cloud migration, DevOps, optimization, and governance.", "icon-cloud", "#cloud", ArticleClass: "service-card d-block"),
            new CardItem("Modernization", "Improve legacy applications without derailing operations.", "icon-modernize", "#legacy", ArticleClass: "service-card d-block"),
            new CardItem("Engineering Teams", "Dedicated developers and staff augmentation support.", "icon-team", "#teams", ArticleClass: "service-card d-block")
        },
        new[]
        {
            new ServiceDetail("custom-software", "Custom software", "Applications tailored to how your business actually works.", "Off-the-shelf software rarely fits unique workflows. We build reliable applications that align with your business processes, users, and growth plans.",
                new[]
                {
                    new DetailList("Capabilities", new[] { "Enterprise software development", "Business process automation", "Workflow management systems", "CRM and ERP solutions" }),
                    new DetailList("Benefits", new[] { "Improved operational efficiency", "Reduced manual effort", "Better business visibility", "Scalable architecture" })
                }, "Business platform engineering", "icon-code"),
            new ServiceDetail("web-apps", "Web applications", "Modern web experiences with dependable backend foundations.", "We design and develop responsive web applications that keep performance, security, accessibility, and maintainability in view.",
                new[]
                {
                    new DetailList("Technologies", new[] { "ASP.NET Core", "Angular & React", "REST APIs", "SQL Server & PostgreSQL" }),
                    new DetailList("Solutions", new[] { "Business portals", "Customer portals", "E-commerce applications", "Enterprise dashboards" })
                }, "Responsive application delivery", "icon-web", true),
            new ServiceDetail("dotnet", ".NET development", "Robust .NET systems for enterprise use cases.", "Whether you need desktop, web, API, or cloud-native applications, our .NET expertise supports reliable delivery.",
                new[]
                {
                    new DetailList("Frameworks", new[] { ".NET 8", "ASP.NET Core", "C# programming", "Entity Framework" }),
                    new DetailList("Application Types", new[] { "Web applications", "Desktop applications", "Cloud-native applications", "Microservices" })
                }, "Enterprise platform engineering", "icon-dotnet"),
            new ServiceDetail("cloud", "Cloud & Azure", "Cloud foundations that scale without waste.", "We help businesses modernize infrastructure, automate delivery, optimize costs, and improve operational reliability.",
                new[]
                {
                    new DetailList("Azure Services", new[] { "Cloud migration strategy", "Architecture design", "Infrastructure automation", "Azure DevOps implementation" }),
                    new DetailList("Outcomes", new[] { "Scalability on demand", "Cost reduction", "Improved reliability", "Stronger observability" })
                }, "Azure architecture and operations", "icon-cloud", true),
            new ServiceDetail("legacy", "Modernization", "Reduce legacy drag while protecting business continuity.", "We modernize aging applications through careful assessment, practical architecture, and phased delivery.",
                new[]
                {
                    new DetailList("Services", new[] { ".NET Framework modernization", "Application re-architecture", "Database modernization", "UI/UX upgrades" }),
                    new DetailList("Why Modernize?", new[] { "Reduce maintenance costs", "Improve system reliability", "Enable faster feature delivery", "Enhance security posture" })
                }, "Legacy transformation roadmap", "icon-modernize"),
            new ServiceDetail("teams", "Dedicated teams", "Add skilled engineering capacity without slowing down.", "Our developers and technical specialists work as an extension of your team across project-based and long-term engagements.",
                new[]
                {
                    new DetailList("Available Resources", new[] { ".NET developers", "Full stack developers", "Azure engineers", "QA and DevOps engineers" }),
                    new DetailList("Engagement Models", new[] { "Dedicated resource", "Dedicated team", "Project-based delivery", "Offshore development center" })
                }, "Team extension and delivery support", "icon-team", true)
        },
        new CtaContent(
            "Ready to get started?",
            "Choose the service that best fits your needs and let us shape a practical delivery plan together.",
            new LinkItem("Contact Our Team", "/contact", "btn btn-light btn-lg")));

    public AboutPageContent About { get; } = new(
        new PageHeroContent("About Velonixs Technology", "Engineering digital excellence through reliable software delivery and long-term technology partnerships."),
        new IntroContent(
            "Who we are",
            "A practical technology partner for modern businesses.",
            new[]
            {
                "Velonixs Technology was founded to bridge business challenges and technology solutions. Organizations need partners who understand software development, business processes, scalability, security, and long-term maintainability.",
                "Our expertise spans enterprise software development, cloud computing, application modernization, DevOps implementation, and dedicated engineering services."
            },
            "Headquartered in India | Serving Clients Globally",
            "/assets/img/hero-dashboard.png",
            "Velonixs software delivery dashboard"),
        new SectionContent("Our Vision & Mission", "Clear principles that shape how we partner, plan, build, and support software."),
        new[]
        {
            new CardItem("Our Vision", "To become a globally trusted technology partner recognized for delivering innovative, scalable, and business-driven software solutions that create lasting value.", ArticleClass: "value-card border-start border-primary border-5", ColumnClass: "col-md-6"),
            new CardItem("Our Mission", "To empower businesses through reliable, secure, and high-quality software solutions that generate measurable business value and accelerate digital transformation.", ArticleClass: "value-card border-start border-primary border-5", ColumnClass: "col-md-6")
        },
        new SectionContent("Our Core Values", "The operating principles behind our engineering and client relationships."),
        new[]
        {
            new CardItem("Excellence", "We strive for technical excellence in every project, with high standards for quality and craft.", "icon-excellence"),
            new CardItem("Integrity", "We build relationships based on transparency, trust, accountability, and responsible delivery.", "icon-trust"),
            new CardItem("Innovation", "We explore modern technologies and practices when they create real client value.", "icon-innovation"),
            new CardItem("Customer Success", "Our success is measured by the outcomes and operating improvements our clients achieve.", "icon-quality"),
            new CardItem("Continuous Learning", "We continuously upgrade our skills to stay useful in a fast-moving technology landscape.", "icon-learning"),
            new CardItem("Partnership", "We focus on long-term relationships and becoming a dependable extension of your team.", "icon-partnership")
        },
        new SectionContent("Our Development Process", "A clear, collaborative approach from discovery through support."),
        new[]
        {
            new ProcessStep("1", "Discovery", "Understand business requirements, goals, users, constraints, and success metrics."),
            new ProcessStep("2", "Planning", "Create the solution approach, delivery roadmap, team plan, and estimates."),
            new ProcessStep("3", "Design", "Shape user experience, technical architecture, integrations, and data flows."),
            new ProcessStep("4", "Development", "Build iteratively with regular checkpoints, demos, and backlog refinement."),
            new ProcessStep("5", "Testing", "Validate functionality, performance, security, accessibility, and release readiness."),
            new ProcessStep("6", "Support", "Provide maintenance, improvements, monitoring, and ongoing optimization.")
        },
        new SectionContent("Our Technology Stack", "Modern tools selected for reliability, developer productivity, and long-term maintainability."),
        new[]
        {
            new TechGroup("Microsoft", new[] { ".NET 8", "ASP.NET Core", "C#", "Entity Framework" }),
            new TechGroup("Frontend", new[] { "React", "Angular", "TypeScript", "Responsive Design" }),
            new TechGroup("Cloud & DevOps", new[] { "Microsoft Azure", "Azure DevOps", "Docker & Kubernetes", "CI/CD pipelines" }),
            new TechGroup("Databases", new[] { "SQL Server", "PostgreSQL", "MongoDB", "MySQL" })
        },
        new CtaContent(
            "Let's build something great together.",
            "Connect with our team to discuss how Velonixs can help transform your business with practical technology solutions.",
            new LinkItem("Get in Touch", "/contact", "btn btn-light btn-lg")));

    public ContactPageContent Contact { get; } = new(
        new PageHeroContent("Get in Touch", "Tell us about your project, team needs, or modernization goals. We will respond with a clear next step."),
        new SectionContent("How to Reach Us", "Multiple ways to connect with our team."),
        new[]
        {
            new ContactMethod("Email", "info@velonixs.com", "We respond within 24 hours.", "icon-email", "mailto:info@velonixs.com"),
            new ContactMethod("Website", "velonixs.com", "Visit for more company information.", "icon-web", "https://velonixs.com"),
            new ContactMethod("Location", "India", "Serving clients globally.", "icon-location", IsStrong: true)
        },
        "Start the conversation",
        "Send us a message.",
        "Share a few details about what you want to build, improve, or staff. We will get back to you shortly.",
        new[]
        {
            new CardItem("Quick Response", "Initial replies are typically sent within 24 hours.", ArticleClass: "value-card", ColumnClass: "col-sm-6"),
            new CardItem("Expert Consultation", "Discuss needs directly with a technical delivery team.", ArticleClass: "value-card", ColumnClass: "col-sm-6")
        },
        new[]
        {
            new FormOption("custom-software", "Custom Software Development"),
            new FormOption("web-applications", "Web Application Development"),
            new FormOption("dotnet", ".NET Development"),
            new FormOption("cloud", "Cloud & Azure Solutions"),
            new FormOption("legacy", "Legacy Application Modernization"),
            new FormOption("dedicated", "Dedicated Developer Hiring"),
            new FormOption("staff-augmentation", "IT Staff Augmentation"),
            new FormOption("other", "Other")
        },
        new SectionContent("Why Contact Velonixs?", "We keep discovery practical, technical, and focused on the next useful decision."),
        new[]
        {
            new CardItem("Quick Response", "We understand urgency and respond quickly to new project inquiries.", "icon-response"),
            new CardItem("Technical Consultation", "Discuss requirements, risks, architecture, and project scope with engineers.", "icon-consultation"),
            new CardItem("Professional Support", "Get clear answers about delivery models, timelines, and team structure.", "icon-support"),
            new CardItem("Customized Solutions", "Every solution is shaped around your specific goals, systems, and users.", "icon-custom"),
            new CardItem("Global Reach", "Though based in India, we serve clients across regions and time zones.", "icon-global"),
            new CardItem("Practical Delivery", "We focus on maintainable systems, measured progress, and clear communication.", "icon-ok")
        },
        new SectionContent("Frequently Asked Questions", "Short answers to common project-start questions."),
        new[]
        {
            new FaqItem("faq1", "What is your typical project timeline?", "Project timelines vary based on complexity and scope. During consultation, we provide realistic estimates tailored to your requirements."),
            new FaqItem("faq2", "Do you offer post-launch support?", "Yes. We provide maintenance, bug fixes, enhancements, monitoring, and optimization after launch."),
            new FaqItem("faq3", "What pricing models do you support?", "We support fixed-price projects, time and material, dedicated team engagements, and staff augmentation models."),
            new FaqItem("faq4", "Can you mobilize resources quickly?", "Yes. We can help assemble dedicated resources for urgent projects after confirming skill requirements and timelines."),
            new FaqItem("faq5", "How do you handle data security?", "We apply secure design practices, access controls, encryption where appropriate, secure APIs, and project-specific security review steps.")
        },
        new CtaContent(
            "Ready to start your project?",
            "Send us a message today and we will help map the next step for your business goals.",
            new LinkItem("Start the Form", "#contactForm", "btn btn-light btn-lg")));
}
