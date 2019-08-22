using TCC.Domain.Entities;
using TCC.UI.Extensions;
using TCC.UI.Helpers.Attributes.Login;

namespace TCC.UI.Areas.Admin.Controllers
{
    [PermissionAdmin]
    public class MenuController : AdminBaseController<ETMenu, ETMenu>
    {

    }
}