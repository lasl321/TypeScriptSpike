using System.Web.Optimization;

namespace TypeScriptSpike
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include("~/Scripts/angular.js"));
        }
    }
}