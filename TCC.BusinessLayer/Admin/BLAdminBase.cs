using System;
using System.Collections.Generic;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer
{
    public class BLAdminBase<T> where T : ETBase 
    {
        #region Listar

        public static List<T> GetList()
        {
            return CRUD<T>.Actives;
        }

        #endregion

        #region Salvar

        public static bool Save(T content)
        {
            try
            {
                CRUD<T>.AddOrUpdate(content);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Excluir

        public static bool Delete(decimal id)
        {
            try
            {
                CRUD<T>.DeletePhysical(CRUD<T>.Find(id));

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
