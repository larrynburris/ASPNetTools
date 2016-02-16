using System.Web.Mvc;
using ASPNetTools.Web.ActionResults;

namespace ASPNetTools.Web.Controllers
{
	public abstract class HeroicCRMControllerBase : Controller
	{
		public BetterJsonResult<T> BetterJson<T>(T model)
		{
			return new BetterJsonResult<T>() {Data = model};
		}
	}
}