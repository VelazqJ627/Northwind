using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;

namespace Connecting_to_a_Database
{
    public class MvcApplication : System.Web.HttpApplication
    {


        protected void Application_Start()
        {
            GlobalConfiguration.Configure(App_Start.WebApiConfig.Register);

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }

   
}
