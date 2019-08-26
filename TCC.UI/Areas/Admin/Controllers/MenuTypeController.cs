using System;
using System.Web.Mvc;
using TCC.BusinessLayer.BusinessLayers;
using TCC.Domain.Entities;
using TCC.UI.Areas.Admin.ViewsModels.Menu;
using TCC.UI.Extensions;
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
            IdMenu = !string.IsNullOrEmpty(Request.Form["id"]) ? Convert.ToDecimal(Request.Form["id"]) : (decimal?)null ?? IdMenu;

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
                model.IdMenu = IdMenu;

                return base.Item(model);
            }

            return RedirectToAction("Index");
        }

        #endregion
    }
}