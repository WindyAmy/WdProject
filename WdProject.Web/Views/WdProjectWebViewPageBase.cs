using Abp.Web.Mvc.Views;

namespace WdProject.Web.Views
{
    public abstract class WdProjectWebViewPageBase : WdProjectWebViewPageBase<dynamic>
    {

    }

    public abstract class WdProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected WdProjectWebViewPageBase()
        {
            LocalizationSourceName = WdProjectConsts.LocalizationSourceName;
        }
    }
}