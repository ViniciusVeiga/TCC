using TCC.Domain.Entities.Admin;
using TCC.UI.Extensions;
using TCC.UI.Helpers.Attributes.Login;

namespace TCC.UI.Areas.Admin.Controllers
{
    [PermissionAdmin]
    public class MenuController : AdminBaseController<ETMenu, ETMenu>
    {

    }
}