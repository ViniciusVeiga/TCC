using System;
using System.Collections.Generic;
using System.Linq;
using TCC.BusinessLayer.BusinessLayers;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.BusinessLayers
{
    public class BLHistoric
    {
        private static ETUserPublic user = BLUser<ETUserPublic>.GetLogged();

        #region Salvar

        public static void Save(ETHistoric historic)
        {
            try
            {
                var oldHistoric = GetByProject(historic.IdProject);

                if (AbleToSave(historic, oldHistoric))
                {
                    historic.Id = oldHistoric?.Id;
                    historic.IdUserPublic = user.Id;

                    InativeOthers(historic.Id);
                    CRUD<ETHistoric>.Instance.AddOrUpdate(historic);
                }

                BLCard<ETCardActor>.Save(historic.CardActors, historic.Id);
                BLCard<ETCardUserStory>.Save(historic.CardUserStories, historic.Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static bool AbleToSave(ETHistoric historic, ETHistoric oldHistoric) => historic?.Id == null || oldHistoric?.Id != historic?.Id && historic?.IdProject != oldHistoric?.IdProject;

        #endregion

        #region Obter Pelo Projeto

        public static ETHistoric GetByProject(decimal? idProject)
        {
            return CRUDHistoric.Instance.Find(i => i.IdUserPublic == user.Id && i.IdProject == idProject);
        }

        #endregion

        #region Obter Ativo

        public static ETHistoric GetActive()
        {
            return CRUDHistoric.Instance.Find(i => i.IdUserPublic == user.Id && i.Active == true);
        }

        #endregion

        #region Inativar Outros

        public static void InativeOthers(decimal? newId)
        {
            var otherHistorics = CRUDHistoric.Instance.FindAll(i => i.IdUserPublic == user.Id && i.Active == true && i.Id != newId);

            otherHistorics.ForEach(i => i.Active = false);

            CRUD<ETHistoric>.Instance.AddOrUpdate(otherHistorics);
        }

        #endregion

        #region Obter Projetos ou Histórico Do Usuário

        public static List<ETHistoric> GetHistoricsOfUser()
        {
            return CRUDHistoric.Instance.FindAll(i => i.IdUserPublic == user.Id);
        }


        public static List<ETProject> GetProjectsOfUserForBDD()
        {
            return GetHistoricsOfUser()
                .Where(i => i.CardActors.Count > 0 && i.CardUserStories.Count > 0)
                .Select(i => CRUD<ETProject>.Instance.Find(i.IdProject.GetValueOrDefault(0)))
                .ToList(); ;
        }

        #endregion
    }
}
