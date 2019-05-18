using System.Web.Mvc;
using TCC.BusinessLayer.Admin;
using TCC.Domain.Entities.Admin;
using TCC.Domain.Enums;
using TCC.UI.Areas.Admin.ViewsModels.Content;
using TCC.UI.Extensions;
using TCC.UI.Helpers.Attributes.Login;

namespace TCC.UI.Areas.Admin.Controllers
{
    [PermissionAdmin]
    public class ContentController : AdminBaseController<ETContent, VMContent>
    {
        #region Item

        public override ActionResult Item(decimal? id)
        {
            ViewBag.MenuItens = BLMenuItem.GetList((decimal?)ENMenu.Publico);

            return base.Item(id);
        }

        #endregion
    }
}