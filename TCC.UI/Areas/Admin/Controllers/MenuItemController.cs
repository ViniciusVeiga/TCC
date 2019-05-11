using System.Web.Mvc;
using TCC.BusinessLayer.Admin;
using TCC.Domain.Entities.Admin;
using TCC.Entity.CRUD;
using TCC.UI.Areas.Admin.ViewsModels.Menu;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Toastrs;

namespace TCC.UI.Areas.Admin.Controllers
{
    public class MenuItemController : Controller
    {
        public static decimal? IdMenu;

        #region Index

        public ActionResult Index(decimal? id)
        {
            IdMenu = id ?? IdMenu;

            ViewBag.List = BLMenuItem.GetList(IdMenu);

            return View();
        }

        #endregion

        #region Item

        public ActionResult Item(decimal? id)
        {
            var model = CRUD<ETMenuItem>.Find(id.GetValueOrDefault(0));

            ViewBag.MenuTypes = BLMenuType.GetList(IdMenu);

            return View(HelpersMethods.CopyValues<ETMenuItem, VMMenuItem>(model));
        }

        [HttpPost]
        public ActionResult Item(VMMenuItem model)
        {
            if (ModelState.IsValid)
            {
                var menuItem = HelpersMethods.CopyValues<VMMenuItem, ETMenuItem>(model);
                menuItem.IdMenu = IdMenu;

                if (BLMenuItem.Save(menuItem))
                {
                    this.AddToastMessage("Sucesso", "Menu salvo com sucesso.", ToastrType.Success);
                }
                else
                    this.AddToastMessage("Erro", "Erro ao salvar o menu.", ToastrType.Error);
            }

            return RedirectToAction("Index");
        }

        #endregion
    }
}