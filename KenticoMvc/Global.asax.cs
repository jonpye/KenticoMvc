using Kentico.Web.Mvc;
using System.Web.Mvc;
using System.Web.Routing;

namespace KenticoMvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ApplicationConfig.RegisterFeatures(ApplicationBuilder.Current);

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
