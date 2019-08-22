using System;
using System.Web.Mvc;
using TCC.BusinessLayer;

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
            catch (Exception)
            {
                filterContext.Result = new RedirectResult("../Error/");
            }
        }
    }
}