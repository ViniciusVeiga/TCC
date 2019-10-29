using System;
using System.Collections.Generic;
using System.Linq;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLCard<T> where T : ETCard
    {
        #region Salvar

        public static void Save(List<T> cards, decimal? idHistoric)
        {
            try
            {
                if (cards != null && cards.Count > 0)
                {
                    BLBase<T>.GetDifference(cards, GetList(idHistoric))
                        .ForEach(i =>
                        {
                            if (!i.Id.HasValue)
                            {
                                CRUD<T>.Instance.Add(i);
                            }
                            else
                                CRUD<T>.Instance.DeletePhysical(i);
                        });
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static List<T> GetList(decimal? idHistoric)
        {
            return CRUD<T>.Instance.FindAll(i => i.IdHistoric == idHistoric);
        }

        #endregion
    }
}
