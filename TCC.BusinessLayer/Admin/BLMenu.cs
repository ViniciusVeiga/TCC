using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCC.Domain.Admin.Entities;
using TCC.Domain.Entities.Public.Security;
using TCC.Entity.CRUD;
using static System.Web.HttpContext;

namespace TCC.BusinessLayer.Admin
{
    public class BLMenu
    {
        #region Listar

        public static List<ETMenu> GetList()
        {
            return CRUD<ETMenu>.Actives;
        }

        #endregion

        #region Obter Menu

        public static ETMenu GetMenu(decimal id)
        {
            return CRUD<ETMenu>.Find(id);
        }

        #endregion
    }
}
