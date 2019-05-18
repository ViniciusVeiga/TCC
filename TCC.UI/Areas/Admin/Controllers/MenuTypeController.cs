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
    public class MenuTypeController : AdminBaseController<ETMenuType, VMMenuType>
    {
        public static decimal? IdMenu;

        #region Index

        public override ActionResult Index()
        {
            IdMenu = (decimal?)Convert.ToDecimal(Request.Form["id"]) ?? IdMenu;

            ViewBag.List = BLMenuType.GetList(IdMenu);

            return View();
        }

        #endregion

        #region Item

        [HttpPost]
        public override ActionResult Item(VMMenuType model)
        {
            if (ModelState.IsValid)
            {
                var menuType = HelpersMethods.CopyValues<VMMenuType, ETMenuType>(model);
                menuType.IdMenu = IdMenu;

                return base.Item(model);
            }

            return RedirectToAction("Index");
        }

        #endregion
    }
}