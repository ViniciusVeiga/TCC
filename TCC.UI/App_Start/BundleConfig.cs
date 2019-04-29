using System.Web;
using System.Web.Optimization;

namespace TCC.UI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Js/jquery").Include(
                "~/Content/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/Scripts/validate").Include(
            //            "~/Content/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/Js/site").Include(
                "~/Content/Scripts/site.js"));

            bundles.Add(new ScriptBundle("~/Js/bootstrap").Include(
                "~/Content/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Js/AdminLTE").Include(
                "~/Content/AdminLTE/js/adminlte.js"));

            bundles.Add(new StyleBundle("~/Js/DataTable").Include(
                "~/Content/AdminLTE/js/adminlte.js"));

            bundles.Add(new StyleBundle("~/Css/AdminLTE").Include(
                "~/Content/AdminLTE/css/AdminLTE.css",
                "~/Content/AdminLTE/css/alt/AdminLTE-bootstrap-social.css",
                "~/Content/AdminLTE/css/skins/_all-skins.css"));

            bundles.Add(new StyleBundle("~/Css/Components").Include(
                "~/Content/Components/bootstrap/dist/css/bootstrap.min.css",
                "~/Content/Components/font-awesome/css/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Css/Site").Include(
                "~/Content/site.css"));
        }
    }
}
