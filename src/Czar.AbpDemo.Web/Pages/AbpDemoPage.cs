using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Czar.AbpDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Czar.AbpDemo.Web.Pages
{
    public abstract class AbpDemoPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<AbpDemoResource> L { get; set; }
    }
}
