using TCC.Domain.Entities.Admin;
using TCC.UI.Areas.Admin.ViewsModels.Project;
using TCC.UI.Extensions;
using TCC.UI.Helpers.Attributes.Login;

namespace TCC.UI.Areas.Admin.Controllers
{
    [PermissionAdmin]
    public class ProjectController : AdminBaseController<ETProject, VMProject>
    {

    }
}