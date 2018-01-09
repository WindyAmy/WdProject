using Abp.Web.Mvc.Controllers;

namespace WdProject.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class WdProjectControllerBase : AbpController
    {
        protected WdProjectControllerBase()
        {
            LocalizationSourceName = WdProjectConsts.LocalizationSourceName;
        }
    }
}