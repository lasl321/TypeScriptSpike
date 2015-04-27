using System.Web.Optimization;

namespace TypeScriptSpike
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/angular").Include("~/Scripts/angular.js"));
            bundles.Add(new ScriptBundle("~/bundles/application").IncludeDirectory("~/Scripts/Application/", "*.js"));

            bundles.Add(new StyleBundle("~/bundles/bootstrap").Include("~/Content/bootstrap.css"));

            BundleTable.EnableOptimizations = false;
        }
    }
}