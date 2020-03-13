using Czar.AbpDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Czar.AbpDemo.Web.Pages
{
    public abstract class AbpDemoPageModel : AbpPageModel
    {
        protected AbpDemoPageModel()
        {
            LocalizationResourceType = typeof(AbpDemoResource);
        }
    }
}