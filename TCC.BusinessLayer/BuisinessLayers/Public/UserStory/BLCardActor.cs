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
                if (cardActors.Count > 0)
                {
                    BLCard<ETCardActor>.GetDifference(cardActors, CRUD<ETCardActor>.Instance.All())
                        .ForEach(i =>
                        {
                            if (!i.Id.HasValue)
                            {
                                CRUD<ETCardActor>.Instance.Add(i);
                            }
                            else
                                CRUD<ETCardActor>.Instance.DeletePhysical(i);
                        });
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion
    }
}
