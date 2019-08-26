﻿using System.Web.Mvc;
using TCC.BusinessLayer.BusinessLayers;
using TCC.UI.ViewsModels.Account;

namespace TCC.UI.Areas.Public.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => View("Index", "_Layout", null);
    }
}