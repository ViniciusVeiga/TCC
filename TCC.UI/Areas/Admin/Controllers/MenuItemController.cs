using System;
using System.Web.Mvc;
using TCC.BusinessLayer.Admin;
using TCC.Domain.Entities.Admin;
using TCC.UI.Areas.Admin.ViewsModels.Menu;
using TCC.UI.Extensions;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Attributes.Login;

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
                model.IdMenu = IdMenu;

                return base.Item(model);
            }

            return RedirectToAction("Index");
        }

        #endregion
    }
}