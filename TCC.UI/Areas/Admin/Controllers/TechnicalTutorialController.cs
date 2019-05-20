using System.Web.Mvc;
using TCC.BusinessLayer.Admin;
using TCC.Domain.Entities.Admin;
using TCC.Domain.Enums;
using TCC.UI.Areas.Admin.ViewsModels.TechnicalTutorial;
using TCC.UI.Extensions;
using TCC.UI.Helpers.Attributes.Login;

namespace TCC.UI.Areas.Admin.Controllers
{
    [PermissionAdmin]
    public class TechnicalTutorialController : AdminBaseController<ETTechnicalTutorial, VMTechnicalTutorial>
    {
        #region Item

        public override ActionResult Item(decimal? id)
        {
            ViewBag.Contents = BLAdminBase<ETContent>.GetList();

            return base.Item(id);
        }

        [HttpPost]
        [ValidateInput(false)]
        public override ActionResult Item(VMTechnicalTutorial model)
        {
            return base.Item(model);
        }

        #endregion
    }
}