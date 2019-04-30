using System.Web;
using System.Web.Optimization;

namespace TCC.UI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Js

            bundles.Add(new ScriptBundle("~/Js/Base").Include(
                "~/Content/Scripts/jquery-{version}.js",
                "~/Content/Scripts/jquery.validate*",
                "~/Content/Scripts/bootstrap.js",
                "~/Content/Toastr/js/toastr.js",
                "~/Content/Scripts/jquery.unobtrusive-ajax.js"));

            bundles.Add(new ScriptBundle("~/Js/Site").Include(
                "~/Content/Scripts/site.js"));

            bundles.Add(new StyleBundle("~/Js/AdminLTE").Include(
                "~/Content/AdminLTE/js/adminlte.js"));

            bundles.Add(new StyleBundle("~/Js/DataTable").Include(
                "~/Content/Components/datatables.net/js/jquery.dataTables.js"));

            #endregion

            #region Css

            bundles.Add(new StyleBundle("~/Css/AdminLTE").Include(
                "~/Content/AdminLTE/css/AdminLTE.css",
                "~/Content/AdminLTE/css/alt/AdminLTE-bootstrap-social.css",
                "~/Content/AdminLTE/css/skins/_all-skins.css"));

            bundles.Add(new StyleBundle("~/Css/Components").Include(
                "~/Content/Components/bootstrap/dist/css/bootstrap.min.css",
                "~/Content/Components/font-awesome/css/font-awesome.min.css",
                "~/Content/Toastr/css/toastr.css"));

            bundles.Add(new StyleBundle("~/Css/Site").Include(
                "~/Content/site.css"));

            #endregion
        }
    }
}
