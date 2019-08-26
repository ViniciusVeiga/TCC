using System;
using System.Collections.Generic;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLCardActor
    {
        #region Salvar

        public static void Save(List<ETCardActor> cardActors)
        {
            try
            {
                var difference = BLCard<ETCardActor>.GetDifference(cardActors, CRUD<ETCardActor>.All);

                foreach (var card in difference)
                {
                    if (card.Id.HasValue)
                    {
                        CRUD<ETCardActor>.DeleteLogical(card);
                    }
                    else
                        CRUD<ETCardActor>.Add(card);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
