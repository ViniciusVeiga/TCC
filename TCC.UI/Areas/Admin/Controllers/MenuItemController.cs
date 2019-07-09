using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TCC.BusinessLayer.Admin;
using TCC.Domain.Entities.Admin;
using TCC.UI.Areas.Admin.ViewsModels.Menu;
using TCC.UI.Extensions;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Attributes.Login;
using TCC.UI.Helpers.Toastrs;

namespace TCC.UI.Areas.Admin.Controllers
{
    [PermissionAdmin]
    public class MenuItemController : AdminBaseController<ETMenuItem, VMMenuItem>
    {
        public static decimal? IdMenu;

        #region Index

        public override ActionResult Index()
        {
            IdMenu = !string.IsNullOrEmpty(Request.Form["id"]) ? Convert.ToDecimal(Request.Form["id"]) : (decimal?)null ?? IdMenu;

            ViewBag.List = HelpersMethods.CopyValues<ETMenuItem, VMMenuItem>(BLMenuItem.GetList(IdMenu));

            return View();
        }

        #endregion

        #region Item

        public override ActionResult Item(decimal? id)
        {
            ViewBag.MenuTypes = BLMenuType.GetList(IdMenu);
            ViewBag.MenuItens = BLMenuItem.GetList(IdMenu);

            return base.Item(id);
        }

        [HttpPost]
        public override ActionResult Item(VMMenuItem model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.IdMenu = IdMenu;

                    BLMenuItem.Save(HelpersMethods.CopyValues<VMMenuItem, ETMenuItem>(model));

                    this.AddToastMessage("Sucesso", "Salvo com sucesso.", ToastrType.Success);
                }
            }
            catch (Exception)
            {
                this.AddToastMessage("Erro", "Erro ao salvar.", ToastrType.Error);
            }

            return RedirectToAction("Index");
        }

        #endregion
    }
}