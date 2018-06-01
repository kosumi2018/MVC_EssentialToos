using MVC_EssentialToos.Infrastructure;
using Ninject;
using System.Web.Mvc;

namespace MVC_EssentialToos.App_Start
{
    public class NinjectWebCommon
    {
        public static void RegisterServices(IKernel kernel)
        {
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}