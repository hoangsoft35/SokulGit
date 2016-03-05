using System.Web;
using System.Web.Optimization;

namespace Hsp.GenericFramework.Web.Admin
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Libs/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/Libs/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Libs/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Libs/bootstrap.min.js",
                      "~/Scripts/Libs/lodash.js",
                      "~/Scripts/Libs/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/common").Include(
                "~/Scripts/Commons/menu.js",
                "~/Scripts/Libs/alertify.js",
                "~/Scripts/Commons/_layout.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/default/css/bootstrap.min.css",
                      "~/Content/default/css/site.css",
                      "~/Content/default/css/topmenu.css",
                      "~/Content/default/css/customize.css",
                      "~/Content/Libs/alertify.css",
                      "~/Content/default/css/hspmain.css"));

            //Load scripts and styles for MenuItemController
            bundles.Add(new ScriptBundle("~/bundles/scripts/menuItemController").Include(
                "~/Scripts/Libs/bootstrap-treeview.min.js",
                "~/Scripts/Libs/bootstrap-switch.min.js",
                "~/Scripts/Libs/jquery.serializejson.min.js",
                "~/Scripts/Libs/jquery.validate.min.js",
                "~/Scripts/Controllers/MenuItem.js"));
            bundles.Add(new StyleBundle("~/bundles/css/menuItemController").Include(
                "~/Content/Libs/bootstrap-combined.min.css",
                "~/Content/Libs/tree.css",
                "~/Content/Libs/bootstrap-treeview.min.css",
                "~/Content/Libs/bootstrap-switch.min.css"));


        }
    }
}
