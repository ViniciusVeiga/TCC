using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using TCC.BusinessLayer.Admin;

namespace TCC.UI.Areas.Admin.Controllers
{
    public class MenuController : Controller
    {
        #region Index

        public ActionResult Index()
        {
            ViewBag.List = BLMenu.GetList();

            return PartialView();
        }

        #endregion
    }
}