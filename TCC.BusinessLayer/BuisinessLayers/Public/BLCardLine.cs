using System;
using System.Collections.Generic;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLCardLine
    {
        #region Salvar

        public static bool Save(List<ETCardLine> cardLines)
        {
            try
            {
                cardLines
                    .ForEach(i => CRUD<ETCardLine>.Add(i));

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
