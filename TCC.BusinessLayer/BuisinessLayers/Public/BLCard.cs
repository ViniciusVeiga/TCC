using System;
using System.Collections.Generic;
using System.Linq;
using TCC.Domain.Entities;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLCard<T> where T : ETCard
    {
        #region Obter Diferença

        public static List<T> GetDifference(List<T> newCards, List<T> oldCards)
        {
            return newCards.Except(oldCards, new BLClassCompare<T>()).ToList();
        }

        #endregion
    }
}
