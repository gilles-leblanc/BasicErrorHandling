using System;
using System.Text.RegularExpressions;
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
            // get error and clear it 
            var exception = Server.GetLastError();
            Server.ClearError();

            // log error
            // ...

            // redirect to error page
            string message = Regex.Replace(exception.Message, @"\t|\n|\r", ""); // replace newlines which will not work with query string
            Response.Redirect("/Error/?message=" + message);
        }
    }
}
