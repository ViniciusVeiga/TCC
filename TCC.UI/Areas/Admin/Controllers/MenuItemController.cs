using System;
using System.Web.Mvc;
using TCC.BusinessLayer.Admin;
using TCC.Domain.Entities.Admin;
using TCC.Entity.CRUD;
using TCC.UI.Areas.Admin.ViewsModels.Menu;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Toastrs;

namespace TCC.UI.Areas.Admin.Controllers
{
    public class MenuItemController : AdminBaseController<ETMenuItem, VMMenuItem>
    {
        public static decimal? IdMenu;

        #region Index

        public override ActionResult Index()
        {
            IdMenu = (decimal?)Convert.ToDecimal(Request.Form["id"]) ?? IdMenu;

            ViewBag.List = BLMenuItem.GetList(IdMenu);

            return View();
        }

        #endregion

        #region Item

        public override ActionResult Item(decimal? id)
        {
            ViewBag.MenuTypes = BLMenuType.GetList(IdMenu);

            return base.Item(id);
        }

        [HttpPost]
        public override ActionResult Item(VMMenuItem model)
        {
            if (ModelState.IsValid)
            {
                var menuItem = HelpersMethods.CopyValues<VMMenuItem, ETMenuItem>(model);
                menuItem.IdMenu = IdMenu;

                return base.Item(model);
            }

            return RedirectToAction("Index");
        }

        #endregion
    }
}