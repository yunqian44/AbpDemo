using System;
using System.Collections.Generic;
using System.Text;
using Czar.AbpDemo.Localization;
using Volo.Abp.Application.Services;

namespace Czar.AbpDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpDemoAppService : ApplicationService
    {
        protected AbpDemoAppService()
        {
            LocalizationResource = typeof(AbpDemoResource);
        }
    }
}
