using System.Reflection;
using Abp.Modules;

namespace WdProject
{
    public class WdProjectCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
