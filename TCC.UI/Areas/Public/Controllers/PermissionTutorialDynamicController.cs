using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC.Domain.Entities.Admin;

namespace TCC.UI.Areas.Public.Controllers
{
    public class PermissionTutorialDynamicController : Controller
    {
        public ActionResult Index(string key)
        {
            var model = BLUserPublicMenuItem.FindRemainingParents(key);

            return View(model);
        }
    }
}