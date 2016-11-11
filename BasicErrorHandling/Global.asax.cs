using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BasicErrorHandling
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var raisedException = Server.GetLastError();

            // log error
            // fictious logging call
            // log.logException(raisedException.ToString());

            // redirect to error page
            Server.ClearError();
            Response.Redirect("/Error");
        }
    }
}
