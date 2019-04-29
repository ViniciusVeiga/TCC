using System.Web.Mvc;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities.Security;
using TCC.UI.ViewsModels.Account;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Attributes.Login;
using TCC.UI.Helpers.Toastrs;

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
                if(BLUser.Autentication(model.Email, model.Password))
                {
                    TempData["SuccessLogin"] = true;
                }
                else
                    this.AddToastMessage("Erro", "Erro ao autenticar, favor tentar novamente", ToastType.Error);

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
                if(BLUser.Create(HelpersMethods.CopyValues<VMNewAccount, ETUser>(model)))
                {
                    TempData["SuccessNewAccount"] = true;

                    this.AddToastMessage("Sucesso", "Conta criada com sucesso, faça o login", ToastType.Success);
                }
                else
                    this.AddToastMessage("Erro", "Erro ao registrar, favor tentar novamente", ToastType.Error);

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
            var url = HelpersMethods.GetLastUrl();

            if (!url.Contains(this.ControllerContext.RouteData.Values["controller"].ToString()))
            {
                UrlToRedirect = HelpersMethods.GetLastUrl();
            }
        }

        #endregion
    }
}