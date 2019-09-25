using System;
using System.Collections.Generic;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLMenuType
    {
        #region Listar

        public static List<ETMenuType> GetList(decimal? id, bool active = true)
        {
            return CRUD<ETMenuType>.Instance.FindAll(m => m.IdMenu == id && m.Active == active);
        }

        #endregion
    }
}
