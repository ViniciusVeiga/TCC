using System;
using System.Collections.Generic;
using TCC.BusinessLayer.BusinessLayers;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLHistoric<T>
        where T : ETHistoric
    {
        private static ETUserPublic user = BLUser<ETUserPublic>.GetLogged();

        #region Salvar

        public static void Save(T historic)
        {
            try
            {
                var oldId = GetByProject(historic.IdProject)?.Id;
                historic.Id = oldId;
                historic.IdUserPublic = user.Id;

                InativeOthers(historic.Id);
                CRUD<T>.AddOrUpdate(historic);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Obter Pelo Projeto

        public static ETHistoric GetByProject(decimal? idProject)
        {
            return CRUD<ETHistoric>.Find(i => i.IdUserPublic == user.Id && i.IdProject == idProject);
        }

        #endregion

        #region Obter Ativo

        public static T GetActive()
        {
            return CRUD<T>.Find(i => i.IdUserPublic == user.Id && i.Active == true);
        }

        #endregion

        #region Inativar Outros

        public static void InativeOthers(decimal? newId)
        {
            var otherHistorics = CRUD<T>.FindAll(i => i.IdUserPublic == user.Id && i.Active == true && i.Id != newId);

            otherHistorics.ForEach(i => i.Active = false);

            CRUD<T>.AddOrUpdate(otherHistorics);
        }

        #endregion
    }
}
