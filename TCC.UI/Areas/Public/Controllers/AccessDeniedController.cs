﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCC.UI.Areas.Public.Controllers
{
    public class AccessDeniedController : Controller
    {
        public ActionResult Index() => View();
    }
}