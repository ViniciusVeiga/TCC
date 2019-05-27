using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC.BusinessLayer.Admin;

namespace TCC.UI.Areas.Learnboard.Controllers
{
    public class ContentController : Controller
    {
        public static decimal? IdMenuItem;

        #region Index

        public ActionResult Index(decimal? id)
        {
            IdMenuItem = id ?? IdMenuItem;

            var content = BLContent.GetByMenuItem(IdMenuItem);

            ViewBag.HasTechnicalTutorial = BLContent.HasTechnicalTutorial(content.Id);

            return View(content);
        }

        #endregion
    }
}