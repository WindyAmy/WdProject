using System.Web.Mvc;

namespace WdProject.Web.Controllers
{
    public class HomeController : WdProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}