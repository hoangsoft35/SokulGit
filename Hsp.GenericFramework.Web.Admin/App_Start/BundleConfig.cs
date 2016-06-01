using System;
using System.Web;
using System.Web.Optimization;

namespace Hsp.GenericFramework.Web.Admin
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();
            AddDefaultIgnorePatterns(bundles.IgnoreList);

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                                  "~/Content/default/js/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/default/plugins/modernizr/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/default/plugins/bootstrap/js/bootstrap.min.js",
                      "~/Content/default/plugins/bootstrap/js/respond.min.js"));

            bundles.Add(new StyleBundle("~/Content/default/css").Include(
                      "~/Content/default/css/bootstrap.css",
                      "~/Content/default/css/font-awesome.min.css",
                      "~/Content/default/css/animate.min.css",
                      "~/Content/default/css/css/vendors/sweetalert.css",
                      "~/Content/default/css/vendors/loading.css",
                      "~/Content/default/css/vendors/chat.css",
                      "~/Content/default/css/bootstrap-select.css",
                      "~/Content/default/css/vendors/calendar-mini.css",
                      "~/Content/default/css/main.css"
                      ));



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

        public static void AddDefaultIgnorePatterns(IgnoreList ignoreList)
        {
            if (ignoreList == null)
                throw new ArgumentNullException("ignoreList");
            ignoreList.Ignore("*.intellisense.js");
            ignoreList.Ignore("*-vsdoc.js");
            ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            //ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
        }
    }
}
