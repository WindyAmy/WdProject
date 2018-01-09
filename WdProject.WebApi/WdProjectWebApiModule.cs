using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace WdProject
{
    [DependsOn(typeof(AbpWebApiModule), typeof(WdProjectApplicationModule))]
    public class WdProjectWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(WdProjectApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
