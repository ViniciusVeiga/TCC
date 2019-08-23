using System.Web.Mvc;
using TCC.BusinessLayer;
using TCC.Domain.Entities;

namespace TCC.UI.Helpers.Attributes.Login
{
    public class PermissionPublic : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var user = BLUser<ETUserPublic>.GetLogged();

            if (user == null)
            {
                filterContext.Result = new RedirectResult("../AccessDenied/");
            }
        }
    }
}