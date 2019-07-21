using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.BusinessLayer.Admin;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities.Admin;
using TCC.Domain.Entities.Public;
using TCC.Domain.Entities.Public.Security;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.Public
{
    public class BLUserPublicMenuItem
    {
        #region Usuário Permissão Tutorial Dinâmico

        /// <summary>
        /// Verifica se o usuário contêm permissão para realizar tutorial dinâmico.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool HasPermissionOfTutorialDynamic(string key)
        {
            try
            {
                var user = BLUser<ETUserPublic>.GetLogged();
                var menuItem = CRUD<ETMenuItem>.Find(m => m.Key == key);

                if (BLMenuParent.HasParent(menuItem.Id))
                {
                    var has = CRUD<ETUserPublicMenuItem>.Find(p => p.IdUserPublic == user.Id && p.IdMenuItem == menuItem.Id);

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

        #endregion

        #region Salvar

        public static void Save(string key)
        {
            try
            {
                var user = BLUser<ETUserPublic>.GetLogged();
                var menuItem = CRUD<ETMenuItem>.Find(m => m.Key == key);

                var model = new ETUserPublicMenuItem(user.Id, menuItem.Id);

                CRUD<ETUserPublicMenuItem>.AddOrUpdate(model);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
