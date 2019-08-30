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
                BLCard<ETCardActor>.GetDifference(cardActors, CRUD<ETCardActor>.All)
                    .ForEach(i =>
                    {
                        if (i.Id.HasValue)
                            CRUD<ETCardActor>.DeletePhysical(i);
                        else
                            CRUD<ETCardActor>.Add(i);
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
