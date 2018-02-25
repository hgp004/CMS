using CMS.Domain.Repository.EntityForameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.RegistrationByConvention;
using Unity.Lifetime;

namespace CMS.MVC
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
        private void unity()
        {
            UnityContainer container = new UnityContainer();
            
            //container.Resolve(typeof(CMSContext));
            container.RegisterType<CMSContext>(new PerThreadLifetimeManager());
        }
    }
}
