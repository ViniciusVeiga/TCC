using System.Web.Mvc;
using TCC.BusinessLayer.Security;

namespace TCC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {
            BLUser.Save();

            return View();
        }

        #region Usuário

        public ActionResult Novo()
        {
            //BLUser.Save();

            return View();
        }

        public ActionResult Entrar()
        {
            //BLUser.Login();

            return View();
        }

        #endregion
    }
}