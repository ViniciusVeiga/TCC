using System.Web.Mvc;
using TCC.BusinessLayer.Admin;
using TCC.Domain.Admin.Entities;
using TCC.Entity.CRUD;
using TCC.UI.Areas.Admin.ViewsModels.Menu;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Toastrs;

namespace TCC.UI.Areas.Admin.Controllers
{
    public class MenuTypeController : Controller
    {
        public static decimal? IdMenu;

        #region Index

        public ActionResult Index(decimal? id)
        {
            IdMenu = id ?? IdMenu;

            ViewBag.List = BLMenuType.GetList(IdMenu);

            return View();
        }

        #endregion

        #region Item

        public ActionResult Item(decimal? id)
        {
            var model = CRUD<ETMenuType>.Find(id.GetValueOrDefault(0));

            return View(HelpersMethods.CopyValues<ETMenuType, VMMenuType>(model));
        }

        [HttpPost]
        public ActionResult Item(VMMenuType model)
        {
            if (ModelState.IsValid)
            {
                var menuType = HelpersMethods.CopyValues<VMMenuType, ETMenuType>(model);
                menuType.IdMenu = IdMenu;

                if (BLMenuType.Save(menuType))
                {
                    this.AddToastMessage("Sucesso", "Tipo menu salvo com sucesso.", ToastrType.Success);
                }
                else
                    this.AddToastMessage("Erro", "Erro ao salvar o tipo menu.", ToastrType.Error);
            }

            return RedirectToAction("Index");
        }

        #endregion
    }
}