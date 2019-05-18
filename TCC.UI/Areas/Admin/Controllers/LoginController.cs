using System.Web.Mvc;
using TCC.Domain.Entities.Admin.Security;
using TCC.UI.Extensions;
using TCC.UI.Helpers.Attributes.Login;
using TCC.UI.ViewsModels.Account;

namespace TCC.UI.Areas.Admin.Controllers
{
    public class LoginController : LoginBaseController<ETUserAdmin, VMLogin, VMNewAccount>
    {
        #region Index

        public ActionResult Index() => View("Index", "_LayoutExternal", null);

        #endregion
    }
}