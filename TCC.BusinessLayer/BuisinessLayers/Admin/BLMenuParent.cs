using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCC.Domain.Entities;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;
using static System.Web.HttpContext;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLMenuParent
    {
        #region Salvar

        public static bool Save(decimal? idMenuItem)
        {
            try
            {
                var oldParents = CRUD<ETMenuParent>.Instance.FindAll(p => p.IdMenuItem == idMenuItem);
                var newParents = Current.Request.Form.GetValues("IdParents")?.Select(p => decimal.Parse(p)).ToList() ?? new List<decimal>();

                CRUD<ETMenuParent>.Instance.DeletePhysical(oldParents);

                foreach (var item in newParents)
                    CRUD<ETMenuParent>.Instance.Add(new ETMenuParent(idMenuItem, item));

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region Obtêm Pai

        /// <summary>
        /// Obtêm pai.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ETMenuItem GetParent(decimal? id)
        {
            try
            {
                var menuItem = CRUD<ETMenuItem>.Instance.Find(i => i.Id == id);

                if (menuItem.Parents.Count > 0)
                    return menuItem;

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
