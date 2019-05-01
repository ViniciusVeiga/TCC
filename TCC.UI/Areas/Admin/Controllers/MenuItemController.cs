using System.Web.Mvc;
using TCC.BusinessLayer.Admin;
using TCC.Domain.Admin.Entities;
using TCC.Entity.CRUD;
using TCC.UI.Areas.Admin.ViewsModels.Menu;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Toastrs;

namespace TCC.UI.Areas.Admin.Controllers
{
    public class MenuItemController : Controller
    {
        #region Index

        [HttpPost]
        public ActionResult Index(decimal id)
        {
            ViewBag.List = BLMenuItem.GetList(id);

            return View();
        }

        #endregion

        #region Item

        public ActionResult Item(decimal? id) => View(CRUD<ETMenuItem>.Find(id.GetValueOrDefault(0)));

        [HttpPost]
        public ActionResult Item(VMMenuItem model)
        {
            if (ModelState.IsValid)
            {
                if (BLMenuItem.Save(HelpersMethods.CopyValues<VMMenuItem, ETMenuItem>(model)))
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