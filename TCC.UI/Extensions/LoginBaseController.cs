using System.Web.Mvc;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities;
using TCC.UI.Helpers;
using TCC.UI.Helpers.Toastrs;
using TCC.UI.ViewsModels.Account;

namespace TCC.UI.Extensions
{
    public class LoginBaseController<ET, VM1, VM2> : Controller
        where ET : ETUser
        where VM1 : VMLogin
        where VM2 : VMNewAccount
    {
        #region Login

        [HttpPost]
        public virtual void Login(VM1 model)
        {
            if (ModelState.IsValid)
            {
                if (!BLUser<ET>.Autentication(model.Email, model.Password))
                {
                    this.AddToastMessage("Erro", "Erro ao autenticar, favor tentar novamente", ToastrType.Error);
                }
            }
        }

        #endregion

        #region Nova Conta

        [HttpPost]
        public virtual void NewAccount(VM2 model)
        {
            if (ModelState.IsValid)
            {
                if (BLUser<ET>.Create(HelpersMethods.CopyValues<VM2, ET>(model)))
                {
                    this.AddToastMessage("Sucesso", "Conta criada com sucesso", ToastrType.Success);
                }
                else
                    this.AddToastMessage("Erro", "Erro ao registrar, favor tentar novamente", ToastrType.Error);
            }
        }

        #endregion

        #region Sair

        public virtual void Logoff()
        {
            BLUser<ET>.Logoff();
        }

        #endregion

        #region Validação Remota

        public virtual JsonResult IsValid(string email, ModelValidationResult result)
        {
            return Json(BLUser<ET>.IsValid(email), JsonRequestBehavior.AllowGet);
        }

        #endregion
    }
}