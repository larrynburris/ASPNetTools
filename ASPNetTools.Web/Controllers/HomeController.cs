using System.Web.Mvc;

namespace ASPNetTools.Web.Controllers
{
	public class HomeController : HeroicCRMControllerBase
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}