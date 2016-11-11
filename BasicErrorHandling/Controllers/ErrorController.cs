using System.Web.Mvc;

namespace BasicErrorHandling.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }
    }
}