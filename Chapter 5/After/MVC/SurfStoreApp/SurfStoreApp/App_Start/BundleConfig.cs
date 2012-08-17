using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SurfStoreApp
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254726
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Js").Include(
                "~/Scripts/bootstrap-alert.js",
                "~/Scripts/jquery-1.7.2.js"
                    ));

            bundles.Add(new StyleBundle("~/Styles/Css").Include(
                "~/Content/Css/bootstrap.css",
                "~/Content/Css/bootstrap-responsive.css"
                    ));

        }
    }
}