using System;
using System.Web.Mvc;
using TCC.BusinessLayer.BusinessLayers;
using TCC.Domain.Entities;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Attributes.TutorialDynamic;
using TCC.UI.Helpers.Toastrs;
using TCC.UI.ViewsModels.Account;

namespace TCC.UI.Extensions
{
    public class TutorialDynamicBaseController : Controller
    {
        #region Salvar Historico

        [HttpPost]
        public virtual ActionResult SaveHistoric(ETHistoric model, string page)
        {
            try
            {
                BLHistoric.SaveAllDependencies(model);

                this.AddToastMessage("Sucesso", "Salvo com sucesso", ToastrType.Success);
            }
            catch (Exception)
            {
                this.AddToastMessage("Erro", "Erro ao salvar, favor tentar novamente", ToastrType.Error);
            }

            return View(page, BLHistoric.GetActive());
        }

        #endregion
    }
}