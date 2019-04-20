using AutoMapper;
using System.Web.Mvc;
using TCC.BusinessLayer.Security;
using TCC.Domain.Entities.Security;
using TCC.UI.ViewsModels.Account;

namespace TCC.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        #region Usuário

        public ActionResult NewAccount(VMNewAccount model)
        {
            if (ModelState.IsValid)
            {
                BLUser.NewUser(Mapper.Map<ETUser>(model));
            }

            return View("Index");
        }

        #endregion
    }
}