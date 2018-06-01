using MVC_EssentialToos.Models;
using System.Web.Mvc;
using Ninject;

namespace MVC_EssentialToos.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;
        private Product[] products = {
           new Product{Name="aaa",Category="Water", Peice=275M },
           new Product{Name="bbb",Category="Water", Peice=48.95M },
           new Product{Name="ccc",Category="Soccer", Peice=19.50M },
           new Product{Name="ddd",Category="Soccer", Peice=34.95M }
        };
        public HomeController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        // GET: Home
        public ActionResult Index()
        {
            //IKernel ninjectKernel = new StandardKernel();
            //ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
            //IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();
            ////IValueCalculator calc = new LinqValueCalculator();
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CalculateProductTotal();
            return View(totalValue);
        }
    }
}