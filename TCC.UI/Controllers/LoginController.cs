using AutoMapper;
using System.Linq;
using System.Web.Mvc;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities.Security;
using TCC.UI.ViewsModels.Account;

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
                ViewData["SuccessLogin"] = true;
            }
            else
            {
                ViewData["ErrorLogin"] = true;
            }

            return View($"../{LastController}/{LastAction}");
        }

        #endregion

        #region Novo Usuário

        [HttpPost]
        public ActionResult NewAccount(VMNewAccount model)
        {
            if (ModelState.IsValid)
            {
                BLUser.NewUser(Mapper.Map<ETUser>(model));

                ViewData["SuccessNewAccount"] = true;
            }
            else
            {
                ViewData["ErrorNewAccount"] = true;
            }

            return View($"../{LastController}/{LastAction}");
        }

        #endregion

        #region Guardar Controller

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