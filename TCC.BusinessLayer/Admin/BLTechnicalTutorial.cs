using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer
{
    public class BLTechnicalTutorial
    {
        #region Obter

        public static ETTechnicalTutorial GetByContent(decimal? idContent)
        {
            return CRUD<ETTechnicalTutorial>.Find(c => c.IdContent == idContent && c.Active == true);
        }

        #endregion
    }
}
