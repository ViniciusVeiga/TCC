using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLTechnicalTutorial
    {
        #region Obter

        public static ETTechnicalTutorial GetByContent(decimal? idContent)
        {
            return CRUD<ETTechnicalTutorial>.Instance.Find(c => c.IdContent == idContent && c.Active == true);
        }

        #endregion
    }
}
