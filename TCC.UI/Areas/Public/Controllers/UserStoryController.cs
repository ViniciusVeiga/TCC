using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC.UI.Areas.Public.Views.ViewsModels.UserStory;
using TCC.UI.Helpers.Attributes.Login;
using TCC.UI.Helpers.Attributes.TutorialDynamic;

namespace TCC.UI.Areas.Public.Controllers
{
    [PermissionPublic]
    [PermissionTutorialDynamic(Key = "key_user_story")]
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

        [HttpPost]
        [CompleteTutorial(Key = "key_user_story")]
        public ActionResult ThirdStep(VMThirdStep model)
        {
            return null;
        }

        #endregion
    }
}