﻿using System;
using System.Web.Mvc;
using TCC.BusinessLayer.BusinessLayers;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Toastrs;

namespace TCC.UI.Extensions
{
    public class AdminBaseController<ET, VM> : Controller where ET : ETBase
    {
        #region Index

        public virtual ActionResult Index()
        {
            ViewBag.List = HelpersMethods.CopyValues<ET, VM>(BLBase<ET>.GetList());

            return View();
        }

        #endregion

        #region Item

        public virtual ActionResult Item(decimal? id)
        {
            var model = CRUD<ET>.Instance.Find(id.GetValueOrDefault(0));

            return View(HelpersMethods.CopyValues<ET, VM>(model));
        }

        [HttpPost]
        public virtual ActionResult Item(VM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    BLBase<ET>.Save(HelpersMethods.CopyValues<VM, ET>(model));

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

        #region Excluir

        public virtual ActionResult Delete(decimal id)
        {
            try
            {
                BLBase<ET>.Delete(id);

                this.AddToastMessage("Sucesso", "Deletado com sucesso.", ToastrType.Success);
            }
            catch (Exception)
            {
                this.AddToastMessage("Erro", "Erro ao deletar.", ToastrType.Error);
            }

            return RedirectToAction("Index");
        }

        #endregion
    }
}