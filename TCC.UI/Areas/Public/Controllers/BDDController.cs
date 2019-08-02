using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC.BusinessLayer.Admin;
using TCC.BusinessLayer.Basic;
using TCC.UI.Areas.Public.Views.ViewsModels.UserStory;
using TCC.UI.Helpers.Attributes.Login;
using TCC.UI.Helpers.Attributes.TutorialDynamic;

namespace TCC.UI.Areas.Public.Controllers
{
    [PermissionPublic]
    public class BDDController : Controller
    {
        #region Etapa 1

        [PermissionTutorialDynamic(Key = BLConfiguration.Keys.BDD)]
        public ActionResult Index() => View("FirstStep");

        #endregion
    }
}