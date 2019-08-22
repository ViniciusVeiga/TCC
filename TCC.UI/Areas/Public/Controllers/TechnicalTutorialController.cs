using System.Web.Mvc;
using TCC.BusinessLayer;

namespace TCC.UI.Areas.Public.Controllers
{
    public class TechnicalTutorialController : Controller
    {
        public ActionResult Index(decimal? id) => View(BLTechnicalTutorial.GetByContent(id));
    }
}