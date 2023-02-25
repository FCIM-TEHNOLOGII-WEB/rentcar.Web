using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Optimization;

namespace rentcar.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
           bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                      "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
<<<<<<< Updated upstream
                       "~/Content/bootstrap.min.js", new CssRewriteUrlTransform()));
=======
                       "~/Scripts/bootstrap.min.js"
                       ));
>>>>>>> Stashed changes

            bundles.Add(new ScriptBundle("~/bundles/font-awesome/css").Include(
                       "~/Content/font-awesome.min.css", new CssRewriteUrlTransform()));
            
            bundles.Add(new ScriptBundle("~/bundles/toaster/css").Include(
                       "~/Vendors/toaster/toaster.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/datatables/css").Include(
                       "~/Vendors/datatables/datatables.min.css", new CssRewriteUrlTransform()));

        }

}

}