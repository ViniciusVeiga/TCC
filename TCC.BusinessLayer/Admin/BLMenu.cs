using System.Collections.Generic;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;

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
