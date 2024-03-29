﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCC.Domain.Entities.Admin;
using TCC.Domain.Entities.Public.Security;
using TCC.Entity.CRUD;
using static System.Web.HttpContext;

namespace TCC.BusinessLayer.Admin
{
    public class BLMenuItem
    {
        #region Listar

        public static List<ETMenuItem> GetList(decimal? id, bool active = true)
        {
            return CRUD<ETMenuItem>.FindAll(m => m.IdMenu == id && m.Active == active);
        }

        #endregion
    }
}
