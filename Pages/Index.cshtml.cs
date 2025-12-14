using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndreiPieleanuWebsite.Pages
{
    // 0C2B4E 1A3D64 1D546C F4F4F4
    public class IndexModel : PageModel
    {
        public string FullName { get; set; } = "Andrei Pieleanu";
        public string Position { get; set; } = "Sofware Engineer";
        public string MyNavDescription { get; set; } = "I build your customizable, unique software tools. Proprietary software.";
        public string Email { get; set; } = "pieleanuandrei2001@gmail.com";
        public List<Experience> ExperienceList { get; set; } = new List<Experience>();
        public List<Project> Projects { get; set; } = new List<Project>();
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ExperienceList =
            [
                new Experience(new DateOnly(2025, 09, 01), DateOnly.MinValue, "Software Engineer", "ASML Holding", [
                    "Builing, deploying and maintianing a proprietary centralized reporting tool which helped ASML engineers manage machine test claims.",
                ], [
                    Skill.AspDotNetCore, Skill.CSharp, Skill.k6, Skill.PostgreSQL, Skill.DevOps, Skill.Kubernetes,
                    Skill.DevOps, Skill.Artifactory, Skill.Rancher, Skill.Grafana
                ], [
                    "https://www.asml.com/en"
                ], []),

                new Experience(new DateOnly(2023, 03, 01), DateOnly.MinValue, "Software Engineer", "CP-Pro Solutions GmbH", [
                    "Builing, deploying and maintianing company's mobile app that helps customers in the construction field manage their inventory stock and work and calculate operational costs."
                ], [
                    Skill.Xamarin, Skill.CSharp, Skill.Java, Skill.DotNet, Skill.MAUI, Skill.Git,
                    Skill.Azure, Skill.CICD
                ], [
                    "https://cp-pro.de/en/", "https://play.google.com/store/apps/details?id=de.cppro.office4.android&hl=en", "https://apps.apple.com/de/app/cp-pro-mobile/id1083623914"
                ], ["Android Store", "Apple Store"]),

                new Experience(new DateOnly(2024, 06, 01), new DateOnly(2025, 06, 01), "DevOps Engineer", "SUE | Cloud Native Solutions", [
                    "Developed a proprietary software tool that allowed the cloud engineers to train their AI models on AWS Cloud cluster."
                ], [
                    Skill.AWS, Skill.Kubernetes, Skill.gRPC, Skill.Grafana, Skill.Java, Skill.RabbitMQ,
                    Skill.Spring, Skill.CICD
                ], [
                    "https://sue.nl/", "https://github.com/AndreiPieleanu/suedataplatform"
                ], ["AWS cloud tool"]),

                new Experience(new DateOnly(2024, 02, 01), new DateOnly(2024, 06, 01), "Full-Stack Engineer", "Canon Production Printing", [
                    "Built an internal website that allowed Canon engineers to generate, customize and manage hardware licenses required for testing Canon's printers."
                ], [
                    Skill.AspDotNetCore, Skill.CSharp, Skill.JavaScript, Skill.HTML, Skill.CSS, Skill.Razor,
                    Skill.NuGet, Skill.MySQL, Skill.Confluence
                ], [
                    "https://cpp.canon/about/corporate-information/worldwide/netherlands/"
                ], []),

                new Experience(new DateOnly(2022, 03, 01), new DateOnly(2024, 02, 01), "Junior Software Engineer", "Continental Automotive Systems", [
                    "I started my work as an intern. I managed to create an auto-pilot tool responsible for analyzing test drives and determining optimal times to enable brakes and ensure safety for the driver.",
                    "After this, I have been promoted to a Junior Engineer. I led a team of engineers in the maintenance and expansion of a proprietary software tool that helps the internal engineers at Continental to visualize car sensors and interactions between them."
                ], [
                    Skill.Python, Skill.Java, Skill.CPlusPlus, Skill.Jira, Skill.E2E, Skill.AUTOSAR,
                    Skill.ADAS, Skill.JMeter, Skill.Mock
                ], [
                    "https://www.continental.com/en/"
                ], []),
            ];

            Projects = [
                new Project("https://github.com/AndreiPieleanu/kwex_frontend", "/images/kwex.png", "KweX Social media app", "KweX is my own social media app! It's the place you are free to post and share your thoughts with others!", ["social media", "100 posts/second"]),
                new Project("https://github.com/AndreiPieleanu/moderator-service", "/images/ai-model.png", "AI model for foul language", "A sole-trained AI-model which is able to detect if you are using foul language in a message.", ["95% accuracy", "English-language", "Over 100.000 foul words and expressions"]),
                new Project("https://github.com/AndreiPieleanu/MyGames/tree/main/Story%20of%20Scrappie", "/images/scrappie.png", "Story of Scrappie", "Java-based 2D video game where you must fight the God-machine to turn back into a boy.", ["6th place nationwide", "singleplayer", "customization"]),
                new Project("https://github.com/AndreiPieleanu/MyGames/tree/main/The%20Sailor", "/images/sailor.jpg", "Warships", "Java-based 2D video game where you progressively upgrade your ship to fight the Spanish Armada on the shores of the Caribbean Sea.", ["modularization", "expansion", "20 players"]),
                new Project("https://github.com/AndreiPieleanu/StyleMe-master-CombinedApps", "/images/styleme.jpg", "StyleMe", "Mobile app which connects customers with barber shops.", ["mobile app", "5 barber shops", "50 customers"]),
            ];
        }
    }
    public class Experience
    {
        public DateOnly StartDate;
        public DateOnly? EndDate;
        public string Title;
        public string Company;
        public List<string> Description;
        public List<Skill> Skills;
        public List<string> Urls;
        public List<string> UrlTexts;
        public Experience(DateOnly startDate, DateOnly endDate, string title, string company, List<string> description, List<Skill> skills, List<string> urls, List<String> urlTexts)
        {
            StartDate = startDate;
            EndDate = endDate;
            Title = title;
            Company = company;
            Description = [.. description];
            Skills = [.. skills];
            Urls = [.. urls];
            UrlTexts = [.. urlTexts];
        }
    }
    public class Project
    {
        public string WebUrl { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Achievements { get; set; }
        public Project(string webUrl, string imageUrl, string title, string description, List<String> achievements)
        {
            WebUrl = webUrl;
            ImageUrl = imageUrl;
            Title = title;
            Description = description;
            Achievements = [.. achievements];
        }
    }

    public enum Skill
    {
        MySQL, JavaScript, TypeScript, CSharp, Java, React, NextJs, ReactNative, AspDotNetCore, DotNet, HTML, CSS, Python, PostgreSQL, k6, Xamarin, MAUI, Git, GitHub, Azure, DevOps, AWS, gRPC, Kubernetes, RabbitMQ, Kafka, CICD, Razor, Blazor, NuGet, Confluence, Jira, E2E, CPlusPlus, JMeter, Mock, AUTOSAR, ADAS, Artifactory, Docker, Rancher, Grafana, Spring
    }
}
