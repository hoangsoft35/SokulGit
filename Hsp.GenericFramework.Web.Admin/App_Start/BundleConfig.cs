using System;
using System.Web.Optimization;

namespace Hsp.GenericFramework.Web.Admin
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Allow bundle include min. file
            bundles.IgnoreList.Clear();
            AddDefaultIgnorePatterns(bundles.IgnoreList);

            #region Scripts

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Content/default/js/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Content/default/plugins/modernizr/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Content/default/plugins/bootstrap/js/bootstrap.min.js",
                "~/Content/default/js/jquery.easing.min.js",
                "~/Content/default/plugins/jquery-ui/smoothness/jquery-ui.min.js",
                "~/Content/default/plugins/bootstrap/js/respond.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/layout").Include(
                "~/Content/default/plugins/perfect-scrollbar/perfectscrollbar.min.js",
                "~/Content/default/plugins/viewport/viewportchecker.js",
                "~/Content/default/js/scripts.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/common").Include(
                "~/Content/default/plugins/alertifyjs/alertify.min.js",
                "~/Scripts/Commons/_layout.js"));

            bundles.Add(new ScriptBundle("~/bundles/dashboard").Include(
                "~/Content/default/plugins/sparkline-chart/jquery.sparkline.min.js",
                "~/Content/default/plugins/easypiechart/jquery.easypiechart.min.js",
                "~/Content/default/plugins/morris-chart/js/raphael-min.js",
                "~/Content/default/plugins/morris-chart/js/morris.min.js",
                "~/Content/default/js/eco-dashboard.js"
                ));
            //Load scripts and styles for MenuItemController
            bundles.Add(new ScriptBundle("~/bundles/scripts/menuItemController").Include(
                "~/Scripts/Libs/bootstrap-treeview.min.js",
                "~/Scripts/Libs/bootstrap-switch.min.js",
                "~/Scripts/Libs/jquery.serializejson.min.js",
                "~/Scripts/Libs/jquery.validate.min.js",
                "~/Scripts/Libs/lodash.js",
                "~/Scripts/Controllers/MenuItem.js"));

            #endregion

            #region Styles

            bundles.Add(new StyleBundle("~/Content/default/css").Include(
                "~/Content/default/plugins/bootstrap/css/bootstrap.min.css",
                "~/Content/default/plugins/bootstrap/css/bootstrap-theme.min.css",
                "~/Content/default/fonts/font-awesome/css/font-awesome.css",
                "~/Content/default/css/animate.min.css",
                "~/Content/default/plugins/perfect-scrollbar/perfectscrollbar.css",
                "~/Content/default/plugins/jquery-ui/smoothness/jquery-ui.min.css",
                "~/Content/default/css/style.css",
                "~/Content/default/css/flag.css",
                "~/Content/default/plugins/alertifyjs/css/alertify.core.css",
                "~/Content/default/plugins/alertifyjs/css/alertify.default.css"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/default/css/bootstrap.min.css",
                "~/Content/default/css/site.css",
                "~/Content/default/css/topmenu.css",
                "~/Content/default/css/customize.css",
                "~/Content/Libs/alertify.css",
                "~/Content/default/css/hspmain.css"));

            bundles.Add(new StyleBundle("~/bundles/css/menuItemController").Include(
                "~/Content/Libs/bootstrap-combined.min.css",
                "~/Content/Libs/tree.css",
                "~/Content/Libs/bootstrap-treeview.min.css",
                "~/Content/default/plugins/bootstrap-switch/css/bootstrap3/bootstrap-switch.min.css"));


            #endregion



        }

        public static void AddDefaultIgnorePatterns(IgnoreList ignoreList)
        {
            if (ignoreList == null)
                throw new ArgumentNullException("ignoreList");
            ignoreList.Ignore("*.intellisense.js");
            ignoreList.Ignore("*-vsdoc.js");
            ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            //ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            //ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
        }
    }
}
