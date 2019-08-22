using System.Web.Mvc;
using TCC.BusinessLayer;

namespace TCC.UI.Areas.Public.Controllers
{
    public class PermissionTutorialDynamicController : Controller
    {
        public ActionResult Index(string key)
        {
            var model = BLUserPublicMenuItem.FindRemainingParents(key);

            return View(model);
        }
    }
}