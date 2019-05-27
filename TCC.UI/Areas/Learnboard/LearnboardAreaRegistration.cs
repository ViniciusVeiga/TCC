using System.Web.Mvc;

namespace TCC.UI.Areas.Learnboard
{
    public class LearnboardAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Learnboard";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name: "Learnboard_default",
                url: "Learnboard/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TCC.UI.Areas.Learnboard.Controllers" }
            );
        }
    }
}