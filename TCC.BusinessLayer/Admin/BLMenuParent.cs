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
        #region Salvar

        public static bool Save(decimal? idMenuItem)
        {
            try
            {
                var oldParents = CRUD<ETMenuParent>.FindAll(p => p.IdMenuItem == idMenuItem);
                var newParents = Current.Request.Form.GetValues("IdParents").Select(p => decimal.Parse(p)).ToList();

                foreach (var item in oldParents)
                    CRUD<ETMenuParent>.DeletePhysical(item);

                foreach (var item in newParents)
                    CRUD<ETMenuParent>.Add(new ETMenuParent(idMenuItem, item));

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Existe Pais

        /// <summary>
        /// Verifica se menu contêm pais.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool HasParent(decimal? id)
        {
            try
            {
                var menuItem = CRUD<ETMenuItem>.Find(i => i.Id == id);

                if (menuItem.Parents.Count > 0)
                    return true;

                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
