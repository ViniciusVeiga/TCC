using System;
using System.Collections.Generic;
using System.Linq;
using TCC.BusinessLayer;
using TCC.Domain.Entities;
using TCC.Domain.Entities.Public.Security;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer
{
    public class BLUserPublicMenuItem
    {
        #region Listar Tutoriais Faltantes

        /// <summary>
        /// Lista tutoriais dinâmicos faltantes.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static List<ETMenuItem> FindRemainingParents(string key)
        {
            try
            {
                var menuItem = BLMenuItem.GetByKey(key);

                return menuItem.Parents
                    .Select(i => CRUD<ETMenuItem>.Find(i.IdMenuParent.GetValueOrDefault(0)))
                    .Where(i => GetHistoric(i.Id) == null)
                    .ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

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

                if (menuItem.Parents.Count > 0)
                {
                    remainingParents = FindRemainingParents(key);

                    if (remainingParents.Count < 0)
                        has = true;
                }
                else
                    has = true;

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
