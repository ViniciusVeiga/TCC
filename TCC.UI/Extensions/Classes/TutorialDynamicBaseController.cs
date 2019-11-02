using System;
using System.Collections.Generic;
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
        public virtual ActionResult SaveHistoric(ETHistoricPlus model)
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

            return View(model.Page, BLHistoric.GetActive());
        }

        #endregion
    }
}