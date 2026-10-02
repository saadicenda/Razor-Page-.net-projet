using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TPIntroRazor.Pages
{
    public class IndexModel : PageModel
    {
        public string MessageAccueil { get; set; } = string.Empty;

        public List<string> Modules { get; set; } = new List<string>();

        public void OnGet()
        {
            MessageAccueil = "Bienvenue dans mon application Razor Pages !";

            Modules = new List<string>
            {
                "Introduction à ASP.NET Core",
                "Razor Pages",
                "C# et Code-Behind",
                "Formulaires et HTTP POST",
                "Bootstrap et CSS"
            };
        }
    }
}