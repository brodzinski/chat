﻿using System.Web.Optimization;

namespace Chat.FE.Web.App_Start
{
    public static class BundlesConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.*",
                "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/Scripts/Boostrap").Include(
                "~/Scripts/Bootstrap.js"));            

            BundleTable.EnableOptimizations = true;
            
        }
    }
}