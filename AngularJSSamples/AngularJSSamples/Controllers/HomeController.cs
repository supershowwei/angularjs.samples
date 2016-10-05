using System;
using System.Text;
using System.Threading;
using System.Web.Mvc;

namespace AngularJSSamples.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return this.View();
        }
    }
}