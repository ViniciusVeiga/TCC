using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities.Security;

namespace TCC.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        #region Usuário

        public ActionResult NewAccount(ETUser model)
        {
            BLUser.Save(model);

            return View();
        }

        public ActionResult Login()
        {
            //BLUser.Login();

            return View();
        }

        #endregion
    }
}