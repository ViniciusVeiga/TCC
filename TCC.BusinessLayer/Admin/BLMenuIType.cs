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
    public class BLMenuType
    {
        #region Listar

        public static List<ETMenuType> GetList(decimal? id, bool active = true)
        {
            return CRUD<ETMenuType>.FindAll(m => m.IdMenu == id && m.Active == active);
        }

        #endregion

        #region Salvar

        public static bool Save(ETMenuType menu)
        {
            try
            {
                CRUD<ETMenuType>.AddOrUpdate(menu);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
    }
}
