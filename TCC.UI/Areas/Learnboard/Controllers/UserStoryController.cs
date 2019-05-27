using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC.BusinessLayer.Admin;
using TCC.UI.Helpers.Attributes.Login;

namespace TCC.UI.Areas.Learnboard.Controllers
{
    [PermissionPublic]
    public class UserStoryController : Controller
    {
        #region Etapa 1

        public ActionResult Index() => View("FirstStep");

        #endregion

        #region Etapa 2

        public ActionResult SecondStep() => View();

        #endregion

        #region Etapa 3

        public ActionResult ThirdStep() => View();

        #endregion
    }
}