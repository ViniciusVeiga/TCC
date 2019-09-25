using System.Collections.Generic;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLMenu
    {
        #region Listar

        public static List<ETMenu> GetList()
        {
            return CRUD<ETMenu>.Instance.Actives();
        }

        #endregion

        #region Obter Menu

        public static ETMenu GetMenu(decimal id)
        {
            return CRUD<ETMenu>.Instance.Find(id);
        }

        #endregion
    }
}
