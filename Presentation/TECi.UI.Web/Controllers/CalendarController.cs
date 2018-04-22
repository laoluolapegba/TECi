using System.Web.Mvc;

namespace TECi.UI.Web.Controllers
{
    [AllowAnonymous]
    public class CalendarController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}