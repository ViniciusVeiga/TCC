using System.Linq;
using System.Web.Mvc;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities.Security;
using TCC.UI.ViewsModels.Account;
using TCC.UI.Helpers;
using System.Web;
using System;

namespace TCC.UI.Controllers
{
    public class LoginController : Controller
    {
        public static string LastController;
        public static string LastAction;

        #region Login

        [HttpPost]
        public ActionResult Login(VMLogin model)
        {
            if (ModelState.IsValid)
            {
                var token = BLUser.Autentication(model.Email, model.Password);

                var cookie = new HttpCookie("app_cookie") { Expires = DateTime.Now.AddYears(1) };

                cookie.Values.Add("t_user", token);
                Response.Cookies.Add(cookie);

                ViewData["SuccessLogin"] = true;
            }
            else
            {
                ViewData["ErrorLogin"] = true;
            }

            return View($"../{LastController}/{LastAction}");
        }

        #endregion

        #region Criar Nova Conta

        [HttpPost]
        public ActionResult NewAccount(VMNewAccount model)
        {
            if (ModelState.IsValid)
            {
                BLUser.Create(Helper.CopyValues<VMNewAccount, ETUser>(model));

                ViewData["SuccessNewAccount"] = true;
            }
            else
            {
                ViewData["ErrorNewAccount"] = true;
            }

            return View($"../{LastController}/{LastAction}");
        }

        #endregion

        #region Guardar Controller (Before Actions)

        /// <summary>
        /// Guarda a última controller e action (Antes das Actions).
        /// </summary>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var lastController = (Request.UrlReferrer.Segments.Skip(1).Take(1).SingleOrDefault() ?? "Home").Trim('/');
            var thisController = this.ControllerContext.RouteData.Values["controller"].ToString();

            if (lastController != thisController)
            {
                LastController = lastController;
                LastAction = (Request.UrlReferrer.Segments.Skip(2).Take(1).SingleOrDefault() ?? "Index").Trim('/');
            }
        }

        #endregion
    }
}