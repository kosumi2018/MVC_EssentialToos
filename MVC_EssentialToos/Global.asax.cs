using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.SqlClient;
using MVC_EssentialToos.Infrastructure;
using Ninject;
using MVC_EssentialToos.App_Start;

namespace MVC_EssentialToos
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            NinjectWebCommon.RegisterServices(new StandardKernel());
        }
    }
}
