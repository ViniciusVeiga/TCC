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
    }
}
