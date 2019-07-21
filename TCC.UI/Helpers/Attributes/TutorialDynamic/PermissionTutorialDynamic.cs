using System.Web.Mvc;
using TCC.BusinessLayer.Public;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities.Public.Security;

namespace TCC.UI.Helpers.Attributes.TutorialDynamic
{
    public class PermissionTutorialDynamic : ActionFilterAttribute
    {
        public string Key { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var user = BLUser<ETUserPublic>.GetLogged();
            var permission = BLUserPublicMenuItem.HasPermissionOfTutorialDynamic(user.Id, key);

            if (permission == true)
            {
                filterContext.Result = new RedirectResult("../AccessDenied/");
            }
        }
    }
}