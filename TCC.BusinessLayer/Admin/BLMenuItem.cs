using System;
using System.Collections.Generic;
using System.Linq;
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

        #region Salvar

        public static bool Save(ETMenuItem menuItem)
        {
            try
            {
                CRUD<ETMenuItem>.AddOrUpdate(menuItem);
                BLMenuParent.Save(menuItem.Id);
                
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Obter pela Chave

        public static ETMenuItem GetByKey(string key)
        {
            return CRUD<ETMenuItem>.Find(i => i.Key == key);
        }

        internal static object GetByKey()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
