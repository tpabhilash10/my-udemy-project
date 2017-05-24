using System.Web;
using System.Web.Optimization;

namespace VandanamVillas
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery-1.10.2.min.js",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/jquery.min.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/vvcommon").Include(                    
                      "~/Scripts/owl.carousel.min.js",
                      "~/Scripts/jssor.slider.mini.js",             
                      "~/Scripts/bootstrap-datepicker.min.js",                     
                      "~/Scripts/jquery.parallax-1.1.3.js",
                      "~/Scripts/jquery.easing.js",
                      "~/Scripts/jquery.mousewheel.js",
                      "~/Scripts/demo.js",
                      "~/Scripts/script.js",
                      "~/Scripts/jquery.flexslider.js"

                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/vcss").Include(
                      "~/Content/google.css",
                      "~/Content/bootstrap.min.css",                      
                      "~/Content/font-awesome.min.css",                     
                      "~/Content/cs-select.css",
                      "~/Content/bootstrap-datepicker3.min.css",
                      "~/Content/freepik.hotels.css",
                      "~/Content/vandanam.css",
                      "~/Content/flexslider.css"
                      ));



            
        }
    }
}
