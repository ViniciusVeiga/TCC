using System;
using System.Collections.Generic;
using TCC.Domain.Entities.Admin;
using TCC.Entity.CRUD;

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

        #region Save

        public static bool Save(ETMenuItem menuItem)
        {
            try
            {
                CRUD<ETMenuItem>.AddOrUpdate(menuItem);
                BLMenuParent.Save(menuItem.IdParents, menuItem.Id);
                
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
