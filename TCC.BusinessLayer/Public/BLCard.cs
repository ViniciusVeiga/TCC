using System;
using System.Collections.Generic;
using TCC.BusinessLayer;
using TCC.Domain.Entities;
using TCC.Domain.Entities.Public.Security;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer
{
    public class BLCard
    {
        #region Salvar

        public static bool Save(List<ETCard> cards, decimal? idMenuItem)
        {
            try
            {
                GetList(idMenuItem)
                    .ForEach(i => CRUD<ETCard>.DeletePhysical(i)); // Deletando os cards antigos

                foreach (var card in cards)
                {
                    BLCardLine.Save(card.CardLines);

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

        public static List<ETCard> GetList(decimal? idMenuItem)
        {
            try
            {
                var user = BLUser<ETUserPublic>.GetLogged();

                return CRUD<ETCard>.FindAll(i => i.IdUserPublic == user.Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
