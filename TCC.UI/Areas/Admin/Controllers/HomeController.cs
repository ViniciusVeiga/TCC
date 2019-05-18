using System.Web.Mvc;
using TCC.UI.Helpers.Attributes.Login;

namespace TCC.UI.Areas.Admin.Controllers
{
    [PermissionAdmin]
    public class HomeController : Controller
    {
        public ActionResult Index() => View("Index", "_Layout", null);
    }
}