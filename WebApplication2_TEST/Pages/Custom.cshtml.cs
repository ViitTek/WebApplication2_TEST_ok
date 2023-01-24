using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2_TEST.Pages
{
    public class CustomModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string Title { get; set; } = "Custom";

        public void OnGet()
        {
        }
    }
}