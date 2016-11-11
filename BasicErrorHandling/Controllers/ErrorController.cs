using System.Web.Mvc;

namespace BasicErrorHandling.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(string message)
        {
            TempData["errorMessage"] = message;
            return View();
        }
    }
}