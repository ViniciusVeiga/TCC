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
                return HasPermissionOfTutorialDynamic(key, out List<ETMenuItem> menuItems);
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Verifica se o usuário contêm permissão para realizar tutorial dinâmico e gera a lista de parents restantes.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool HasPermissionOfTutorialDynamic(string key, out List<ETMenuItem> remainingParents)
        {
            try
            {
                remainingParents = new List<ETMenuItem>(); 
                var has = false;
                var menuItem = BLMenuItem.GetByKey(key);

                if (menuItem.Parents != null)
                {
                    foreach (var item in menuItem.Parents)
                    {
                        var historic = GetHistoric(item.Id);
                            
                        if (historic != null)
                            has = true;
                        else
                            remainingParents.Add(CRUD<ETMenuItem>.Find(historic.IdMenuItem.GetValueOrDefault(0)));
                    }
                }

                return has;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Obter Histórico

        private static ETUserPublicMenuItem GetHistoric(decimal? id)
        {
            var user = BLUser<ETUserPublic>.GetLogged();

            return CRUD<ETUserPublicMenuItem>.Find(p => p.IdUserPublic == user.Id && p.IdMenuItem == id);
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
