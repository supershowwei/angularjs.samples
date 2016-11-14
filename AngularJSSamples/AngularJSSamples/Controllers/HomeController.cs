using System.Net;
using System.Web.Mvc;
using AngularJSSamples.ViewModels;

namespace AngularJSSamples.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            this.ViewBag.User =
                new
                    {
                        Id = 1,
                        Modified = new UserModifiedViewModel { FirstName = "Johnny", LastName = "Chuang", Age = 28 }
                    };

            return this.View();
        }

        public ActionResult Save(UserModifiedViewModel userModified)
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}