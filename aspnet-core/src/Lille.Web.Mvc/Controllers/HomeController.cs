using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Lille.Controllers;

namespace Lille.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : LilleControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
