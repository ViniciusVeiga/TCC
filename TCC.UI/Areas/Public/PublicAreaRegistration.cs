using System.Web.Mvc;

namespace TCC.UI.Areas.Learnboard
{
    public class PublicAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Public";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name: "Public_default",
                url: "Public/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TCC.UI.Areas.Public.Controllers" }
            );

            context.MapRoute(
                name: "Learnboard_default",
                url: "Learnboard/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "TCC.UI.Areas.Public.Controllers" }
            );
        }
    }
}