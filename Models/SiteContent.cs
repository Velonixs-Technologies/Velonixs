namespace Velonixs.Models;

public sealed record LinkItem(string Text, string Url, string CssClass = "");

public sealed record PageHeroContent(string Title, string Description);

public sealed record HeroContent(
    string Eyebrow,
    string Title,
    string Description,
    IReadOnlyList<LinkItem> Actions,
    IReadOnlyList<StatItem> Stats);

public sealed record StatItem(string Value, string Label);

public sealed record SectionContent(string Title, string Description);

public sealed record CardItem(
    string Title,
    string Description,
    string IconClass = "",
    string Url = "",
    string ColumnClass = "col-md-6 col-lg-4",
    string ArticleClass = "feature-card");

public sealed record TechGroup(string Title, IReadOnlyList<string> Items);

public sealed record CtaContent(string Title, string Description, LinkItem Action);

public sealed record ServiceDetail(
    string Id,
    string Eyebrow,
    string Title,
    string Description,
    IReadOnlyList<DetailList> Lists,
    string VisualTitle,
    string IconClass,
    bool Reverse = false);

public sealed record DetailList(string Title, IReadOnlyList<string> Items);

public sealed record IntroContent(
    string Eyebrow,
    string Title,
    IReadOnlyList<string> Paragraphs,
    string Highlight,
    string ImageUrl,
    string ImageAlt);

public sealed record ProcessStep(string Number, string Title, string Description);

public sealed record ContactMethod(string Title, string PrimaryText, string SecondaryText, string IconClass, string Url = "", bool IsStrong = false);

public sealed record FormOption(string Value, string Text);

public sealed record FaqItem(string Id, string Question, string Answer);

public sealed record HomePageContent(
    HeroContent Hero,
    SectionContent WhyHeading,
    IReadOnlyList<CardItem> WhyCards,
    SectionContent ServicesHeading,
    IReadOnlyList<CardItem> ServiceCards,
    SectionContent TechHeading,
    IReadOnlyList<TechGroup> TechGroups,
    SectionContent IndustriesHeading,
    IReadOnlyList<CardItem> IndustryCards,
    CtaContent Cta);

public sealed record ServicesPageContent(
    PageHeroContent Hero,
    SectionContent OfferHeading,
    IReadOnlyList<CardItem> OfferCards,
    IReadOnlyList<ServiceDetail> ServiceDetails,
    CtaContent Cta);

public sealed record AboutPageContent(
    PageHeroContent Hero,
    IntroContent Intro,
    SectionContent VisionHeading,
    IReadOnlyList<CardItem> VisionCards,
    SectionContent ValuesHeading,
    IReadOnlyList<CardItem> ValueCards,
    SectionContent ProcessHeading,
    IReadOnlyList<ProcessStep> ProcessSteps,
    SectionContent TechHeading,
    IReadOnlyList<TechGroup> TechGroups,
    CtaContent Cta);

public sealed record ContactPageContent(
    PageHeroContent Hero,
    SectionContent ReachHeading,
    IReadOnlyList<ContactMethod> ContactMethods,
    string FormEyebrow,
    string FormTitle,
    string FormDescription,
    IReadOnlyList<CardItem> FormHighlights,
    IReadOnlyList<FormOption> ServiceOptions,
    SectionContent WhyHeading,
    IReadOnlyList<CardItem> WhyCards,
    SectionContent FaqHeading,
    IReadOnlyList<FaqItem> Faqs,
    CtaContent Cta);
