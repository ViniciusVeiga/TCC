using System;
using System.Collections.Generic;
using TCC.Domain.Entities.Admin;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.Admin
{
    public class BLContent
    {
        #region Listar

        public static List<ETContent> GetList()
        {
            return CRUD<ETContent>.Actives;
        }

        #endregion

        #region Obter

        public static ETContent GetByMenu(decimal? idMenuItem)
        {
            return CRUD<ETContent>.Find(c => c.IdMenuItem == idMenuItem && c.Active == true);
        }

        #endregion

        #region Salvar

        public static bool Save(ETContent content)
        {
            try
            {
                CRUD<ETContent>.AddOrUpdate(content);

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
