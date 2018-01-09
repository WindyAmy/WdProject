using Abp.Application.Services;

namespace WdProject
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class WdProjectAppServiceBase : ApplicationService
    {
        protected WdProjectAppServiceBase()
        {
            LocalizationSourceName = WdProjectConsts.LocalizationSourceName;
        }
    }
}