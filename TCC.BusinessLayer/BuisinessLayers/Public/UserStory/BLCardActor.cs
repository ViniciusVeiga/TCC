using System;
using System.Collections.Generic;
using System.Linq;
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
                BLCard<ETCardActor>.GetDifference(cardActors, CRUD<ETCardActor>.All)
                    .ForEach(i =>
                    {
                        if (!i.Id.HasValue)
                        {
                            CRUD<ETCardActor>.Add(i);

                            BLCardLine<ETCardLineActor>.Save(i.CardLines.Cast<ETCardLineActor>().ToList());
                        }
                        else
                            CRUD<ETCardActor>.DeletePhysical(i);
                    });
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
