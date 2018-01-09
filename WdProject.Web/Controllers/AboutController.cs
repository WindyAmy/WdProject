using System.Web.Mvc;

namespace WdProject.Web.Controllers
{
    public class AboutController : WdProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}