using System.Collections.Generic;
using System.Web.Mvc;
using TCC.BusinessLayer;
using TCC.Domain.Entities;
using TCC.UI.Helpers.Attributes.Login;
using TCC.UI.Helpers.Attributes.TutorialDynamic;

namespace TCC.UI.Areas.Public.Controllers
{
    [PermissionPublic]
    public class BDDController : Controller
    {
        public const string Key = BLConfiguration.Keys.BDD;
        public static decimal? IdMenuItem = IdMenuItem.GetValueOrDefault((decimal)BLMenuItem.GetByKey(Key).Id);

        #region Etapa 0

        [PermissionTutorialDynamic(Key = Key)]
        public ActionResult Index()
        {
            ViewData["Projects"] = BLAdminBase<ETProject>.GetList();

            return View("Page_0");
        }

        #endregion

        #region Etapa 1

        public ActionResult Page_1()
        {
            List<List<string>> userStorys = new List<List<string>>()
            {
                new List<string>(){"Eu como Desenvolvedor", "Quero aprender C#", "Então devo começar a estudar"},
                new List<string>(){"Eu como Operador do Brasanitas", "Quero digitalizar o documento Status", "Para depois coloca-lo no suporte técnico"},
                new List<string>(){"Eu como Lutador", "Quero ganhar uma luta", "Para isso tenho que treinar e muito"},
                new List<string>(){"Eu como um vendedor", "Gostaria de consultar o estoque de um determinado produto", "Para oferece a um cliente"},
                new List<string>(){"Como um Diretor", "Gostaria de obter o volume de vendas do mês", "Para acompanhar atingimento de metas"},
                new List<string>(){"Eu como um Cliente", "Gostaria de visualizar os planos existentes", "Para decidir qual plano devo comprar"}
            };

           
            ViewData["UserStorys"] = userStorys;

            return View("Page_1");
        }

        #endregion
    }
}