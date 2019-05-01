using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC.BusinessLayer.Admin;

namespace TCC.UI.Areas.Admin.Controllers
{
    public class MenuItemController : Controller
    {
        #region Index

        [HttpPost]
        public ActionResult Index(decimal id)
        {
            BLMenuItem.GetList(id);

            return PartialView();
        }

        #endregion
    }
}