using Czar.AbpDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Czar.AbpDemo
{
    [DependsOn(
        typeof(AbpDemoEntityFrameworkCoreTestModule)
        )]
    public class AbpDemoDomainTestModule : AbpModule
    {

    }
}