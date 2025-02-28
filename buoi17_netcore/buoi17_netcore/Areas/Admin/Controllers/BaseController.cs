using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace buoi17_netcore.Areas.Admin.Controllers
{
    public class BaseController : Controller, IActionFilter
    {
        [Area("Admin")]
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.HttpContext.Session.GetString("AdminLogin") == null)
            {
                context.Result = new RedirectToRouteResult(
                    new
                    {
                        Controller = "Login",
                        Action = "Index",
                        Areas = "Admin"
                    });
            }
            base.OnActionExecuted(context);
        }

    }
}
