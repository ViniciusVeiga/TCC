using System;
using System.Collections.Generic;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.Admin
{
    public class BLContent
    {
        #region Obter

        public static ETContent GetByMenuItem(decimal? idMenuItem)
        {
            return CRUD<ETContent>.Find(c => c.IdMenuItem == idMenuItem && c.Active == true);
        }

        #endregion

        #region Existe Tutorial Técnico

        public static bool HasTechnicalTutorial(decimal? id)
        {
            try
            {
                var technicalTutorial = CRUD<ETTechnicalTutorial>.Find(t => t.IdContent == id);

                if (technicalTutorial != null)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}
