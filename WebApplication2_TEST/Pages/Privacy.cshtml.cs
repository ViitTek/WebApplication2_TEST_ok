using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2_TEST.Pages
{
    [Authorize]
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public override bool Equals(object? obj)
        {
            return obj is PrivacyModel model &&
                   EqualityComparer<ILogger<PrivacyModel>>.Default.Equals(_logger, model._logger);
        }

        public void OnGet()
        {
        }
    }
}