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
    public class UserStoryController : Controller
    {
        #region Etapa 1

        [PermissionTutorialDynamic(Key = BLConfiguration.Keys.UserStory)]
        public ActionResult Index() => View("Page_0");

        #endregion

        #region Etapa 2

        public ActionResult Page_1() => View();

        #endregion

        #region Etapa 3

        public ActionResult Page_2() => View();

        [HttpPost]
        [CompleteTutorial(Key = BLConfiguration.Keys.UserStory)]
        public ActionResult SaveUserStory(VMThirdStep model)
        {
            return null;
        }

        #endregion

        #region Etapa Final

        public ActionResult Page_3() => View();

        #endregion

        #region Próximo Tutorial

        public ActionResult NextTutorial()
        {
            var id = BLMenuItem.GetByKey(BLConfiguration.Keys.BDD).Id;

            return RedirectToAction("Index", "Content", new { id });
        }

        #endregion
    }
}