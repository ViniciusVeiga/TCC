using System;
using System.Collections.Generic;
using System.Linq;
using TCC.Domain.Entities;

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
    }
}
