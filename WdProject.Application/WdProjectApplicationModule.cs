using System.Reflection;
using Abp.Modules;

namespace WdProject
{
    [DependsOn(typeof(WdProjectCoreModule))]
    public class WdProjectApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
