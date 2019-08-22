using System.Web.Mvc;
using System.Web.Routing;
using TCC.BusinessLayer.Public;

namespace TCC.UI.Helpers.Attributes.TutorialDynamic
{
    public class PermissionTutorialDynamic : ActionFilterAttribute
    {
        public string Key { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var permission = BLUserPublicMenuItem.HasPermissionOfTutorialDynamic(Key);

            if (!permission)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new
                    {
                        action = "Index",
                        controller = "PermissionTutorialDynamic",
                        key = Key
                    }
                ));
            }
        }
    }
}