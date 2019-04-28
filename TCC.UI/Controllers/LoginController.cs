using System.Web.Mvc;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities.Security;
using TCC.UI.ViewsModels.Account;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Attributes.Login;

namespace TCC.UI.Controllers
{
    public class LoginController : Controller
    {
        public static string UrlToRedirect { get; set; }

        #region Login

        [HttpPost]
        [NotLogged]
        public ActionResult Login(VMLogin model)
        {
            if (ModelState.IsValid)
            {
                var token = BLUser.Autentication(model.Email, model.Password);

                ViewData["SuccessLogin"] = true;

                return RedirectToAction(UrlToRedirect);
            }

            ViewData["ErrorLogin"] = true;

            return View(UrlToRedirect);
        }

        #endregion

        #region Nova Conta

        [HttpPost]
        [NotLogged]
        public ActionResult NewAccount(VMNewAccount model)
        {
            if (ModelState.IsValid)
            {
                BLUser.Create(Helper.CopyValues<VMNewAccount, ETUser>(model));

                TempData["SuccessNewAccount"] = true;

                return RedirectToAction(UrlToRedirect);
            }

            ViewData["ErrorNewAccount"] = true;

            return View(UrlToRedirect);
        }

        #endregion

        #region Sair

        public ActionResult Logoff()
        {
            BLUser.Logoff();

            return RedirectToAction($"../Home/Index"); // Quando sair, reseta para a home.
        }

        #endregion

        #region Guardar Url (Before Actions)

        /// <summary>
        /// Guarda a última url (Antes das Actions).
        /// </summary>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var url = Helper.GetLastUrl();

            if (!url.Contains(this.ControllerContext.RouteData.Values["controller"].ToString()))
            {
                UrlToRedirect = Helper.GetLastUrl();
            }
        }

        #endregion
    }
}