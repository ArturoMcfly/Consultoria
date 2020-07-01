using System.Web.Mvc;

namespace IdentitySample.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Index2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Comunidad()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contacto()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult loginD()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult LoginU()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult productos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult registroD()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult registroU()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Consultoria()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}
