using System;
using System.Collections.Generic;
using TCC.Domain.Entities.Admin;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.Admin
{
    public class BLContent
    {
        #region Obter

        public static ETContent GetByMenu(decimal? idMenuItem)
        {
            return CRUD<ETContent>.Find(c => c.IdMenuItem == idMenuItem && c.Active == true);
        }

        #endregion
    }
}
