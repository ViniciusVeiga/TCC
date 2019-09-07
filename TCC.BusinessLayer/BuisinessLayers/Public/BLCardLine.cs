using System;
using System.Collections.Generic;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLCardLine<T>
        where T : ETCardLine
    {
        #region Salvar

        public static bool Save(List<T> cardLines, decimal? idCard)
        {
            try
            {
                cardLines
                    .ForEach(i =>
                    {
                        i.IdCard = idCard;
                        CRUD<T>.Add(i);
                    });

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion
    }
}
