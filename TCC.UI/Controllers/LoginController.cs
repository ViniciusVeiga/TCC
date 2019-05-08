using System.Web.Mvc;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities.Public.Security;
using TCC.UI.ViewsModels.Account;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Attributes.Login;
using TCC.UI.Helpers.Toastrs;

namespace TCC.UI.Controllers
{
    public class LoginController : Controller
    {
        #region Login

        [HttpPost]
        [NotLogged]
        public void Login(VMLogin model)
        {
            if (ModelState.IsValid)
            {
                if (!BLUser.Autentication(model.Email, model.Password))
                {
                    this.AddToastMessage("Erro", "Erro ao autenticar, favor tentar novamente", ToastrType.Error);
                }
            }
        }

        #endregion

        #region Nova Conta

        [HttpPost]
        [NotLogged]
        public void NewAccount(VMNewAccount model)
        {
            if (ModelState.IsValid)
            {
                if (BLUser.Create(HelpersMethods.CopyValues<VMNewAccount, ETUser>(model)))
                {
                    TempData["OpenLogin"] = true;

                    this.AddToastMessage("Sucesso", "Conta criada com sucesso, faça o login", ToastrType.Success);
                }
                else
                    this.AddToastMessage("Erro", "Erro ao registrar, favor tentar novamente", ToastrType.Error);
            }
        }

        #endregion

        #region Sair

        public void Logoff()
        {
            BLUser.Logoff();
        }

        #endregion

        #region Validação Remota

        public JsonResult IsValid(string email, ModelValidationResult result)
        {
            return Json(BLUser.IsValid(email),  JsonRequestBehavior.AllowGet);
        }

        #endregion
    }
}