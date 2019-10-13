using System.Collections.Generic;
using System.Web.Mvc;
using TCC.BusinessLayer.BusinessLayers;
using TCC.Domain.Entities;
using TCC.UI.Extensions;
using TCC.UI.Helpers.Attributes.Login;
using TCC.UI.Helpers.Attributes.TutorialDynamic;

namespace TCC.UI.Areas.Public.Controllers
{
    [PermissionPublic]
    public class TDDController : TutorialDynamicBaseController, ITutorialDynamicBaseController
    {
        public const string Key = BLConfiguration.Keys.BDD;

        #region Etapa 0

        [PermissionTutorialDynamic(Key = Key)]
        public ActionResult Index()
        {
            var model = BLHistoric.GetActive();

            return View("Page_0", model);
        }

        #endregion

        #region Etapa 1

        public ActionResult Page_1()
        {
            var model = BLHistoric.GetActive();

            return View(model);
        }

        #endregion

        #region Etapa 2

        public ActionResult Page_2()
        {
            var model = BLHistoric.GetActive();

            return View(model);
        }

        #endregion

        #region Etapa Final

        [CompleteTutorial(Key = Key)]
        public ActionResult Page_Final() => View();

        #endregion

        #region Próximo Tutorial

        public ActionResult NextTutorial()
        {
            var id = BLMenuItem.GetByKey(BLConfiguration.Keys.TDD).Id;

            return RedirectToAction("Index", "Content", new { id });
        }

        #endregion

        #region Exportar

        public ActionResult Export()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}