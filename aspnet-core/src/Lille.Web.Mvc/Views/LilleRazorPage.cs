using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Lille.Web.Views
{
    public abstract class LilleRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LilleRazorPage()
        {
            LocalizationSourceName = LilleConsts.LocalizationSourceName;
        }
    }
}
