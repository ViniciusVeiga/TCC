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
    public class BLMenuItem
    {
        #region Listar

        public static List<ETMenuItem> GetList(decimal id)
        {
            return CRUD<ETMenuItem>.FindAll(m => m.IdMenu == id && m.Active == true);
        }

        #endregion

        #region Salvar

        public static bool Save(ETMenuItem menu)
        {
            try
            {
                CRUD<ETMenuItem>.Add(menu);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}
