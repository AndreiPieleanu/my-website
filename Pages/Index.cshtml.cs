using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AndreiPieleanuWebsite.Pages
{
    // 0C2B4E 1A3D64 1D546C F4F4F4
    public class IndexModel : PageModel
    {
        public string FullName{get;set;} = "Andrei Pieleanu";
        public string Position{get;set;} = "Sofware Engineer";
        public string MyNavDescription {get;set;} = "I build your customizable, unique software tools. Proprietary software.";
        public string Email {get;set;} = "pieleanuandrei2001@gmail.com";
        public List<Experience> ExperienceList {get;set;} = new List<Experience>();
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
                    "Built, deployed and maintained a proprietary centralized reporting tool which helped ASML engineers manage machine test claims.",
                    "Test claims are important for them to "
                ], [
                    Skill.AspDotNetCore, Skill.CSharp, Skill.k6, Skill.PostgreSQL, Skill.DevOps, Skill.Kubernetes, 
                    Skill.DevOps, Skill.Artifactory, Skill.Rancher, Skill.Grafana
                ], [
                    "https://www.asml.com/en"
                ]),
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
        public Experience(DateOnly startDate, DateOnly endDate, string title, string company, List<string> description, List<Skill> skills, List<string> urls)
        {
            StartDate = startDate;
            EndDate = endDate;
            Title = title;
            Company = company;
            Description = [.. description];
            Skills = [.. skills];
            Urls = [.. urls];
        }
    }
    public enum Skill
    {
        JavaScript, TypeScript, CSharp, Java, React, NextJs, ReactNative, AspDotNetCore, DotNet, HTML, CSS, Python, PostgreSQL, k6, Xamarin, MAUI, Git, GitHub, Azure, DevOps, AWS, gRPC, Kubernetes, RabbitMQ, Kafka, CICD, Razor, Blazor, NuGet, Confluence, Jira, E2E, CPlusPlus, JMeter, Mock, AUTOSAR, ADAS, Artifactory, Docker, Rancher, Grafana
    }
}
