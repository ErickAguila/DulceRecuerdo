using System.Web;
using System.Web.Optimization;

namespace DulceRecuerdo
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            bundles.Add(new ScriptBundle("~/Content/Home/Index/js").Include(
                    "~/Content/Template/js/bootstrap/popper.min.js",
                    "~/Content/Template/js/bootstrap/bootstrap.min.js",
                    "~/Content/Template/js/jquery/jquery-2.2.4.min.js",
                    "~/Content/Template/js/others/plugins.js",
                    "~/Content/Template/js/active.js"));

            bundles.Add(new StyleBundle("~/Content/Home/Index/css").Include(
                "~/Content/Template/style.css",
                "~/Content/Template/css/responsive/responsive.css"));
        }
    }
}
