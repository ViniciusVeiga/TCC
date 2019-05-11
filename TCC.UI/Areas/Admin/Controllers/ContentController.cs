using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC.BusinessLayer.Admin;

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

        #region Item

        [ValidateInput(false)]
        public ActionResult Item()
        {
            if (ModelState.IsValid)
            {

            }

            return RedirectToAction("Index");
        }

        #endregion
    }
}