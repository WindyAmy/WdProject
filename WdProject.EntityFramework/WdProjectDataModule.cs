using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using WdProject.EntityFramework;

namespace WdProject
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(WdProjectCoreModule))]
    public class WdProjectDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<WdProjectDbContext>(null);
        }
    }
}
