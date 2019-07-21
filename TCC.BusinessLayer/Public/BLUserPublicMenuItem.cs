using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.BusinessLayer.Admin;
using TCC.Domain.Entities.Admin;
using TCC.Domain.Entities.Public;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.Public
{
    public class BLUserPublicMenuItem
    {
        public static bool HasPermissionOfTutorialDynamic(decimal? id, string key)
        {
            try
            {
                var menuItem = CRUD<ETMenuItem>.Find(m => m.Key == key);

                if (BLMenuParent.HasParent(menuItem.Id))
                {
                    var has = CRUD<ETUserPublicMenuItem>.Find(p => p.IdMenuItem == id && p.IdMenuItem == menuItem.Id);

                    if (has != null)
                        return true;
                }
  
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
