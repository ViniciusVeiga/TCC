using System;
using System.Collections.Generic;
using System.Linq;
using TCC.Domain.Entities;
using TCC.Entity.CRUD;

namespace TCC.BusinessLayer.BusinessLayers
{
    public static class BLUserProject
    {
        private static ETUserPublic user = BLUser<ETUserPublic>.GetLogged();

        #region Salvar E Retornar Id Selecionado

        public static decimal? SaveAndGetSelectedId(List<ETProject> userProjects)
        {
            try
            {
                Save(userProjects);

                return userProjects.Find(i => i.Selected == true)?.Id;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region Salvar

        public static void Save(List<ETProject> userProjects)
        {
            try
            {
                BLBase<ETProject>.GetDifference(userProjects, CRUD<ETProject>.Instance.All().GetUserProjects())
                    .ForEach(i =>
                    {
                        if (!i.Id.HasValue)
                        {
                            i.IdUserPublic = user.Id;
                            CRUD<ETProject>.Instance.Add(i);
                        }
                        else
                            CRUD<ETProject>.Instance.DeletePhysical(i);
                    });
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Obter Projeto Base

        public static List<ETProject> GetBaseProjects(this List<ETProject> projects) => projects.Where(i => i.IsBaseProject()).ToList();

        #endregion

        #region Obter Projeto Do Usuário

        public static List<ETProject> GetUserProjects(this List<ETProject> projects) => projects.Where(i => !i.IsBaseProject() && i.IdUserPublic == user.Id).ToList();

        #endregion
    }
}
