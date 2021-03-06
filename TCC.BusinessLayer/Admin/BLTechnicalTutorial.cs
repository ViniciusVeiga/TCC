﻿using TCC.Domain.Entities.Admin;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.Admin
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
