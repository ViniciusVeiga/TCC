using System;
using System.Collections.Generic;
using System.Linq;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLBase<T> where T : ETBase 
    {
        #region Listar

        public static List<T> GetList()
        {
            return CRUD<T>.Instance.Actives();
        }

        #endregion

        #region Salvar

        public static bool Save(T content)
        {
            try
            {
                CRUD<T>.Instance.AddOrUpdate(content);

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
                CRUD<T>.Instance.DeletePhysical(CRUD<T>.Instance.Find(id));

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Obter Diferença

        public static List<T> GetDifference(List<T> news, List<T> olds)
        {
            var list = new List<T>();
            var compare = new BLClassCompare<T>();

            list.AddRange(news.Except(olds, compare));
            list.AddRange(olds.Except(news, compare));

            return list;
        }

        #endregion
    }
}
