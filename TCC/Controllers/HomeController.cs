﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        #region Usuário

        public ActionResult Novo()
        {
            //BLUser.Save();

            return View();
        }

        public ActionResult Entrar()
        {
            //BLUser.Login();

            return View();
        }

        #endregion
    }
}