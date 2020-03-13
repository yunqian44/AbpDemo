using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Czar.AbpDemo.Web.Pages
{
    public class IndexModel : AbpDemoPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}