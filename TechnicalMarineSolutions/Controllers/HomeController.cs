namespace TechnicalMarineSolutions.Controllers
{
	#region Library Imports

	using System.Web.Mvc;
	using TechnicalMarineSolutions.Attributes;
	using TechnicalMarineSolutions.Models.View;

	#endregion

	//[ApplicationDb]
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View(new HomeViewModel());
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}