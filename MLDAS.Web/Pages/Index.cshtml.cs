using Microsoft.AspNetCore.Mvc.RazorPages;

using MLDAS.Lib.Platform.Abstractions.Base;
using MLDAS.Lib.Platform.Enums;
using MLDAS.Lib.Platform.Managers;

namespace MLDAS.Web.Pages
{
    public class IndexModel(ILogger<IndexModel> logger, ModuleManager moduleManager) : PageModel
    {
        private readonly ILogger<IndexModel> _logger = logger;

        public IEnumerable<BaseModule> Modules { get; private set; } = moduleManager.GetModulesByCategory(Categories.CyberSecurity);

        public void OnGet()
        {
        }
    }
}