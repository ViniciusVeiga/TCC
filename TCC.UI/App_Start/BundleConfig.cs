using System.Web;
using System.Web.Optimization;

namespace TCC.UI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Js

            bundles.Add(new ScriptBundle("~/Scripts/Validate").Include(
                "~/Content/Scripts/jquery.validate.*",
                "~/Content/Scripts/jquery.validate-custom.js"));

            bundles.Add(new ScriptBundle("~/Scripts/iCheck").Include(
                "~/Content/Components/iCheck/icheck.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Prism").Include(
                "~/Content/Prism/js/prism.js"));

            bundles.Add(new ScriptBundle("~/Scripts/CKEditor").Include(
                "~/Content/Components/ckeditor/ckeditor.js",
                "~/Content/Components/ckeditor/plugins/codesnippet/plugin.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Base").Include(
                "~/Content/Scripts/jquery-{version}.js",
                "~/Content/Scripts/bootstrap.js",
                "~/Content/Toastr/js/toastr.js",
                "~/Content/Scripts/jquery.unobtrusive-ajax.js",
                "~/Content/Toastr/js/toastr.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Site").Include(
                "~/Content/Scripts/site.js"));

            bundles.Add(new StyleBundle("~/Scripts/AdminLTE").Include(
                "~/Content/AdminLTE/js/adminlte.js"));

            bundles.Add(new StyleBundle("~/Scripts/DataTable").Include(
                "~/Content/Components/datatables.net/js/jquery.dataTables.js",
                "~/Content/Components/datatables.net-bs/js/dataTables.bootstrap.js"));

            #endregion

            #region Css

            bundles.Add(new StyleBundle("~/Styles/AdminLTE").Include(
                "~/Content/AdminLTE/css/AdminLTE.css",
                "~/Content/AdminLTE/css/alt/AdminLTE-bootstrap-social.css",
                "~/Content/AdminLTE/css/skins/_all-skins.css"));

            bundles.Add(new StyleBundle("~/Styles/Components").Include(
                "~/Content/Components/bootstrap/dist/css/bootstrap.min.css",
                "~/Content/Components/font-awesome/css/font-awesome.min.css",
                "~/Content/Toastr/css/toastr.css"));

            bundles.Add(new StyleBundle("~/Styles/DataTable").Include(
                "~/Content/Components/datatables.net-bs/css/dataTables.bootstrap.css"));

            bundles.Add(new StyleBundle("~/Styles/Site").Include(
                "~/Content/Prism/css/prism.css",
                "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Styles/iCheck").Include(
                "~/Content/Components/iCheck/square/blue.css"));

            #endregion
        }
    }
}
