using System.Web.Mvc;

namespace TECi.Controllers
{
    [AllowAnonymous]
    public class WidgetsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}