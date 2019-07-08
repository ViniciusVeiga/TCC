using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCC.Domain.Entities.Admin;
using TCC.Domain.Entities.Public.Security;
using TCC.Entity.CRUD;
using static System.Web.HttpContext;

namespace TCC.BusinessLayer.Admin
{
    public class BLMenuParent
    {
        #region Save

        public static bool Save(List<decimal?> idParents, decimal? idMenuItem)
        {
            try
            {
                foreach (var item in CRUD<ETMenuParent>.FindAll(p => p.IdMenuItem == idMenuItem))
                    CRUD<ETMenuParent>.DeletePhysical(item);

                foreach (var item in idParents)
                    CRUD<ETMenuParent>.Add(new ETMenuParent(idMenuItem, item));

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
