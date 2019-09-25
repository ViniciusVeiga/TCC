using System;
using System.Collections.Generic;
using System.Linq;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLCard<T> where T : ETCard
    {
        #region Obter Diferença

        public static List<T> GetDifference(List<T> news, List<T> olds)
        {
            var cards = new List<T>();
            var compare = new BLClassCompare<T>();

            cards.AddRange(news.Except(olds, compare));
            cards.AddRange(olds.Except(news, compare));

            return cards;
        }

        #endregion

        #region Salvar

        public static void Save(List<T> cards)
        {
            try
            {
                if (cards != null && cards.Count > 0)
                {
                    GetDifference(cards, CRUD<T>.Instance.All())
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

        #endregion
    }
}
