using System.Web.Mvc;
using TCC.BusinessLayer.Public;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities.Public.Security;

namespace TCC.UI.Helpers.Attributes.TutorialDynamic
{
    public class CompleteTutorial : ActionFilterAttribute
    {
        public string Key { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                BLUserPublicMenuItem.Save(Key);
            }
            catch (System.Exception)
            {
                filterContext.Result = new RedirectResult("../Error/");
            }
        }
    }
}