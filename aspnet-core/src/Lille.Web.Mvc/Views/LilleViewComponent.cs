using Abp.AspNetCore.Mvc.ViewComponents;

namespace Lille.Web.Views
{
    public abstract class LilleViewComponent : AbpViewComponent
    {
        protected LilleViewComponent()
        {
            LocalizationSourceName = LilleConsts.LocalizationSourceName;
        }
    }
}
