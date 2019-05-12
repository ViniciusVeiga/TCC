using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC.BusinessLayer.Admin;
using TCC.Domain.Entities.Admin;
using TCC.Domain.Enums;
using TCC.Entity.CRUD;
using TCC.UI.Areas.Admin.ViewsModels.Content;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Toastrs;

namespace TCC.UI.Areas.Admin.Controllers
{
    public class ContentController : Controller
    {
        #region Index

        public ActionResult Index()
        {
            ViewBag.List = BLContent.GetList();

            return View();
        }

        #endregion

        #region Item]

        public ActionResult Item(decimal? id)
        {
            var model = CRUD<ETContent>.Find(id.GetValueOrDefault(0));

            ViewBag.MenuItens = BLMenuItem.GetList((decimal?)ENMenu.Publico);

            return View(HelpersMethods.CopyValues<ETContent, VMContent>(model));
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Item(VMContent model)
        {
            if (ModelState.IsValid)
            {
                if (BLContent.Save(HelpersMethods.CopyValues<VMContent, ETContent>(model)))
                {
                    this.AddToastMessage("Sucesso", "Conteúdo salvo com sucesso.", ToastrType.Success);
                }
                else
                    this.AddToastMessage("Erro", "Erro ao salvar o conteúdo.", ToastrType.Error);
            }

            return RedirectToAction("Index");
        }

        #endregion
    }
}