using System.Web.Mvc;
using TCC.BusinessLayer;
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
        public ActionResult Index() => View("Page_0");

        #endregion

    }
}