using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Czar.AbpDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpDemo";
    }
}
