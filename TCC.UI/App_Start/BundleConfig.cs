using System.Web;
using System.Web.Optimization;

namespace TCC.UI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/AdminLTE").Include(
                      "~/Content/AdminLTE/css/AdminLTE.css",
                      "~/Content/AdminLTE/css/alt/AdminLTE-bootstrap-social.css",
                      "~/Content/AdminLTE/css/alt/AdminLTE-fullcalendar.css",
                      "~/Content/AdminLTE/css/alt/AdminLTE-select2.css",
                      "~/Content/AdminLTE/css/alt/AdminLTE-without-plugins.css",
                      "~/Content/AdminLTE/css/skins/_all-skins.css"));

            bundles.Add(new StyleBundle("~/Content/Components").Include(
                      "~/Content/Components/bootstrap/dist/css/bootstrap.min.css",
                      "~/Content/Components/font-awesome/css/font-awesome.min.css",
                      "~/Content/Components/morris.js/morris.css",
                      "~/Content/Components/jvectormap/jquery-jvectormap.css",
                      "~/Content/Components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css",
                      "~/Content/Components/bootstrap-daterangepicker/daterangepicker.css"));
        }
    }
}
