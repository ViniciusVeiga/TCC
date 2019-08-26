using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC.BusinessLayer.BusinessLayers;
using TCC.Domain.Entities;
using TCC.UI.Areas.Public.Views.ViewsModels;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Attributes.Login;
using TCC.UI.Helpers.Attributes.TutorialDynamic;
using TCC.UI.Helpers.Toastrs;

namespace TCC.UI.Areas.Public.Controllers
{
    [PermissionPublic]
    public class UserStoryController : Controller
    {
        public const string Key = BLConfiguration.Keys.UserStory;
        public static decimal? IdMenuItem = IdMenuItem.GetValueOrDefault((decimal)BLMenuItem.GetByKey(Key).Id);

        #region Etapa 0

        [PermissionTutorialDynamic(Key = Key)]
        public ActionResult Index()
        {
            var model = BLHistoric<ETHistoric>.GetActive();

            return View("Page_0", model);
        }

        #endregion

        #region Etapa 1

        public ActionResult Page_1() => View();

        #endregion

        #region Etapa 2

        public ActionResult Page_2()
        {
            var model = BLCard.GetList(IdMenuItem);

            return View();
        }

        #endregion

        #region Etapa Final

        [CompleteTutorial(Key = Key)]
        public ActionResult Page_3() => View();

        #endregion

        #region Próximo Tutorial

        public ActionResult NextTutorial()
        {
            var id = BLMenuItem.GetByKey(BLConfiguration.Keys.BDD).Id;

            return RedirectToAction("Index", "Content", new { id });
        }

        #endregion

        #region Salvar Historico

        [HttpPost]
        public ActionResult SaveHistoric(ETHistoric model, string page)
        {
            if (BLHistoric<ETHistoric>.Save(model))
            {
                this.AddToastMessage("Sucesso", "Salvo com sucesso", ToastrType.Success);
            }
            else
                this.AddToastMessage("Erro", "Erro ao salvar, favor tentar novamente", ToastrType.Error);

            return View("Page_0", model);
        }

        #endregion
    }
}