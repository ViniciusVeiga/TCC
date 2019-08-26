using System.Web.Mvc;
using TCC.BusinessLayer.BusinessLayers;
using TCC.Domain.Entities;

namespace TCC.UI.Helpers.Attributes.Login
{
    public class PermissionAdmin : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var user = BLUser<ETUserAdmin>.GetLogged();

            if (user == null)
            {
                filterContext.Result = new RedirectResult("/Admin/Login");
            }
        }
    }
}