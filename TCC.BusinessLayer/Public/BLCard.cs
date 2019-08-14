using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities.Public;
using TCC.Domain.Entities.Public.Security;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.Public
{
    public class BLCard
    {
        #region Salvar

        public static bool Save(List<ETCard> cards, decimal? idMenuItem)
        {
            try
            {
                foreach (var card in cards)
                {
                    BLCardLine.Save(card.CardLines);

                    card.IdMenuItem = idMenuItem;
                    CRUD<ETCard>.AddOrUpdate(card);
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Listar

        public static object GetList(decimal? idMenuItem)
        {
            try
            {
                var user = BLUser<ETUserPublic>.GetLogged();

                return CRUD<ETCard>.Find(i => i.IdUserPublic == user.Id && i.IdMenuItem == idMenuItem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
