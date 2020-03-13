using Volo.Abp.Modularity;

namespace Czar.AbpDemo
{
    [DependsOn(
        typeof(AbpDemoApplicationModule),
        typeof(AbpDemoDomainTestModule)
        )]
    public class AbpDemoApplicationTestModule : AbpModule
    {

    }
}