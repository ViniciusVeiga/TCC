using System.Web.Mvc;
using TCC.BusinessLayer.Security;
using TCC.UI.ViewsModels.Account;

namespace TCC.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => View();
    }
}