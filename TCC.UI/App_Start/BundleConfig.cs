using System.Web;
using System.Web.Optimization;

namespace TCC.UI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/Scripts/validate").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/Scripts/site").Include(
                        "~/Scripts/site.js"));

            bundles.Add(new ScriptBundle("~/Scripts/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Scripts/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/AdminLTE").Include(
                      "~/Content/AdminLTE/css/AdminLTE.css",
                      "~/Content/AdminLTE/css/alt/AdminLTE-bootstrap-social.css",
                      "~/Content/AdminLTE/css/skins/_all-skins.css"));

            bundles.Add(new StyleBundle("~/Content/Components").Include(
                      "~/Content/Components/bootstrap/dist/css/bootstrap.min.css",
                      "~/Content/Components/font-awesome/css/font-awesome.min.css",
                      "~/Content/Components/jvectormap/jquery-jvectormap.css"));

            bundles.Add(new StyleBundle("~/Content/Site").Include(
                      "~/Content/site.css"));
        }
    }
}
