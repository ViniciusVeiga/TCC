using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC.BusinessLayer.Admin;

namespace TCC.UI.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public ActionResult Index(decimal? id) => View(BLContent.GetByMenu(id));
    }
}