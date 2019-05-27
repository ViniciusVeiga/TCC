using System.Web.Mvc;
using TCC.Domain.Entities.Public.Security;
using TCC.UI.Extensions;
using TCC.UI.Helpers.Attributes.Login;
using TCC.UI.ViewsModels.Account;

namespace TCC.UI.Areas.Learnboard.Controllers
{
    public class LoginController : LoginBaseController<ETUserPublic, VMLogin, VMNewAccount>
    {
        #region Login

        [HttpPost]
        [NotLogged]
        public override void Login(VMLogin model)
        {
            base.Login(model);
        }

        #endregion

        #region Nova Conta

        [HttpPost]
        [NotLogged]
        public override void NewAccount(VMNewAccount model)
        {
            TempData["OpenLogin"] = true;

            base.NewAccount(model);
        }

        #endregion
    }
}