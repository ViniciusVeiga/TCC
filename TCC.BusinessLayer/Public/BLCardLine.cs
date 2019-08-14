using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities.Public;
using TCC.Domain.Entities.Public.Security;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.Public
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
